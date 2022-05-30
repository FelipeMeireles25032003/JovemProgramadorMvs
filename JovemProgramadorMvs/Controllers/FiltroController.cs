using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramadorMvs.Controllers
{
    public class FiltroController : Controller
    {
        public FiltroController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
