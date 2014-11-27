using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CS4389Bookstore.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        [DisplayName("Genre")]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Book> Books { get; set; }
    }
}