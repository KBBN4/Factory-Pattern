using System;
namespace FactoryPattern
{
	public static class DominicanFood 
	{
        
        public static IOrderMenu Food( string Choice)
		{
			switch (Choice)
			{
				case "Breakfast":
					return new Breakfast();

				case "Lunch":
					return new Lunch();

				case "Dinner":
					return new Dinner();

				default:
					return new Breakfast();

			}
				
		}

        public static void Order()
        {
            throw new NotImplementedException();
        }
    }
}

