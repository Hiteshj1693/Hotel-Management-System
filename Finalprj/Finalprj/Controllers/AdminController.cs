using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Finalprj.Models;

namespace Finalprj.Controllers
{
    public class AdminController : Controller
    {
        
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult allbookings()
        {
            return View();
        }

        public ActionResult editbookings()
        {
            return View();
        }

        public ActionResult addbookings()
        {
            return View();
        }

        public ActionResult allcustomers()
        {
            return View();
        }

        public ActionResult editcustomers()
        {
            return View();
        }

        public ActionResult addcustomers()
        {
            return View();
        }

        public ActionResult allrooms()
        {
            return View();
        }

        public ActionResult editrooms()
        {
            return View();
        }

        public ActionResult addrooms()
        {
            return View();
        }

        public ActionResult allstaff()
        {
            return View();
        }

        public ActionResult editstaff()
        {
            return View();
        }

        public ActionResult addstaff()
        {
            return View();
        }

        public ActionResult employees()
        {
            return View();
        }

        public ActionResult leaves()
        {
            return View();
        }

        public ActionResult holidays()
        {
            return View();
        }

        public ActionResult attedance()
        {
            return View();
        }
    }
}