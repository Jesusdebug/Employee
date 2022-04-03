using DemoMVCAccessData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibraryEmployees;
using DataLibraryEmployees.BussinessLogic;

namespace DemoMVCAccessData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult viewEmployees()
        {
            ViewBag.Message = "Employees List";
            var data = EmployeeProcessor.loadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var item in data)
            {
                employees.Add(new EmployeeModel
                {
                    FirstName= item.FirstName,
                    LastName= item.LastName,
                    EmailAddress= item.EmailAddress,
                    Password= item.Password
                });
            }
            return View(employees);
        }
        public ActionResult SignUp()
        {
            ViewBag.Message = "you sigUp view";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                int recodsCreatd= EmployeeProcessor.CreateEmployee(model.EmployeeId, model.FirstName, model.LastName, model.EmailAddress, model.Password);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}