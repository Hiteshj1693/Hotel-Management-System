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
    public class BookingInfoesController : Controller
    {
        private FinalprjEntities1 db = new FinalprjEntities1();

        // GET: BookingInfoes
        public ActionResult Index()
        {
            return View(db.BookingInfo.ToList());
        }

        // GET: BookingInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingInfo bookingInfo = db.BookingInfo.Find(id);
            if (bookingInfo == null)
            {
                return HttpNotFound();
            }
            return View(bookingInfo);
        }

        // GET: BookingInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookingID,Name,RoomType,TotalMembers,BookingDate,BookingTime,ArrivalDate,DepartureTime,EmailID,PhoneNumber,FileUpload,Message")] BookingInfo bookingInfo)
        {
            if (ModelState.IsValid)
            {
                db.BookingInfo.Add(bookingInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookingInfo);
        }

        // GET: BookingInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingInfo bookingInfo = db.BookingInfo.Find(id);
            if (bookingInfo == null)
            {
                return HttpNotFound();
            }
            return View(bookingInfo);
        }

        // POST: BookingInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookingID,Name,RoomType,TotalMembers,BookingDate,BookingTime,ArrivalDate,DepartureTime,EmailID,PhoneNumber,FileUpload,Message")] BookingInfo bookingInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookingInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookingInfo);
        }

        // GET: BookingInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookingInfo bookingInfo = db.BookingInfo.Find(id);
            if (bookingInfo == null)
            {
                return HttpNotFound();
            }
            return View(bookingInfo);
        }

        // POST: BookingInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookingInfo bookingInfo = db.BookingInfo.Find(id);
            db.BookingInfo.Remove(bookingInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
