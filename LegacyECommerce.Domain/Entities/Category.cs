using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Domain.Entities
{
    public class Category
    {
        /// 成員屬性
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool Featured { get; set; }
        public DateTime CreateAt { get; set; }

        /// 導航屬性
        public ICollection<Product> Products { get; set; }

        /// 構造函數
        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
