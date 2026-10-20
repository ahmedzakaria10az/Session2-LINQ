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
            //show page 2 of products, with page size= 5

            //int pageNumber = 2;
            //int pageSize = 5;

            //var products = ProductList
            //              .Skip((pageNumber - 1) * pageSize)
            //              .Take(pageSize);

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}


            //Question 9
            //Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).

            //var products = ProductList
            //               .OrderBy(p => p.UnitPrice)
            //               .TakeWhile(p => p.UnitPrice < 25);

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}


            //Question 10
            //Check if ALL products in the"Seafood" category are in stock

            //bool result = ProductList
            //              .Where(p => p.Category == "Seafood")
            //              .All(p => p.UnitsInStock > 0);

            //Console.WriteLine(result);


            //Question 11
            //Check if the ID list contains 9 int[] ids={ 3, 9, 13, 18};

            //int[] ids = { 3, 9, 13, 18 };

            //bool result = ids.Contains(9);

            //Console.WriteLine(result);


            //Question 12
            //Group all products by Category and print each group with its product count.

            //var groups = ProductList.GroupBy(p => p.Category);

            //foreach (var item in groups)
            //{
            //    Console.WriteLine($"Item key: {item.Key} ---- Item Count: {item.Count()}");
            //}


            //Question 13
            //Group products by Category and project only product names per group

            // var groups = from p in ProductList
            //              group p by p.Category 
            //              into Category
            //              select new
            //              {
            //                  Category = Category.Key,
            //                  ProductNames = Category.Select(p => p.ProductName)
            //              };


            // foreach (var group in groups)
            // {
            //     Console.WriteLine(group.Category);

            //     foreach (var name in group.ProductNames)
            //     {
            //         Console.WriteLine(name);
            //     }

            //Console.WriteLine("-------------------------------------");

            // }


            //Question 14
            //Find all categories that have MORE THAN 3 products

            //var categories = ProductList.GroupBy(p => p.Category)
            //                            .Where(g => g.Count() > 3);

            //foreach (var group in categories)
            //{
            //    Console.WriteLine($"Group key: {group.Key} ------ Group count: {group.Count()}");
            //}
        }
    }
}
