using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax for a dictionary

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                { "A1", "Twix" },
                { "A2", "Twizzlers" },
                { "A3", "Reeses" },
                { "A4", "Sour Patch Kids" }
            };
            foreach(KeyValuePair<string, string> item in snackMachine) //can replace KeyValuePair with var
            {
                Console.WriteLine(item);
            }


            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();

            //using add method to add drinks

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Bottled Water");
            drinkMachine.Add(12, "Mountain Dew");
            drinkMachine.Add(13, "Pepsi");
            drinkMachine.Add(14, "Fruit Punch");

            //Counting the number of entries in the dictionary
            Console.WriteLine(drinkMachine.Count);

            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
                Console.WriteLine(drink.Value);
            }





        }
    }
}
