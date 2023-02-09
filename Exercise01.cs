using System;

namespace Exercise01 {
    static void Main(string[] args)
    {
        System.Console.WriteLine("Enter a number: ");
        string input = Console.ReadLine();
        System.Console.WriteLine("Enter a number: ");
        string input2 = Console.ReadLine();
        System.Console.WriteLine("Enter a number: ");
        string input3 = Console.ReadLine();
        System.Console.WriteLine("Average: " + calc(Convert.ToInt32(input),Convert.ToInt32(input2),Convert.ToInt32(input3)));
    }
    static int calc(int num1, int num2, int num3)
    {            
        int sum = (num1+num2+num3)/3;
        return(sum);
    }
}