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
    public class HomeController : Controller
    {
        private FinalprjEntities1 db = new FinalprjEntities1();
        
        public HomeController()
        {
            db = new FinalprjEntities1();
        }
        public ActionResult Index()
        {
            return View();
        }
        // GET: Userssses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users usersss = db.Users.Find(id);
            if (usersss == null)
            {
                return HttpNotFound();
            }
            return View(usersss);
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

        public ActionResult register()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        // POST: Userses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult register([Bind(Include = "id,name,email,password,confirmpassword")] Users users)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(users);
        }

        public ActionResult login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}