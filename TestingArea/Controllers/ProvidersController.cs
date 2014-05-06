using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestingArea.DAL;
using TestingArea.Models;

namespace TestingArea.Controllers
{
    public class ProvidersController : Controller
    {
        private TopicsContext db = new TopicsContext(ConfigurationManager.ConnectionStrings["TestArea"].ToString());
        [Authorize]
        public ViewResult Index()
        {
            return View(db.Providers.ToList());
        }
        //
        // GET: /Providers/

        //
        // GET: /Providers/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        //
        // GET: /Providers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "Title,Abbreviation")]Provider provider)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Providers.Add(provider);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

            }
            return View(provider);
        }

        //
        // GET: /Providers/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = db.Providers.Find(id);
            return View(provider);
        }

        //
        // POST: /Providers/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "ProviderID,Title,Abbreviation")]Provider provider)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(provider).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
            return View(provider);
        }

        //
        // GET: /Providers/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Provider provider = db.Providers.Find(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            return View(provider);
        }

        //
        // POST: /Providers/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Provider provider = db.Providers.Find(id);
            db.Providers.Remove(provider);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
