using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Invoice
    {
        //Fields
        private decimal totalPrice;
        private List<OrderItem> orderItems = new List<OrderItem>();

        //Properties
        public int InvoiceID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get{ return orderItems; } }

        //Constructors
        public Invoice(int invoiceID, DateTime orderDate, Customer customer )
        {
            InvoiceID = invoiceID;
            OrderDate = orderDate;
            Customer = customer;
        }

        //Method
        public void AddOrderItem(Product product, int quantity)
        {
            orderItems.Add(new OrderItem(product, quantity));
        }
        public Decimal GetTotalPrice()
        {
            Decimal sum = new Decimal();
            foreach (OrderItem oi in OrderItems)
            {
                sum = oi.Product.Price + sum;
            }
            return sum;
        }


    }
}