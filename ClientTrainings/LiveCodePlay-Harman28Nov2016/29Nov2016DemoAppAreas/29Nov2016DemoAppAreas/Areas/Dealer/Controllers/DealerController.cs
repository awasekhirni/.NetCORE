using _29Nov2016DemoAppAreas.Areas.Dealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _29Nov2016DemoAppAreas.Areas.Dealer.Controllers
{
    public class DealerController : Controller
    {
        // GET: Dealer/Dealer
        public ActionResult Index()
        {
            DealerModel dm = new DealerModel()
            {
                dealerId=12321312,
                legalName="Trump Motors",
                dbaName="Trump Motor Inc",
                Address="Manhattan Dump Towers",
                webAddress="www.dumptrump.com",
                Email="dumpme@trumpme.com",
                Phone="+123234523"
            };
            return View(dm);
        }

        // GET: Dealer/Dealer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Dealer/Dealer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dealer/Dealer/Create
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

        // GET: Dealer/Dealer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Dealer/Dealer/Edit/5
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

        // GET: Dealer/Dealer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Dealer/Dealer/Delete/5
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
