using System;

namespace DrinkApp
{
    class DrinkTest
    {
        static void Main(string[] args)
        {
            //create a new object
            Drink mondayDrink = new Drink(); 

            //initial value
            Console.WriteLine($"Monday's favorite drink is: {mondayDrink.GetDrink()}"); 

            // prompt
            Console.Write("What is your favorite morning drink today:           "); 

            //store drink name
            String favDrink = Console.ReadLine();

            // put drink name in object
            mondayDrink.SetDrink(favDrink);

            //output the name from the object
            Console.WriteLine($"My fasvorite morning drink is {mondayDrink.GetDrink()}");

        }//end Main
    }//End Class DrinkTest
}//End Namespace
