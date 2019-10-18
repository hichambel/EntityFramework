using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseForFred;

namespace DatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //adding a product
            var p = new Product();
            p.ProductDescription = "PS4";
            p.ProductUpc = "5242";
            var newProd = DB.AddProduct(p).ProductId;
            //adding a customer
            var cust = new Customer();
            cust.CustomerFirstName = "Hicham";
            cust.CustomerLastName = "Belkaid";
            var newCust = DB.AddCustomer(cust).CustomerId;
            //adding a sale
            var sale = new Sale();
            sale.ProductId = newProd;
            sale.CustomerId = newCust;
            sale.SaleDate = new DateTime(2019, 6, 15, 7, 15, 0);
            var newSaleId = DB.AddSale(sale).SaleId;

            var cust2 = new Customer();
            cust2.CustomerFirstName = "Karim";
            cust2.CustomerLastName = "Ibrahim";
            var updatedCustomer = DB.UpdateCustomer(newCust, cust2);


         
        }

    }
    }
}
