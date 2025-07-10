using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Shared.Results
{
    public class PagedResult<T>
    {
        ///【 成 員 屬 性 】
        public List<T> Items { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public int PageStart { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
