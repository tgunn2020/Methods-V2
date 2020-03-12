using System;

namespace Methods_V2
{
    class Program
    {
        static void introduction()
        {
            Console.WriteLine("Hello, I am Tyler Gunnells." + "This Version = 25" + "\n");

            Console.WriteLine("Please enter your chosen string of Charecters." + "\n");
        }

        static void userMessage(int value, string userString)
        {
            int times = value;
            for (int i =0; i<times; i++) 
            {
                Console.WriteLine(userString);
            }
        }

        public static void Main(string[] args)
        {
            introduction();

            String userString = Console.ReadLine();

            string s1 = "Please enter a valid integer.";
            string s2 = "Please enter a valid whole number from 1-5.";
            string s3 = "Enter a numeral value. Ex. 1,2,3,4, or 5.";

            string[] errorMessage = { s1, s2, s3 };

            int numString = 3;
            int stringIndex;
            int value;

            Random x = new Random();

            Console.WriteLine("\n" + "Please enter an integer value." + "\n");

            try
            {
                while (int.TryParse(Console.ReadLine(), out value))
                {

                    if (value >= 2 && value <= 5)
                    {
                        userMessage(value, userString);
                    }
                    else
                    {
                        Console.Clear();
                        stringIndex = x.Next(0, numString);
                        Console.Write(errorMessage[stringIndex] + "\n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("(0) Exception Caught.", e);
            }

        }
    }
}
