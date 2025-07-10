using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Application.DTOs.Responses
{
    ///【 回 應 數 據 類 】
    public class CategoryResponse
    {
        /// 成員屬性
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImageUrl { get; set; }
        public string CategoryDescription { get; set; }
        public bool PopularCategory { get; set; }
    }
}
