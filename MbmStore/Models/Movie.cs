using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // fields
        private string title; 
        private decimal price; 
        private string director;

        // properties
        public string Title
        {
            get { return title; } // read
        }

        public decimal Price 
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else {
                    price = value;
                }
            }
            get { return price; }
        }


        public string ImageUrl 
        {
            get; set;
        }
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        // constructors
        public Movie(string title, decimal price)
        {
            this.title = title;
            this.price = price;
        }

        public Movie(string title, decimal price, string director, int productId) :base(title, price, productId)
        {
            this.title = title;
            this.price = price;
            this.director = director;
        }
    }
}