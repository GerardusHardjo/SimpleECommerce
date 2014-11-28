using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CS4389Bookstore.Models;

namespace CS4389Bookstore.Controllers
{
    public class HomeController : Controller
    {
        BookstoreEntities storeDB = new BookstoreEntities();

        public ActionResult Index()
        {
            var albums = GetTopSellingBooks(4);

            return View(albums);
        }

        private List<Book> GetTopSellingBooks(int count)
        {
            // Group the order details by book and return
            // the books with the highest count
            return storeDB.Books.OrderByDescending(a => a.OrderDetails.Count()).Take(count).ToList();
        }
    }
}
