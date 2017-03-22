using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoDealership.Models;

namespace AutoDealership.Controllers
{
    public class AutomobileController : Controller
    {
        // GET: Automobile
        public ActionResult Index()
        {
            var automobiles = from a in GetAutomobileList()
                              orderby a.ID
                              select a;
            return View(automobiles);
        }

        // GET: Automobile/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Automobile/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Automobile/Create
        [HttpPost]
        public ActionResult Create(Automobile auto)
        {
            try
            {
                // TODO: Add insert logic here

                autoList.Add(auto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Automobile/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Automobile/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var Automobile = autoList.Single(m => m.ID == id);
                if (TryUpdateModel(Automobile))
                {
                    // TODO: Add update logic here
                    return RedirectToAction("Index");
                }

                return View(Automobile);
            }
            catch
            {
                return View();
            }
        }

        // GET: Automobile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Automobile/Delete/5
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

        public List<Automobile> GetAutomobileList()
        {
            return new List<Automobile>
            {
                new Automobile
                {
                    ID = 1,
                    Make = "Nissan",
                    Model = "GT-R",
                    Year = 2010,
                    Color = "Gunmetal"
                },

                new Automobile
                {
                    ID = 1,
                    Make = "Buick",
                    Model = "Grand National",
                    Year = 1987,
                    Color = "Black"
                },

                new Automobile
                {
                    ID = 1,
                    Make = "Chevrolet",
                    Model = "SS",
                    Year = 2013,
                    Color = "Black"
                },

                new Automobile
                {
                    ID = 1,
                    Make = "Lincoln",
                    Model = "Continental",
                    Year = 2017,
                    Color = "Navy"
                },
            };
        }

        public static List<Automobile> autoList = new List<Automobile>
        {
                new Automobile
                {
                    ID = 1,
                    Make = "Nissan",
                    Model = "GT-R",
                    Year = 2010,
                    Color = "Gunmetal"
                },

                new Automobile
                {
                    ID = 1,
                    Make = "Buick",
                    Model = "Grand National",
                    Year = 1987,
                    Color = "Black"
                },

                new Automobile
                {
                    ID = 1,
                    Make = "Chevrolet",
                    Model = "SS",
                    Year = 2013,
                    Color = "Black"
                },

                new Automobile
                {
                    ID = 1,
                    Make = "Lincoln",
                    Model = "Continental",
                    Year = 2017,
                    Color = "Navy"
                },
            };
    }
}
