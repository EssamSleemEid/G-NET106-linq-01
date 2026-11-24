using LINQ.Models;
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
        }
    }
}
