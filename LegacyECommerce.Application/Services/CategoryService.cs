using LegacyECommerce.Application.DTOs.Requests;
using LegacyECommerce.Application.DTOs.Responses;
using LegacyECommerce.Application.IServices;
using LegacyECommerce.Application.Mappers;
using LegacyECommerce.Domain.Entities;
using LegacyECommerce.Domain.IRepositories;
using LegacyECommerce.Shared.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Application.Services
{
    ///【 服 務 實 現 類 】
    public class CategoryService : ICategoryService
    {
        #region【 ===== 依 賴 注 入 ===== 】
        ///【 成 員 屬 性 】
        private readonly ICategoryRepository _categoryRepository;

        ///【 構 造 函 數 】
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        #endregion

        #region【 ===== 服 務 實 現 類 方 法 ===== 】
        ///【 分 頁 查 詢 】
        async Task<PagedResult<CategoryResponse>> ICategoryService.QueryCategories(string searchKey, int pageNumber, int pageSize)
        {
            ///【分頁計算】
            // 計算記錄總數
            var totalRecords = await _categoryRepository.GetAll().Count();

            // 計算起始頁
            var pageStart = 1;
            if (totalRecords == 0)
            {
                pageStart = 0;
            }

            // 計算分頁總數
            var totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            // 計算偏移量
            var offset = ((pageNumber - 1) * pageSize);

            ///【執行分頁】
            var pagedItems = await _categoryRepository.GetAll()
                .Where(c => c.Name.Contains(searchKey))
                .OrderByDescending(c => c.Name)
                .Skip(offset)
                .Take(pageSize)
                .ToList();

            ///【實體映射】
            var mappedItems = pagedItems.AsQueryable().Select(CategoryMapper.EntityToResponse).ToList();

            ///【封裝結果】
            return new PagedResult<CategoryResponse>
            {
                Items = mappedItems,
                TotalPages = totalPages,
                TotalRecords = totalRecords,
                PageStart = pageStart,
                PageSize = pageSize,
                PageNumber = pageNumber
            };
        }
        #endregion

        // BR2 查詢指定分類
        //public CategoryResponse FindCategoryById(int id)
        //{
        //    using (var context = new MarketplaceDbContext())
        //    {
        //        var product = context.Categories
        //            .Select(CategoryMapper.EntityToCategoryDto)
        //            .FirstOrDefault(c => c.CategoryId == id);
        //        return product;
        //    }
        //}

        //// BC1 新增數據庫分類
        //public void AddCategory(CategoryRequest tableData)
        //{
        //    using (var context = new MarketplaceDbContext())
        //    {
        //        var categoryEntity = CategoryMapper.CategoryDtoToEntity(tableData);
        //        bool isExist = context.Categories.Any(c => c.Name == categoryEntity.Name);

        //        if (!isExist)
        //        {
        //            context.Categories.Add(categoryEntity);
        //            context.SaveChanges();
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

        //// BU1 修改數據庫分類
        //public void ModifyCategory(CategoryRequest tableData)
        //{
        //    using (var context = new MarketplaceDbContext())
        //    {
        //        var cartegoryEntity = CategoryMapper.CategoryDtoToEntity(tableData);
        //        var isExist = context.Categories.Any(c => c.Id == tableData.CategoryId);

        //        if (isExist)
        //        {
        //            context.Entry(cartegoryEntity).State = EntityState.Modified;
        //            context.SaveChanges();
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

        /////【 BD1 刪除數據庫分類 】
        //public void RemoveCategoryById(int id)
        //{
        //    using (var context = new MarketplaceDbContext())
        //    {
        //        var entity = context.Categories.Find(dtoId);
        //        if (entity != null)
        //        {
        //            context.Entry(entity).State = EntityState.Deleted;
        //            context.SaveChanges();
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}
    }
}
