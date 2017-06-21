using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Product
    {
        public string Title
        {
            get; set;
        }
        public decimal Price
        {
            get; set;
        }
        public string ImageUrl
        {
            get; set;
        }
        public int ProductId
        {
            get;set;
        }
        public string Category
        {
            get; set;
        }
        //Constructors
        public Product()
        {

        }
        public Product (string title, decimal price, int productId)
        {
            Title = title;
            Price = price;
            ProductId = productId;
        }
    }
}