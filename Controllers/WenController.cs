using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Upravljalec_nalog.Controllers
{
    public class WenController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


    }
}