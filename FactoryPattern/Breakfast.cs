using System;
namespace FactoryPattern
{
	public class Breakfast : IOrderMenu
	{
		public Breakfast()
		{
		}

        public string ItemChoosen = "Traditional Dominican breakfast";
        public double Price { get; set; } = 5.99;
        public bool StayOrGo { get ; set ; }
        public int TotalItemAmount { get; set; } = 1;

        public void Order()
        {
            Console.WriteLine($" For Breafast you have choosen {ItemChoosen} . Here is your Item Count ( {TotalItemAmount} ) \n " +
                $"along with the price $ {Price}. Hope you Enjoy!");
        }
    }
}

