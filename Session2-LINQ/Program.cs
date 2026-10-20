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


            //Question 4
            //Show position number alongside ProductName

            //var products = ProductList
            //              .Select((p,i) => new
            //               {
            //                  Position = i + 1,
            //                  p.ProductName
            //               });


            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}


            //Question 5
            //Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //String [] Arr = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};

            //string[] Arr = {"aPPLE", "AbAcUs", "bRaNcH","BlUeBeRrY", "ClOvEr", "cHeRry"};

            //var words = Arr.OrderBy(s => s.Length)
            //               .ThenBy(s => s,StringComparer.OrdinalIgnoreCase);


            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}


            //Question 6
            //Create a list of all digits in the array whose second letter is 'i'
            //at is reversed from the order in the original array.

            //string[] Arr = {"aPPLE", "AbAcUs", "bRaNcH","BlUeBeRrY", "ClOvEr", "cHeRry"};

            //var words = Arr.Where(s => s.Length > 1 && s[1] == 'i')
            //               .Reverse();

            //foreach (var item in words)
            //{
            //    Console.WriteLine(item);
            //}


            //Question 7
            //Get top 3 most expensive products

            //var products = ProductList
            //               .OrderByDescending(p => p.UnitPrice)
            //               .Take(3);

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}


            //Question 8
        }
    }
}
