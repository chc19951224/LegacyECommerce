using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Domain.Entities
{
    public class Product
    {
        ///成員屬性
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Popular { get; set; }
    }
}
