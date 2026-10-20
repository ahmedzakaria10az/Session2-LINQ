using static LINQ.DataSources.Source;

namespace Session2_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            //Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.
            //var products = ProductList
            //               .OrderBy(p => p.Category)
            //               .ThenByDescending(p => p.UnitPrice);

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}


            //Question 2
            //Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.
            //var products = ProductList
            //              .Where(p => p.Category == "Beverages")
            //              .OrderByDescending(p => p.UnitsInStock);

            //foreach (var p in products)
            //{
            //    Console.WriteLine($"ProductName: {p.ProductName} ---- UnitsInStock: {p.UnitsInStock}");
            //}


            //Question 3
            //Using QUERY SYNTAX with a compound from clause, list all orders placed in 1997 or later showing CustomerID and OrderDate.
            //var orders = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate >= new DateTime(1997)
            //             select new
            //             {
            //                 c.CustomerID,
            //                 o.OrderDate
            //             };

            //foreach (var item in orders)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
