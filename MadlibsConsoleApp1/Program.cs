using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadlibsConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
     This program generates a Mad Libs story.
     Author: Mohammed Kekli.
     Description: This program prompts the user to input various words (like nouns, adjectives, etc.)
     and then inserts those words into a pre-defined story template to create a funny and unique story.
     */

            // Let the user know that the program is starting:
            Console.WriteLine("Welcome to the Mad Libs game! Let's create a fun story together.");

            // Give the Mad Lib a title:
            string title = "A Hilarious Day in the Neighborhood";

            Console.WriteLine(title);

            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            string adjective1 = Console.ReadLine();

            Console.Write("Enter another adjective: ");
            string adjective2 = Console.ReadLine();

            Console.Write("Enter one more adjective: ");
            string adjective3 = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            string pluralNoun1 = Console.ReadLine();

            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter an adverb: ");
            string adverb = Console.ReadLine();

            Console.Write("Enter another noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("Enter another name: ");
            string name2 = Console.ReadLine();

            Console.Write("Enter another noun: ");
            string noun3 = Console.ReadLine();

            Console.Write("Enter another noun: ");
            string noun4 = Console.ReadLine();

            Console.Write("Enter another noun: ");
            string noun5 = Console.ReadLine();

            Console.Write("Enter a year: ");
            string year = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            string pluralNoun2 = Console.ReadLine();

            // New inputs for additional fun
            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.Write("Enter a food: ");
            string food = Console.ReadLine();

            Console.Write("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.Write("Enter a superhero: ");
            string superhero = Console.ReadLine();

            Console.Write("Enter a country: ");
            string country = Console.ReadLine();

            Console.Write("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.Write("Enter a year: ");
            string newYear = Console.ReadLine();

            // The template for the story:
            string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {name2}, who flew {superhero} to {country} and dropped {dessert} in a puddle of frozen {name}. {name} woke up in the year {year}, in a world where {pluralNoun2}s ruled the world. Later, {name} saw a {animal} eating a {food} while a {superhero} was flying over {country}. They decided to enjoy a {dessert} together, reminiscing about the year {newYear}.";

            // Print the story:
            Console.WriteLine(story);
        }
    }
}
