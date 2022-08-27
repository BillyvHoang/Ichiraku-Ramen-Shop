using System;

namespace IchirakuRamenShop
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            Customer Customer1 = new Customer();
            ShopOwner.Welcome();
            Customer1.Name = Console.ReadLine();
            ShopOwner.Hungry(Customer1.Name);
            Customer1.HungerBar = Console.ReadLine();
            ShopOwner.askingPrice();
            Customer1.Balance = Convert.ToDouble(Console.ReadLine());
           
            








            Console.Read();
        }
    }
}