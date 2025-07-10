using LegacyECommerce.Application.DTOs.Requests;
using LegacyECommerce.Application.DTOs.Responses;
using LegacyECommerce.Application.IServices;
using LegacyECommerce.Shared.Results;
using LegacyECommerce.Web.ViewModels;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        public async Task<CategoryListViewModel> QueryCategoriesAsync(string searchKey, int pageNumber, int pageSize)
        {
            /// 規範關鍵字
            var isEmpty = string.IsNullOrWhiteSpace(searchKey);
            var isValid = Regex.IsMatch(searchKey, @"^[\u4E00-\u9FFFa-zA-Z]+$");

            /// 檢查合法輸入
            if (isEmpty || isValid)
            {
                // 服務層查詢
                var data = await _categoryService.QueryCategories(searchKey, pageNumber, pageSize);

                // 返回封裝的視圖模型
                return new CategoryListViewModel
                {
                    Result = data,
                    Information = new BaseResult
                    {
                        Message = "查詢成功！",
                        Code = StatusCodes.Success
                    }
                };
            }

            /// 非法輸入
            return new CategoryListViewModel
            {
                Result = null,
                Information = new BaseResult
                {
                    Message = "關鍵字只能包含中文、英文或數字!",
                    Code = StatusCodes.BadRequest
                }
            };
        }

        ///【 新 增 分 類 】
        [HttpPost]
        [Route("Create")]
        public async void AddCategory(CategoryRequest category, HttpPostedFileBase image)
        {

        }

        #endregion


        //#region 【 新 增 】
        //[HttpPost]
        //[Route("CreateCategory")]
        //public ActionResult CreateCategory(CategoryDTO.Category tableData, HttpPostedFileBase CategoryImageUrl)
        //{
        //    try
        //    {
        //        if (CategoryImageUrl != null && CategoryImageUrl.ContentLength > 0)
        //        {
        //            string fileName = Path.GetFileName(CategoryImageUrl.FileName);
        //            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
        //            string serverFilePath = Path.Combine(Server.MapPath("~/Content/Images/Categories/"), uniqueFileName);
        //            CategoryImageUrl.SaveAs(serverFilePath);

        //            tableData.CategoryImageUrl = "/Content/Images/Categories/" + uniqueFileName;
        //        }


        //        bool result = categoryService.AddCategory(tableData);
        //        if (result)
        //        {
        //            return Json(new
        //            {
        //                Success = true,
        //                Message = "新增分類成功！",
        //                RedirectUrl = Url.Action("ManageCategoryPage", "Backend")
        //            });
        //        }
        //        else
        //        {
        //            return Json(new
        //            {
        //                Success = false,
        //                Message = "新增分類失敗！分類名稱重複！",
        //                RedirectUrl = Url.Action("ManageCategoryPage", "Backend")
        //            });
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        return Json(new { Success = false, Message = ex.Message });
        //    }
        //}
        //#endregion

        //#region 【 更 新 】
        //[HttpPost]
        //public ActionResult UpdateCategory(CategoryDTO.Category tableData, HttpPostedFileBase CategoryImageUrl)
        //{
        //    try
        //    {
        //        if (CategoryImageUrl != null && CategoryImageUrl.ContentLength > 0)
        //        {
        //            string fileName = Path.GetFileName(CategoryImageUrl.FileName);
        //            string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
        //            string serverFilePath = Path.Combine(Server.MapPath("~/Content/Images/Categories/"), uniqueFileName);
        //            CategoryImageUrl.SaveAs(serverFilePath);

        //            tableData.CategoryImageUrl = "/Content/Images/Categories/" + uniqueFileName;
        //        }
        //        else
        //        {
        //            var originTableData = categoryService.FindCategoryById(tableData.CategoryId);
        //            tableData.CategoryImageUrl = originTableData.CategoryImageUrl;
        //        }

        //        bool result = categoryService.ModifyCategory(tableData);
        //        if (result)
        //        {
        //            return Json(new
        //            {
        //                Success = true,
        //                Message = "更新分類成功！",
        //                RedirectUrl = Url.Action("ManageCategoryPage", "Backend")
        //            });
        //        }
        //        else
        //        {
        //            return Json(new
        //            {
        //                Success = false,
        //                Message = "更新分類失敗！沒有找到該分類！",
        //                RedirectUrl = Url.Action("ManageCategoryPage", "Backend")
        //            });
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        return Json(new { Success = false, Message = ex.Message });
        //    }
        //}
        //#endregion

        //#region 【 刪 除 】
        //[HttpPost]
        //public ActionResult DeleteCategory(int dtoId)
        //{
        //    try
        //    {
        //        bool result = categoryService.RemoveCategoryById(dtoId);
        //        if (result)
        //        {
        //            return Json(new { Success = true, Message = "刪除分類成功！" });
        //        }
        //        else
        //        {
        //            return Json(new { Success = false, Message = "刪除分類失敗！沒有找到該分類！" });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Success = false, Message = ex.Message });
        //    }
        //}
        //#endregion
    }
}