using System;
namespace FactoryPattern
{
	public interface IOrderMenu
	{
		public double Price { get; set; }

		public bool StayOrGo { get; set; }

		public int TotalItemAmount { get; set; }

		public void Order();
	}

}

