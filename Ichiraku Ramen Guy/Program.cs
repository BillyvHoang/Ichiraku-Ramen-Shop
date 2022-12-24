using System;

namespace IchirakuRamenShop
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            Customer Customer1 = new Customer();
            RamenGuy.Welcome();
            Customer1.Name = Console.ReadLine();
            RamenGuy.Hungry(Customer1.Name);
            Customer1.HungerBar = Console.ReadLine();
            RamenGuy.askingPrice();
            Customer1.Balance = Convert.ToDouble(Console.ReadLine());
           
            








            Console.Read();
        }
    }
}