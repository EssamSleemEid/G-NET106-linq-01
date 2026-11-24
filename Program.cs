using LINQ.Models;
using System.Drawing;
using System.Xml.Linq;
using static LINQ.DataSources.Source;
namespace G_NET106_linq_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //​Get all products from the "Seafood" category. Print each product's name and price
            var Seafood = ProductList.Where(p => p.Category == "Seafood").Select(p => new { p.ProductName, p.UnitPrice });
            foreach (var item in Seafood)
            {
                Console.WriteLine("Name:"+item.ProductName+" Price:"+item.UnitPrice+"$");
            }
            #endregion

            #region Question02
            //​Get a list of only the product names from ProductList. Print each name
            var onlyname = ProductList.Select(p => p.ProductName);
            foreach (var name in onlyname)
            {
                Console.WriteLine(name);
            }
            #endregion

            #region Question04
            //​Get all products where UnitPrice is between 10 and 30
            var PriceRange = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);
            foreach (var item in PriceRange)
            {
                Console.WriteLine("Name:" + item.ProductName + " Price:" + item.UnitPrice + "$");
            }
            #endregion

            #region Question05
            //Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category
            var inStock = ProductList.Where(p => p.UnitsInStock > 0 && p.Category.Contains("Condiments"));
            foreach (var item in inStock)
            {
                Console.WriteLine("Name:"+item.ProductName+" Stock:"+item.UnitsInStock+" Category:"+item.Category);
            }
            #endregion

            #region Question06
            //​Create a new anonymous type with three properties: ●​Name → the product name●​Price → the unit price●​StockStatus → a string: "Available" if UnitsInStock > 0, otherwise "Out of Stock" ●​Print the result.
            var q6 = ProductList.Select(p => new{ Name = p.ProductName, Price = p.UnitPrice, StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"});
            foreach (var item in q6)
            {
                Console.WriteLine("Name:"+item.Name+" Price:"+item.Price+"$"+" Status:"+item.StockStatus);
            }
            #endregion

            #region Question07
            //Print each product's name along with its position (1-based) in the list. Expected format: 1.Chai, 2.Chang, etc
            var ProductPosition = ProductList.Select((p, index) => $"{index + 1}. {p.ProductName}");
            foreach (var item in ProductPosition)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question11
            //Show position number alongside ProductName
            var ProductNamePosition = ProductList.Select((p, index) => new{ Position = index + 1, p.ProductName});
            foreach (var item in ProductNamePosition)
            {
                Console.WriteLine("Position:"+item.Position+" Product:"+item.ProductName);
            }
            #endregion
        }
    }
}
