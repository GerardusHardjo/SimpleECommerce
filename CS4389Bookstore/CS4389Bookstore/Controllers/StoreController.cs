using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CS4389Bookstore.Models;

namespace CS4389Bookstore.Controllers
{
    public class StoreController : Controller
    {
        BookstoreEntities storeDB = new BookstoreEntities();
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();

            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = storeDB.Genres.Include("Books").Single(g => g.Name == genre);

            return View(genreModel);
        }

        public ActionResult Details(int id)
        {
            var book = storeDB.Books.Find(id);

            return View(book);  
        }
    }
}
