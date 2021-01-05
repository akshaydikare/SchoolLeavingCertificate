using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using LeavingCertificate.Models;
using Rotativa;

namespace LeavingCertificate.Controllers
{
    public class StudentLCDatasController : Controller
    {
        private LcDataEntities db = new LcDataEntities();

        // GET: StudentLCDatas
        public ActionResult Index()
        {
           var students = db.StudentLCData.ToList();
            return View(students);
        }

        // GET: StudentLCDatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentLCData studentLCData = db.StudentLCData.Find(id);
            if (studentLCData == null)
            {
                return HttpNotFound();
            }
            return View(studentLCData);
        }

        // GET: StudentLCDatas/Create
        public ActionResult Create()
        {            
            return View();
        }

        // POST: StudentLCDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AdmissionNo,FullName,Gender,Nationality,MotherTongue,Religion,Caste,SubCaste,BirthPlace,DOBInDigits,DOBInWords,PrevSchlName,AdmittedInClass,AdmissionDate,Progress,ConductBehaviour,DateOfSchlLeaving,ClassFromLeft,ReasonForLeaving,CertificateRcvdDate,ReceivedByName")] StudentLCData studentLCData)
        {
            if (ModelState.IsValid)
            {
                db.StudentLCData.Add(studentLCData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentLCData);

        }

        // GET: StudentLCDatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentLCData studentLCData = db.StudentLCData.Find(id);
            if (studentLCData == null)
            {
                return HttpNotFound();
            }
            return View(studentLCData);
        }

        // POST: StudentLCDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AdmissionNo,FullName,Gender,Nationality,MotherTongue,Religion,Caste,SubCaste,BirthPlace,DOBInDigits,DOBInWords,PrevSchlName,AdmittedInClass,AdmissionDate,Progress,ConductBehaviour,DateOfSchlLeaving,ClassFromLeft,ReasonForLeaving,CertificateRcvdDate,ReceivedByName")] StudentLCData studentLCData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentLCData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentLCData);
        }

        // GET: StudentLCDatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentLCData studentLCData = db.StudentLCData.Find(id);
            if (studentLCData == null)
            {
                return HttpNotFound();
            }
            return View(studentLCData);
        }

        //POST:StudentLCDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentLCData studentLCData = db.StudentLCData.Find(id);
            db.StudentLCData.Remove(studentLCData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Change(string lang)
        {
            if (lang != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            }
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = lang;
            Response.Cookies.Add(cookie);
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

        public ActionResult PrintById(int? id)
        {
            var student = db.StudentLCData.Where(e => e.Id == id).FirstOrDefault();
            return View(student);
        }
        public ActionResult PrintCertificate(int id)
        {
            var report = new ActionAsPdf("PrintById", new { id = id })
            {

                PageMargins = { Left = 5, Bottom = 5, Right = 5, Top = 5 },
                PageSize = Rotativa.Options.Size.A5


            };
            return report;
        }
        public ActionResult Print(int id)
        {
            var report = new ActionAsPdf("PrintById", new { id = id });
            return report;
        }
    }
}
