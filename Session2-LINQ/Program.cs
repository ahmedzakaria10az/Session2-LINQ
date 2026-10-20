using static LINQ.DataSources.Source;

namespace Session2_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            //Sort ProductList by Category ascending, then within each category, sort by UnitPrice descending.
            var products = ProductList
                           .OrderBy(p => p.Category)
                           .ThenByDescending(p => p.UnitPrice);

            foreach (var item in products)
            {
                Console.WriteLine(item);
            }

            //Question 2
            //Get all products from the "Beverages" category, sorted by UnitsInStock descending. Print name and stock.

        }
    }
}
