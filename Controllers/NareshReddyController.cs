using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFramework2.Models;

namespace EntityFramework2.Controllers
{
    public class NareshReddyController : Controller
    {
        NareshReddyContext db = new NareshReddyContext();
        // GET: NareshReddy
        public ActionResult Index()
        {
            db.CatagiriesTable.ToList();
            db.productsTable.ToList();
            return View();
        }
    }
}