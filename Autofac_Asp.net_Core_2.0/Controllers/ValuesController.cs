using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Autofac_Asp.net_Core_2._0.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IDAL _dal;
        public ValuesController(IDAL dal)
        {
            _dal = dal;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return _dal.Insert();
        }

    }
}
