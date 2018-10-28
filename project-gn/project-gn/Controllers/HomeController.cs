using project_gn.Repository;
using project_gn.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace project_gn.Controllers
{
    public class HomeController : Controller
    {
        private CompanySizeRepository companySizeRepository;

        public HomeController() {
            this.companySizeRepository = new CompanySizeRepository();
        }

        public ActionResult Index()
        {
            return View(companySizeRepository.GetAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}