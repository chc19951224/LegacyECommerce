using LegacyECommerce.Application.DTOs.Responses;
using LegacyECommerce.Shared.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Application.IServices
{
    ///【 分 類 服 務 接 口 類 】
    public interface ICategoryService
    {
        ///【 查 詢 方 法 】
        Task<PagedResult<CategoryResponse>> QueryCategories(string searchKey, int pageNumber, int pageSize);
        //PagedResponse<CategoryResponse> FindCategoryById(int id);

        ///【 新 增 方 法 】
        //void AddCategory(CategoryRequest tableData);

        /////【 修 改 方 法 】
        //void ModifyCategory(CategoryRequest tableData);

        /////【 刪 除 方 法 】
        //void RemoveCategoryById(int id);
    }
}
