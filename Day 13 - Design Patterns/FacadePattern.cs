using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13___Design_Patterns
{

    public class Product
    {
        public void fetchProduct()
        {
            Console.WriteLine("Fetching Product...");
        }
    }
    public class Payment
    {
        public void fetchPayment()
        {
            Console.WriteLine("Fetch Payment...");
        }
    }
    public class Invoice
    {
        public void sendInvoice()
        {
            Console.WriteLine("Sending Invoice...");
        }
    }



    public class FacadePattern
    {
        public void PlaceOrder()
        {
            Console.WriteLine("\n\nPlace Order Started...!!");

            Product p1 = new Product();
            p1.fetchProduct();

            Payment payment = new Payment();
            payment.fetchPayment();

            Invoice invoice = new Invoice();
            invoice.sendInvoice();
        }

    }
}
