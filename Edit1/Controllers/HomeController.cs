using Edit1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edit1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RecordModel rm = new RecordModel();
            var records = rm.Records.ToList(); ;
            return View(records);
        }

        public ActionResult Details(int id)
        {
            RecordModel rm = new RecordModel();
            return View(rm.Records.FirstOrDefault(d => d.Id == id));
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            RecordModel rm = new RecordModel();
            return View(rm.Records.FirstOrDefault(d => d.Id == id));
        }

        [HttpPost]
        public ActionResult Edit(Record r)
        {
            RecordModel rm = new RecordModel();
            rm.Entry(r).State = EntityState.Modified;
            rm.SaveChanges();
            return View("Index", rm.Records.ToList());
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            RecordModel rm = new RecordModel();
            return View(rm.Records.FirstOrDefault(d => d.Id == id));
        }

        [HttpPost]
        public ActionResult Delete(Record r)
        {
            RecordModel rm = new RecordModel();
            rm.Entry(r).State = EntityState.Deleted;
            rm.SaveChanges();
            return View("Index", rm.Records.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            RecordModel rm = new RecordModel();
            return View(new Record());
        }

        [HttpPost]
        public ActionResult Create(Record r)
        {
            RecordModel rm = new RecordModel();
            rm.Records.Add(r);
            //rm.Entry(r).State = EntityState.Added;
            rm.SaveChanges();
            return View("Index", rm.Records.ToList());
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