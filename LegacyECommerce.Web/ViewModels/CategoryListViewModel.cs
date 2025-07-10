using LegacyECommerce.Application.DTOs.Responses;
using LegacyECommerce.Shared.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LegacyECommerce.Web.ViewModels
{
    ///【 視 圖 模 型 】
    public class CategoryListViewModel
    {
        ///【 成 員 屬 性 】
        public PagedResult<CategoryResponse> Result {get;set;}
        public BaseResult Information { get; set; }
    }
}