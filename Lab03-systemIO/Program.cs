using System;
using System.IO;

namespace Lab03_systemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter 3 numbers:");
            string threeNumbers = Console.ReadLine();
            Console.WriteLine(FirstChallenge(threeNumbers));


        }
        // Challenge 01:
       // ctrl+k + ctrl+c to comments muliple lines
        static int FirstChallenge(string numbers)
        {
           int productResult = 1;
            string[] arrayOfNumbers = numbers.Split(' ');
            if(arrayOfNumbers.Length < 3)
            {
                return 0;
            }
            for(int i=0; i<3; i++)
            {
                int number;
                // TryPase will convert string to int and save itside number 
               
                if (int.TryParse(arrayOfNumbers[i], out number))
                {
                    productResult *= number;
                }
                else
                {
                    productResult *= 1;
                }

            }
            return productResult;
        }
    }
}


