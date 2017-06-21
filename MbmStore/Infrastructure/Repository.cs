using System;
using MbmStore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Infrastructure
{
    public class Repository
    {
        public List<Product> Products = new List<Product>();
        public List<Invoice> Invoices = new List<Invoice>();
        public List<Customer> Customers = new List<Customer>();
        public List<Movie> Movies = new List<Movie>();
        internal IEnumerable<Invoice> invoices;

        //Constructor
        public Repository()
        {
            //BOOKS
            Book b1 = new Book("A Game of Thrones", "George R.R. Martin", 150.00m, "Bantam Spectra", 1996, "9780553808049", 1);
            b1.Publisher = "Bantam Spectra";
            b1.ISBN = "9780553808049";
            b1.ImageUrl = "gameofthrones.jpg";
            b1.Category = "Book";
            Products.Add(b1);

            Book b2 = new Book("The fellowship of the ring", "J.R.R. Tolkien", 200.00m, "Gyldendal", 2012, "9788702134544", 2);
            b2.Publisher = "Gyldendal";
            b2.ISBN = "9788702134544";
            b2.ImageUrl = "lordoftherings.jpg";
            b2.Category = "Book";
            Products.Add(b2);

            //MUSIC CDS

            MusicCD m1 = new MusicCD("Foo Fighters", "Sonic Highways", 150.00m, 2014, 3);
            m1.ImageUrl = "foofighters.jpg";
            m1.Label = "RCA Records";
            m1.Category = "Music";
            m1.AddTrack(new Track("Something from Nothing", "Dave Grohl", new TimeSpan(0, 4, 48)));
            m1.AddTrack(new Track("The Feast and the Famine", "Dave Grohl", new TimeSpan(0, 3, 50)));
            m1.AddTrack(new Track("Congregation", "Dave Grohl", new TimeSpan(0, 5, 12)));
            m1.AddTrack(new Track("What Did I Do? / God As My Witness", "Dave Grohl", new TimeSpan(0, 5, 44)));
            m1.AddTrack(new Track("Outside", "Dave Grohl", new TimeSpan(0, 5, 15)));
            m1.AddTrack(new Track("In the Clear", "Dave Grohl", new TimeSpan(0, 4, 04)));
            m1.AddTrack(new Track("Subterranean", "Dave Grohl", new TimeSpan(0, 6, 08)));
            m1.AddTrack(new Track("Am a River", "Dave Grohl", new TimeSpan(0, 7, 09)));
            //Add to list
            Products.Add(m1);

            MusicCD m2 = new MusicCD("The Script", "#3", 150.00m, 2012, 4);
            m2.ImageUrl = "thescript.jpg";
            m2.Label = "Phonogenic Records";
            m2.Category = "Music";
            m2.AddTrack(new Track("Good Ol' Days", "Sheehan", new TimeSpan(0, 4, 24)));
            m2.AddTrack(new Track("Six Degrees of Separation [Explicit]", "Kipner, Frampton", new TimeSpan(0, 3, 52)));
            m2.AddTrack(new Track("Hall of Fame (feat. will.i.am)", "O'Donoghue, Sheehan, Jimbo Barry", new TimeSpan(0, 3, 23)));
            m2.AddTrack(new Track("If You Could See Me Now", "Kipner, Frampton", new TimeSpan(0, 3, 40)));
            m2.AddTrack(new Track("Glowing", "Sheehan", new TimeSpan(0, 4, 47)));
            m2.AddTrack(new Track("Give the Love Around", "Sheehan", new TimeSpan(0, 4, 25)));
            m2.AddTrack(new Track("Broken Arrow", "Sheehan", new TimeSpan(0, 4, 35)));
            m2.AddTrack(new Track("Kaleidoscope", "Sheehan", new TimeSpan(0, 3, 42)));
            //Add to list
            Products.Add(m2);

            //MOVIES
            Movie jungleBook = new Movie("Jungle Book", 160.50m, "Jon Favreau", 5);
            jungleBook.ImageUrl = "JungleBook.jpg";
            jungleBook.Category = "Movie";
            //Add to list
            Products.Add(jungleBook);

            Movie forrestGump = new Movie("Forrest Gump", 150.50m, "Robert Zemeckis", 6);
            forrestGump.ImageUrl = "forrest-gump.jpg";
            forrestGump.Category = "Movie";
            //Add to list
            Products.Add(forrestGump);

            Movie gladiator = new Movie("Gladiator", 140.50m, "Ridley Scott", 7);
            gladiator.ImageUrl = "gladiator.jpg";
            gladiator.Category = "Movie";
            //Add to list
            Products.Add(gladiator);

            //Customers
            Customer c1 = new Customer(1,"Rasmus", "Christiansen", "Wesselsvej 13", "9220", "Aalborg Ø", "28837075");
            c1.AddPhone("98464096");
            c1.AddPhone("24562139");
            c1.Birthdate = new DateTime(1989, 05, 12);
            //Add to list
            Customers.Add(c1);

            Customer c2 = new Customer(2,"Børge", "Mogensen", "Jyllingevej 17", "9990", "Skagen", "92487289");
            c2.AddPhone("22445588");
            c2.AddPhone("33458902");
            c2.Birthdate = new DateTime(1978, 08, 12);
            //Add to list
            Customers.Add(c2);

            //Invoices
            Invoice i1 = new Invoice(87282452, new DateTime(2016, 09, 28), c1);
            Invoice i2 = new Invoice(98024823, new DateTime(2016, 08, 17), c2);

            //OrderItems
            i1.AddOrderItem(m1, 1);
            i1.AddOrderItem(b2, 1);
            //Add to list
            Invoices.Add(i1);

            i2.AddOrderItem(b1, 1);
            i2.AddOrderItem(gladiator, 1);
            //Add to list
            Invoices.Add(i2);


        }
    }
}