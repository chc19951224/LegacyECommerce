using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Application.DTOs.Requests
{
    ///【 分 類 數 據 請 求 類 】
    public class CategoryRequest
    {
        ///【 成 員 屬 性 】
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImageUrl { get; set; }
        public string CategoryDescription { get; set; }
        public bool PopularCategory { get; set; }
    }
}
