using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Shared.Results
{
    public class BaseResult
    {
        ///【 成 員 屬 性 】
        public string Message { get; set; } = string.Empty;
        public StatusCodes Code { get; set; }

        ///【 構 造 函 數 】
        ///【成功】
        public static BaseResult Success(string message)
        {
            return new BaseResult { Code = StatusCodes.Success, Message = message };
        }

        ///【失敗】
        public static BaseResult Fail(string message)
        {
            return new BaseResult { Code = StatusCodes.BadRequest, Message = message };
        }
    }
}
