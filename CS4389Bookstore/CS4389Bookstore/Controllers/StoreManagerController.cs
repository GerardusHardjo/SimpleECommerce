using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CS4389Bookstore.Models;

namespace CS4389Bookstore.Controllers
{
    [Authorize(Roles="Admin")]
    public class StoreManagerController : Controller
    {
        private BookstoreEntities db = new BookstoreEntities();

        //
        // GET: /StoreManager/

        public ActionResult Index()
        {
            var books = db.Books.Include(b => b.Genre).Include(b => b.Author);
            return View(books.ToList());
        }

        //
        // GET: /StoreManager/Details/5

        public ActionResult Details(int id = 0)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        //
        // GET: /StoreManager/Create

        public ActionResult Create()
        {
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name");
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name");
            return View();
        }

        //
        // POST: /StoreManager/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", book.GenreId);
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name", book.AuthorId);
            return View(book);
        }

        //
        // GET: /StoreManager/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", book.GenreId);
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name", book.AuthorId);
            return View(book);
        }

        //
        // POST: /StoreManager/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(db.Genres, "GenreId", "Name", book.GenreId);
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorId", "Name", book.AuthorId);
            return View(book);
        }

        //
        // GET: /StoreManager/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Book book = db.Books.Find(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Book book = db.Books.Find(id);
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}