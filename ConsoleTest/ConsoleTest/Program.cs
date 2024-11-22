using SeedData;
using SeedData.Models;
using System.Linq;

var orderlist = GetData.GetCustomers().OrderBy(x => x.age);

var orderlist2 = from o in GetData.GetCustomers()
                 orderby o.age
                 select o;

foreach (var order in orderlist2)
    Console.WriteLine("Id : {0} , name: {1} , age{2}",order.id,order.name,order.age);
