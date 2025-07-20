using LegacyECommerce.Application.DTOs.Requests;
using LegacyECommerce.Application.DTOs.Responses;
using LegacyECommerce.Application.IServices;
using LegacyECommerce.Shared.Helpers;
using LegacyECommerce.Shared.Results;
using LegacyECommerce.Web.ViewModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LegacyECommerce.Web.Controllers
{
    ///【 分 類 API 控 制 器 類 】
    [RoutePrefix("CategoryApi")]
    public class CategoryApiController : Controller
    {
        #region【 ===== 依 賴 注 入 ===== 】
        ///【 成 員 屬 性 】
        private readonly ICategoryService _categoryService;

        ///【 構 造 函 數 】
        public CategoryApiController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        #endregion

        #region 【 ===== 請 求 與 回 應 方 法 ===== 】
        ///【 查 詢 分 類 】
        [HttpPost]
        [Route("Query")]
        public CategoryListViewModel QueryCategories(string searchKey, int pageNumber, int pageSize)
        {
            /// 規範關鍵字
            var isEmpty = string.IsNullOrWhiteSpace(searchKey);
            var isValid = Regex.IsMatch(searchKey, @"^[\u4E00-\u9FFFa-zA-Z]+$");

            /// 檢查合法輸入
            if (isEmpty || isValid)
            {
                // 服務層查詢
                var data = _categoryService.QueryCategories(searchKey, pageNumber, pageSize);

                // 返回封裝的視圖模型
                return new CategoryListViewModel
                {
                    Result = data,
                    Information = BaseResult.Success("查詢成功")
                };
            }

            /// 非法輸入
            return new CategoryListViewModel
            {
                Result = null,
                Information = BaseResult.BadRequest("關鍵字只能包含中文、英文或數字!")
            };
        }

        ///【 新 增 分 類 】
        [HttpPost]
        [Route("Create")]
        public JsonResult CreateCategory(CreateCategoryRequest request)
        {
            ///【參數驗證】
            if (!ModelState.IsValid)
            {
                return Json(BaseResult.BadRequest("驗證失敗"));
            }

            ///【文件處理】
            var file = Request.Files["file"];
            if (file != null && file.ContentLength > 0)
            {
                var downloadName = ImageHelper.SaveCategoryImage(file);
                request.Image = downloadName;
            }

            ///【調用服務方法】
            var operationResult = _categoryService.CreateCategory(request);
            if (operationResult)
            {
                return Json(BaseResult.Success("新增分類成功~", Url.Action("ManageCategory", "Backend")));
            }
            return Json(BaseResult.BadRequest("新增分類失敗！已含有同名分類！", Url.Action("CreateCategory", "Backend")));
        }
        #endregion
    }
}