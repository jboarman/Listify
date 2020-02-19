using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ListifyWebAPI.Controllers
{
    [Route("listify")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET listify?begin=&end=&idx=
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(int? begin, int? end, int? idx)
        {
            if (begin == null || end == null || idx == null)
            {
                string httpString = this.Request.IsHttps ? "https://" : "http://";
                return new string[] { "Enter url as " + httpString + this.Request.Host  + "/listify?begin=x&end=x&idx=x", "replace the 'x' after each '=' with whatever values you want."  };
            }

            Listify _list = new Listify();
            _list.AddRange(Enumerable.Range(begin.Value, end.Value));

            return new string[] { _list[idx.Value].ToString() };
        }
    }
}
