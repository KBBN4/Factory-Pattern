namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Hi. Welcome to my Dominican restaurant. I only have 1 option according to time of day. \n " +
                "Here are the options. \n  Breakfast , Lunch or Dinner . ");
            Console.WriteLine(" Please Enter your Choice"); 
            Console.WriteLine();
            Console.WriteLine();
            var UserInput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            IOrderMenu orderChoice= DominicanFood.Food(UserInput);
            orderChoice.Order();
        }
    }
}
// created an Interface called IOrderMenu
// I created 3 Classes
    // Breakfast , Lunch & Dinner = all with assigned values
// created factory called DominicanFood.




