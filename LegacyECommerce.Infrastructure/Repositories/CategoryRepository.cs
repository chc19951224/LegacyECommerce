using LegacyECommerce.Domain.Entities;
using LegacyECommerce.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Infrastructure.Repositories
{
    ///【 數 據 訪 問 類 】
    public class CategoryRepository : ICategoryRepository
    {
        #region【 ===== 依 賴 注 入 ===== 】
        ///【 成 員 屬 性 】
        private readonly MyDbContext _myDbContext;

        ///【 構 造 函 數 】
        public CategoryRepository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        #endregion

        #region【 ===== 數 據 實 現 類 方 法 ===== 】
        ///【 獲 取 所 有 分 類 】
        IQueryable<Category> ICategoryRepository.GetAll()
        {
            var categories = _myDbContext.Categories;
            return categories;
        }

        ///【 獲 取 指 定 分 類 】
        Category ICategoryRepository.GetById(int id)
        {
            var category = _myDbContext.Categories.Find(id);
            return category;
        }

        ///【 查 詢 分 類 】
        bool ICategoryRepository.IsDuplicateName(Category category)
        {
            return _myDbContext.Categories.Any(c => c.Name == category.Name);
        }

        ///【 新 增 分 類 】
        void ICategoryRepository.Add(Category category)
        {
            category.CreateAt = DateTime.Now;
            _myDbContext.Categories.Add(category);
        }

        ///【 修 改 分 類 】
        void ICategoryRepository.Update(Category category)
        {

        }

        ///【 刪 除 分 類 】
        void ICategoryRepository.Delete(int id)
        {

        }

        ///【 提 交 操 作 】
        void ICategoryRepository.Commit()
        {
            _myDbContext.SaveChanges();
        }
        #endregion
    }
}
