using CSA.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CSAApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICSAService _service;
        public HomeController(ICSAService service)
        {
            _service = service;
        }
        public async Task<ActionResult> Index()
        {
  
            return View( );
        }

        public async Task<ActionResult> About()
        {
            var list = await _service.GetAllClients();
            return View(list.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}