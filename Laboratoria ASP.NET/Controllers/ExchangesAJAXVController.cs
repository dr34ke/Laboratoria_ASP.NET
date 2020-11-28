using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratoria_ASP.NET.Database;
using Laboratoria_ASP.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratoria_ASP.NET.Controllers
{
    [Route("api/[controller]")]
    public class ExchangesAJAXVController : ControllerBase
    {
        [HttpPost]
        public AjaxSucc Post(Form item)
        {
            var response = new AjaxSucc(item);
            return response;
        }
    }
}
