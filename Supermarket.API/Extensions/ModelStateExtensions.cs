using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermarket.API.Extensions
{
    public static class ModelStateExtensions
    {

        /// <summary>
        /// Representaa los errores que vamos a tener al validar.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <returns></returns>
        public static List<string> GetErrorMessages(this ModelStateDictionary dictionary)
        {
            return dictionary.SelectMany(m => m.Value.Errors)
                             .Select(m => m.ErrorMessage)
                             .ToList();
        }
    }
}
