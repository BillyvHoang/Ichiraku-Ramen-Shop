using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IchirakuRamenShop
{
    public class ShopOwner 
    {
        public static void Welcome()
        {
            Console.WriteLine("Hello there customer...");
            //Thread.Sleep(1500);
            Console.WriteLine("Welcome to Ichiraku Ramen!...");
            //Thread.Sleep(2000);
            Console.WriteLine("What is your name?");

        }

        public static void Hungry(string name)
        {
            Console.WriteLine($"Well {name}, How hungry are yah?");
        }

        public static void askingPrice()
        {
            Console.WriteLine($"How much do you want to spend?");
        }
      


          
    }
}
