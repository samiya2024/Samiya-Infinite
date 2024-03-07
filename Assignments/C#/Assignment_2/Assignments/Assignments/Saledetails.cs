using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Saledetails
    {
        private int salesNo;
        private int productNo;
        private double price;
        private DateTime dateOfSale;
        private int qty;
        private double totalAmount;

        // Constructor
        public Saledetails(int salesNo, int productNo, double price, DateTime dateOfSale, int qty)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.dateOfSale = dateOfSale;
            this.qty = qty;

            // Call Sales method to update TotalAmount
            Sales();
        }

        // Method to update TotalAmount
        private void Sales()
        {
            totalAmount = qty * price;
        }

        // Method to display data
        public void ShowData()
        {
            Console.WriteLine("-----------Saledetails--------------");
            Console.WriteLine($"Sales No: {salesNo}");
            Console.WriteLine($"Product No: {productNo}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Date of Sale: {dateOfSale}");
            Console.WriteLine($"Quantity: {qty}");
            Console.WriteLine($"Total Amount: {totalAmount}");
            Console.ReadLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // Example Usage
            Saledetails sale = new Saledetails(1, 101, 25.50, DateTime.Now, 5);

            // Display data
            sale.ShowData();
        }
    }
}