using SeedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Extentions
{
    public static class Filter
    {
        public static List<Customer> getByName(this List<Customer> list,string name)
        {
            List<Customer> result = new List<Customer>();
            foreach (var item in list) {
                if (item.name.ToLower().Contains("ahmed")){
                    result.Add(item);

                }
            }
            return result;

        }
        public static List<Customer> GetCustomers(this List<Customer> list, Func<Customer, bool> func)
        {
            List<Customer> lis = new List<Customer>();
            foreach (var item in list)
            {
                if (func(item))
                {
                    lis.Add(item);

                }
            }
            return list;

        }
    }
    }

