using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week04Lab.Models.Week04;
using System.Threading.Tasks;
using Week04Lab.Models;

namespace Week04Lab.Controllers
{
    public class LabController : Controller
    {
        private LabContext db = new LabContext();
        private CityProvinceViewModel model = new CityProvinceViewModel();
        // GET: Lab
        public ActionResult Index()
        {
            model.CityModel = db.Cities.ToList();
            model.ProvModel = db.Provinces.ToList();

            return View(model);
        }

        // GET: Lab/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lab/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lab/Create
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

        // GET: Lab/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lab/Edit/5
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

        // GET: Lab/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lab/Delete/5
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
