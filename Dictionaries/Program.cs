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
            ////syntax for a dictionary

            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    { "A1", "Twix" },
            //    { "A2", "Twizzlers" },
            //    { "A3", "Reeses" },
            //    { "A4", "Sour Patch Kids" }
            //};
            //foreach(KeyValuePair<string, string> item in snackMachine) //can replace KeyValuePair with var
            //{
            //    Console.WriteLine(item);
            //}


            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();

            ////using add method to add drinks

            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Bottled Water");
            //drinkMachine.Add(12, "Mountain Dew");
            //drinkMachine.Add(13, "Pepsi");
            //drinkMachine.Add(14, "Fruit Punch");

            ////Counting the number of entries in the dictionary
            //Console.WriteLine(drinkMachine.Count);

            //foreach (KeyValuePair<int, string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key);
            //    Console.WriteLine(drink.Value);
            //}


            //create a dictionary for a theater coat check with 10 elements
            //the key will be a number and the value will be the coat style
            //print all elements to the console

            Dictionary<int, string> coatCheck = new Dictionary<int, string>();
            coatCheck.Add(1, "Leather Jacket");
            coatCheck.Add(2, "Bomber Jacket");
            coatCheck.Add(3, "Northface Jacket");
            coatCheck.Add(4, "Puffer Vest");
            coatCheck.Add(5, "Hoodie");
            coatCheck.Add(6, "Biker Vest");
            coatCheck.Add(7, "Carhart Jacket");
            coatCheck.Add(8, "Jean Jacket");
            coatCheck.Add(9, "Blazer Jacket");
            coatCheck.Add(10, "Winter Coat");

            Console.WriteLine(coatCheck.Count);

            foreach(KeyValuePair<int, string> coat in coatCheck)
            {
                Console.WriteLine(coat.Key);
                Console.WriteLine(coat.Value);
            }




            //Car valet with 10 cars 
            //the key will be the customers last name and the value will be the car make
            //print all of the elements to the console

            Dictionary<string, string> nameCar = new Dictionary<string, string>();
            nameCar.Add("Miller", "Dodge Stratus");
            nameCar.Add("Porter", "Chevy Malibu");
            nameCar.Add("Summerfield", "Jeep Cherokee");
            nameCar.Add("Wilhoit", "Chevy Silverado");
            nameCar.Add("Prentice", "Caddy CTS");
            nameCar.Add("Baughman", "KIA Sorento");
            nameCar.Add("Zirk", "Dodge Durango");
            nameCar.Add("Tolson", "Ford Focus");
            nameCar.Add("Crosett", "Minivan");
            nameCar.Add("Jones", "GMC Terrain");

            Console.WriteLine(nameCar.Count);

            foreach (KeyValuePair<string, string> name in nameCar)
            {
                Console.WriteLine(name.Key);
                Console.WriteLine(name.Value);
            }



            //create a dictionary of 10 zoo animals 
            //the key will be the animal type
            //the value will be the number of animals
            //print the animal with the highest quantity to the console
            //remove the zoo animal with the lowest count
            //remove the animal with the lowest count with the remove method
            //user should be able to enter a new animal if that animal does not exist

            Dictionary<string, int> animalCount = new Dictionary<string, int>();
            animalCount.Add("Lion", 8);
            animalCount.Add("Elephants", 12);
            animalCount.Add("Monkeys", 25);
            animalCount.Add("Bears", 6);
            animalCount.Add("Zebras", 3);
            animalCount.Add("Giraffes", 10);
            animalCount.Add("Tigers", 9);
            animalCount.Add("Snakes", 17);
            animalCount.Add("Otters", 15);
            animalCount.Add("Gorillas", 19);

            Console.WriteLine(animalCount.Count);

            foreach(KeyValuePair<string, int> animal in animalCount)
            {
                if(animal.Value <= tempMin)
                {
                    tempMin = animal.Value;

                }
              
            }


            





        }
    }
}
