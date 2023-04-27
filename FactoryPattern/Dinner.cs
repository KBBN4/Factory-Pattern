using System;
namespace FactoryPattern
{
	public class Dinner: IOrderMenu
	{
		public Dinner()
		{
		}
        public string ItemChoosen { set; get; } = " Light Soup";
        public double Price { get; set; } = 8.99;
        public bool StayOrGo { get; set; } = true;
        public int TotalItemAmount { get ; set ; }

        public void Order()
        {
            Console.WriteLine($"You have made a great choice ! here is your {ItemChoosen} and the amount due is ${Price}. Your belly is going to enjoy it !  "); ;
        }
    }
}

