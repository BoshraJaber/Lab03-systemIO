using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Lab03_systemIO
{
    public class Program
    {
        static void Main(string[] args)
        {// challenge 01:
         //Console.WriteLine("Hello, Let's do some challenges");
         //Console.WriteLine("Please enter 3 numbers:");
         //string threeNumbers = Console.ReadLine();
         //Console.WriteLine(FirstChallenge(threeNumbers));

            // challenge 02:
            // Console.WriteLine("Enter a number between 2 and 10");
            // string number = Console.ReadLine();
            //Console.WriteLine(SecondChallengeHelper(number));

            // challenge 03:
            //ThirdChallenge();

            // challenge 04:
            //int[] array = { 1, 5, 10, 11, 2};
            //Console.WriteLine(Challenge4(array));

            //Console.WriteLine(Challenge5(array));
            Challenge6();
            Challenge7();

        }


        // Challenge 01:
        // ctrl+k + ctrl+c to comments muliple lines
        public static int FirstChallenge(string numbers)
        {
            int productResult = 1;
            string[] arrayOfNumbers = numbers.Split(' ');
            if (arrayOfNumbers.Length < 3)
            {
                return 0;
            }
            for (int i = 0; i < 3; i++)
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
        {
            int num = Convert.ToInt32(number);
            int sum = 0;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{i + 1} of {num} - Enter a number:");
                int newNum = Convert.ToInt32(Console.ReadLine());
                sum += newNum;

            }
            SecondChallenge(num, sum);
            return sum;
        }

        public static int SecondChallenge(int roundNumber, int sum)
        {
            return sum / roundNumber;
        }
        public static void ThirdChallenge()
        {
            string space = " ";
            string star = "*";

            //  string[,] arr = new string[9, 9];
            for (int i = 0; i < 9; i++)
            {
                string result = "";
                if (i <= 4) // first half
                {
                    for (int j = 0; j <= 4 - i; j++)
                    {
                        result += space;
                    }
                    for (int j = 4; j <= 4 + i; j++)
                    {
                        result += star;
                    }
                    for (int j = 4; j <= 4 + i; j++)
                    {
                        result += star;
                    }
                    for (int j = 4; j <= 4 + i; j++)
                    {
                        result += space;
                    }


                }
                else // second half
                {
                    for (int j = 0; j <= i - 4; j++)
                    {
                        result += space;
                    }
                    for (int j = 0; j < 9 - i; j++)
                    {
                        result += star;
                    }

                    for (int j = 0; j < 9 - i; j++)
                    {
                        result += star;
                    }
                }
                Console.WriteLine(result);

            }

        }

        public static int Challenge4(int[] array)
        {
            // data type of key and value insside <>
            var dictionary = new Dictionary<int, int>();

            //foreach (var value in array)
            //{
            //    // When the key is not found, "count" will be initialized to 0
            //    dictionary.TryGetValue(value, out int count);
            //    dictionary[value] = count + 1;
            //}
            foreach (int n in array)
            {
                if (!dictionary.ContainsKey(n))
                    dictionary[n] = 0;
                dictionary[n]++;
            }
            //foreach (var pair in dictionary)
            //{ Console.WriteLine(pair); }
            if (dictionary.Values.Max() > 1)
            {
                var max = dictionary.Keys.Max();
                Console.WriteLine(max);
                return max;
            } else
            {
                
               return array[0];
            }


        }

        public static int Challenge5(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if(max < array[i])
                {
                    max = array[i];
                }
              
            }
            return max;
        }

        public static void Challenge6()
        {
            Console.WriteLine(" enter one word to be saved in a text file");
            var word = Console.ReadLine();
            string path = "../../../word.txt";
            using (StreamWriter sw = new StreamWriter(path)) {
                sw.Write(word);
            } ;

        }

        public static void Challenge7()
        {
            Console.WriteLine(File.ReadAllText("../../../word.txt"));
        }
    }
}


