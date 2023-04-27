using System;
namespace FactoryPattern
{
	public class Lunch : IOrderMenu
	{
		public Lunch()
		{
		}
        public String ItemChoosen = "White Rice, Beans and Stewed Chicken";
        public double Price { get; set; } = 7.99;
        public bool StayOrGo { get ; set ; }
        public int TotalItemAmount { get ; set ; }

        public void Order()
        {
            Console.WriteLine($" You have choosen the best for Lunch . Some {ItemChoosen}. The total is ${Price}. Hope you enjoy it as much as i do .   :) ") ;
        }
    }
}

