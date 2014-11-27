using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CS4389Bookstore.Models
{
    public class BookstoreEntities : DbContext  
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Author> Authors { get; set; }
    }
}