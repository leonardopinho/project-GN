using project_gn.Models;
using project_gn.Repository;
using System;
using System.Net;
using System.Web.Mvc;

namespace project_gn.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerRepository customer;

        public CustomerController()
        {
            customer = new CustomerRepository();
        }

        // GET: Customer
        public ActionResult Index()
        {
            CompanySizeRepository sizes = new CompanySizeRepository();
            ViewBag.CompanySizeList = sizes.GetAll();
            ViewBag.Title = "Customer";
          
            return View();
        }

        public ActionResult Insert(Customer model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    customer.Insert(model);
                }
                catch (Exception e)
                {
                    TempData["Message"] = "Erro ao cadastrar usuário.";
                    return RedirectToAction("Index", "Home");
                }
            }

            TempData["Message"] = "Sucesso ao cadastrar usuário.";
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            CompanySizeRepository sizes = new CompanySizeRepository();
            ViewBag.CompanySizeList = sizes.GetAll();
            ViewBag.Title = "Customer";

            CustomerRepository customer = new CustomerRepository();
            Customer Customer = customer.GetById((int)id);
            
            return View(Customer);
        }

        public ActionResult Update(Customer model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    customer.Update(model);
                }
                catch (Exception e)
                {
                    TempData["Message"] = "Erro ao atualizar o usuário.";
                    return RedirectToAction("Index", "Home");
                }
            }

            TempData["Message"] = "Sucesso ao atualizar o usuário.";
            return RedirectToAction("Index", "Home");
        }
    }
}