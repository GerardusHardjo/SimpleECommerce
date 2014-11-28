using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CS4389Bookstore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<BookstoreEntities>
    {
        protected override void Seed(BookstoreEntities context)
        {
            var genres = new List<Genre>
            {
                new Genre {Name = "Horror"},
                new Genre {Name = "Fantasy"},
                new Genre {Name = "Crime"},
                new Genre {Name = "Comedy"}
            };

            var authors = new List<Author>
            {
                new Author {Name = "Stephen King"},
                new Author {Name = "William Peter Blatty"},
                new Author {Name = "George R. R. Martin"},
                new Author {Name = "Patrick Rothfuss"},
                new Author {Name = "Stieg Larsson"},
                new Author {Name = "Henning Mankell"},
                new Author {Name = "Garth Ennis"},
                new Author {Name = "Douglas Adams"}
            };

            new List<Book>
            {
                new Book { Title = "Pet Sematary", Genre = genres.Single(g => g.Name == "Horror"), Price = 8.99M, Author = authors.Single(a => a.Name == "Stephen King"), BookArtUrl = "/Content/Images/PS.jpg" },
                new Book { Title = "The Exorcist", Genre = genres.Single(g => g.Name == "Horror"), Price = 8.99M, Author = authors.Single(a => a.Name == "William Peter Blatty"), BookArtUrl = "/Content/Images/TE.JPG" },
                new Book { Title = "A Game of Thrones", Genre = genres.Single(g => g.Name == "Fantasy"), Price = 8.99M, Author = authors.Single(a => a.Name == "George R. R. Martin"), BookArtUrl = "/Content/Images/GT.jpg" },
                new Book { Title = "The Name of the Wind", Genre = genres.Single(g => g.Name == "Fantasy"), Price = 8.99M, Author = authors.Single(a => a.Name == "Patrick Rothfuss"), BookArtUrl = "/Content/Images/NW.jpg" },
                new Book { Title = "The Girl with the Dragon Tattoo", Genre = genres.Single(g => g.Name == "Crime"), Price = 8.99M, Author = authors.Single(a => a.Name == "Stieg Larsson"), BookArtUrl = "/Content/Images/GD.jpeg" },
                new Book { Title = "Faceless Killers", Genre = genres.Single(g => g.Name == "Crime"), Price = 8.99M, Author = authors.Single(a => a.Name == "Henning Mankell"), BookArtUrl = "/Content/Images/FK.jpg" },
                new Book { Title = "The Pro", Genre = genres.Single(g => g.Name == "Comedy"), Price = 8.99M, Author = authors.Single(a => a.Name == "Garth Ennis"), BookArtUrl = "/Content/Images/TP.jpg" },
                new Book { Title = "Hitchhiker's guide to the galaxy", Genre = genres.Single(g => g.Name == "Comedy"), Price = 8.99M, Author = authors.Single(a => a.Name == "Douglas Adams"), BookArtUrl = "/Content/Images/HH.jpg" },
            }.ForEach(a => context.Books.Add(a));
        }
    }
}