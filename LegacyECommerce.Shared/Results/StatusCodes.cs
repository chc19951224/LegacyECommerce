using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Shared.Results
{
    public enum StatusCodes
    {
        Success = 200,
        BadRequest = 400,
        Unauthorized = 401,
        NotFound = 404,
        ServerError = 500,
        ValidationFailed = 1001
    }
}
