using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantClass
{
    public class Restaurant
    // Restaurant Class that includes three pieces of information: name, address and gratuity rate.
    {
        // Instance variables
        private string name;
        private string address;
        private double gratuityRate;


        // Properties with get and set for all instance variables
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public double GratuityRate
        {
            get { return gratuityRate; }

            // Gratuity rate cannot be negative
            set
            {
                if (value > 0)
                {
                    gratuityRate = value;
                }
            }
        }


        public Restaurant(string name, string address, double gratuityRate)
        // Constructor to initalize the three instance variables
        {
            Name = name;
            Address = address;
            GratuityRate = gratuityRate;
        }



        public void GenerateReceipt()
        // Generate Receipt method used to generate sales receipt
        {
            double price = 0;
            double subtotal = 0;
            double gratuityAmount = 0;
            double grandTotal = 0;
            int people = 0;

            while (price != -1)
            {
                subtotal += price;
                Console.WriteLine("Enter price of food item: [-1 to exit] ");
                price = Convert.ToDouble(Console.ReadLine());


            }

            Console.WriteLine("How many people are in your party: ");
            people = Convert.ToInt32(Console.ReadLine());

            if (people >= 6)
            {
                gratuityAmount = subtotal * gratuityRate;
            }

            grandTotal = subtotal + gratuityAmount;

            Console.WriteLine("Subtotal is: {0:C}", subtotal);
            Console.WriteLine("{0:P} Gratuity: {1:C}", gratuityRate, gratuityAmount);
            Console.WriteLine("Grand Total: {0:C}", grandTotal);

        }
    }
}