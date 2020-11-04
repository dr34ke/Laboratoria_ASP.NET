using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratoria_ASP.NET.Models
{
    public class AjaxSucc
    {
        public bool success { get; set; }
        public Form item { get; set; }

        public AjaxSucc(Form _item)
        {
            success = true;
            item = _item;
        }
    }
}
