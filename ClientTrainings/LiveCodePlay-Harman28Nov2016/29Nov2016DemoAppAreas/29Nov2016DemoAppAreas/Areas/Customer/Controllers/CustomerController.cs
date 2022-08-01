using _29Nov2016DemoAppAreas.Areas.Customer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _29Nov2016DemoAppAreas.Areas.Customer.Controllers
{
    public class CustomerController : Controller
    {
        
        // GET: Customer/Customer
        public ActionResult Index()
        {
            CustomerModel cm = new CustomerModel()
            {
                customerId=123123,
                customerName="Donald Trump",
                customerAddress="Dump Towers",
                customerEmployerName="TRUMP Corporation",
                customerEmpStatus="FTE",
                province="NewYork",
                Salary = 232323.23,
                salaryType="biweekly"
            };
            return View(cm);
        }

        // GET: Customer/Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
