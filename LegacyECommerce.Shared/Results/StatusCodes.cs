using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Shared.Results
{
    public enum StatusCodes
    {
        // 成功
        Success = 200,

        // 前端錯誤
        BadRequest = 400,

        // 未授權
        Unauthorized = 401,

        // 空白頁
        NotFound = 404,

        // 後端錯誤
        ServerError = 500
    }
}
