using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Application.DTOs.Requests
{
    ///【 分 類 數 據 請 求 類 】
    public class CreateCategoryRequest
    {
        ///【 成 員 屬 性 】
        //分類編號
        public int Id { get; set; }

        // 分類名稱
        [Required(ErrorMessage = "分類名稱必須填入！")]
        [MaxLength(30, ErrorMessage = "名稱不得超過 30 字！")]
        public string Name { get; set; }

        // 分類描述
        [MaxLength(100, ErrorMessage ="描述不得超過 100 字！")]
        public string Description { get; set; }

        // 分類圖片
        public string Image { get; set; }

        // 熱門分類
        public bool Featured { get; set; }
    }
}
