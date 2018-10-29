using project_gn.Repository;
using project_gn.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace project_gn.Controllers
{
    public class HomeController : Controller
    {
        private CustomerRepository customerRepository;

        public HomeController() {
            this.customerRepository = new CustomerRepository();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home";

            var msg = TempData["Message"] as string;
            ViewBag.Message = msg;

            return View(customerRepository.GetAll());
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