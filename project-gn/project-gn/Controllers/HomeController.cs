using project_gn.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace project_gn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<CompanySize> list = new List<CompanySize>();

            using (var context = new ProjectGn())
            {
                var query = from g in context.CompanySize
                            select new { companySize = g };

                foreach (var res in query)
                {
                    CompanySize item = new CompanySize();
                    item.Id = res.companySize.Id;
                    item.Type = res.companySize.Type;

                    list.Add(item);
                }
            }
            return View(list);
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