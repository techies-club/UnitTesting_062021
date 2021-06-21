using MVCProject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProject.Controllers
{
    public class FacilityController : Controller
    {
        IFacilityService _facilityService;        
        public FacilityController(IFacilityService facilityService)
        {
            _facilityService = facilityService;            
        }

        // GET: Facility
        public ActionResult Index()
        {
            return View(_facilityService.GetFacilities());
        }

        // GET: Facility/Details/5
        public ActionResult FacilityByZip(string value)
        {
            return View(_facilityService.GetFacilitiesForZip(value));
        }

        // GET: Facility/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Facility/Create
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

        // GET: Facility/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Facility/Edit/5
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

        // GET: Facility/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Facility/Delete/5
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
