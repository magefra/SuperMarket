using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Domain.Services.Communication
{
    public class BaseResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public bool Success { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        public string Message { get; protected set; }

        public BaseResponse(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
