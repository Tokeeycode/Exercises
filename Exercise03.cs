using System;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {


            /*

            Write a console application that prompts the user to input the planet they came from

            If the input is "Earth" display the message "You are an earthling.".
            If the input is "Mars" display the message "You are a martian.".
            If the input is "Jupiter" display the message "You are a jupiterian.".
            For any unspecified planet, display the message "I do not know that planet.".

            */

            Console.WriteLine("What planet are you from?");
            string input = Console.ReadLine();

            switch (input.ToLower()) {
                case "earth":
                    Console.WriteLine("You are an earthling.");
                    break;
            case "mars":
                    Console.WriteLine("You are a martian.");
                    break;
            case "jupiter":
                    Console.WriteLine("You are a jupiterian.");
                    break;
            default:
                    Console.WriteLine("I do not know that planet.");
                    break;
            }
            


        }
    }
}