using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantClass
{
    public class RestaurantTest
    {
        public static void Main(string[] args)
        // Main method used to test Restaurant.cs 
        {
            Restaurant obj = new Restaurant("Dairy Queen", "123 Main St.", .15);

            Console.WriteLine("{0}", obj.Name);
            Console.WriteLine("{0}", obj.Address);

            obj.GenerateReceipt();
        }
    }

}