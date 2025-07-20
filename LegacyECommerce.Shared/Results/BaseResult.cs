using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Shared.Results
{
    public class BaseResult
    {
        ///【 成 員 屬 性 】
        public string Message { get; set; } = string.Empty;
        public string RedirectPage { get; set; } = string.Empty;
        public StatusCodes Code { get; set; }

        ///【 構 造 函 數 】
        protected BaseResult() { }


        ///【 工 廠 方 法 模 式 】
        ///【成功】
        public static BaseResult Success(string message)
        {
            return new BaseResult
            {
                Code = StatusCodes.Success,
                Message = message
            };
        }

        public static BaseResult Success(string message, string redirectUrl)
        {
            return new BaseResult
            {
                Code = StatusCodes.Success,
                Message = message,
                RedirectPage = redirectUrl
            };
        }

        ///【前端錯誤】
        public static BaseResult BadRequest(string message)
        {
            return new BaseResult
            {
                Code = StatusCodes.BadRequest,
                Message = message
            };
        }

        public static BaseResult BadRequest(string message, string redirectUrl)
        {
            return new BaseResult
            {
                Code = StatusCodes.BadRequest,
                Message = message,
                RedirectPage = redirectUrl
            };
        }

        ///【未授權】
        public static BaseResult Unauthorized()
        {
            return new BaseResult
            {
                Code = StatusCodes.Unauthorized,
                Message = "錯誤原因：身份認證未通過！"
            };
        }

        ///【空白頁】
        public static BaseResult NotFound()
        {
            return new BaseResult
            {
                Code = StatusCodes.NotFound,
                Message = "錯誤原因：找不到該頁面！"
            };
        }

        ///【後端錯誤】
        public static BaseResult ServerError()
        {
            return new BaseResult
            {
                Code = StatusCodes.ServerError,
                Message = "錯誤原因：後端發生錯誤！"
            };
        }
    }
}
