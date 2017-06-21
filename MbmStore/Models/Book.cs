using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Book : Product
    {
        public string Author
        {
            get; set;
        }
        public string Publisher
        {
            get; set;
        }
        public short Published
        {
            get; set;
        }
        public string ISBN
        {
            get; set;
        }
        //Constructors
        public Book ()
        {

        }
        public Book (string title, string author, decimal price, string publisher, short published, string isbn, int productId) : base(title, price, productId)
        {
            Author = author;
            Publisher = publisher;
            Published = published;
            ISBN = isbn;
        }
    }
}