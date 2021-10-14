using System;
using System.IO;

namespace Lab03_systemIO
{
   public class Program
    {
        static void Main(string[] args)
        {// challenge 01:
            Console.WriteLine("Hello, Let's do some challenges");
            Console.WriteLine("Please enter 3 numbers:");
            string threeNumbers = Console.ReadLine();
            Console.WriteLine(FirstChallenge(threeNumbers));

         // challenge 02:
            Console.WriteLine("Enter a number between 2 and 10");
            string number = Console.ReadLine();
           Console.WriteLine(SecondChallengeHelper(number));

        }


        // Challenge 01:
       // ctrl+k + ctrl+c to comments muliple lines
        public static int FirstChallenge(string numbers)
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
    public static int SecondChallengeHelper(string number)
        { int num = Convert.ToInt32(number);
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i+1} of {num} - Enter a number:");
                int newNum = Convert.ToInt32(Console.ReadLine());
                sum += newNum;

            }
            SecondChallenge(num, sum);
            return sum;
        }

        public static int SecondChallenge(int roundNumber,  int sum)
        {
            return sum / roundNumber;
        }


    }
}


