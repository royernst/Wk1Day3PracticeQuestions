using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Day3PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many values would you like to compare? (Choose 1-4)");
            int values = int.Parse(Console.ReadLine());

            if (values == 1)
            {
                Console.WriteLine("What are you trying to check?");
                Console.WriteLine("Choose 1 to check for even or odd numbers.");
                Console.WriteLine("Choose 2 to check for positive or negative numbers.");
                Console.WriteLine("Choose 3 to check for vowels or consonants.");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Please input the number you'd like to check.");
                    int evenOdd = int.Parse(Console.ReadLine());
                    if (evenOdd % 2 != 0)
                    {
                        Console.WriteLine("Your number is odd.");
                    } else if (evenOdd %2 == 0)
                    {
                        Console.WriteLine("Your number is even.");
                    } else
                    {
                        Console.WriteLine("You broke my program.  Thanks.");
                    }
                } else if (choice == 2)
                {
                    Console.WriteLine("Please input the number you'd like to check.");
                    int posNeg = int.Parse(Console.ReadLine());
                    if (posNeg > 0)
                    {
                        Console.WriteLine("Your number is positive.");
                    } else if (posNeg < 0)
                    {
                        Console.WriteLine("Your number is negative.");
                    } else if (posNeg == 0)
                    {
                        Console.WriteLine("Your number is exactly 0, so it's neither positive nor negative.");
                    } else
                    {
                        Console.WriteLine("You broke my program.  Thanks.");
                    }
                } else if (choice == 3)
                {
                    Console.WriteLine("Please input the letter you'd like to check.");
                    string vowCon = Console.ReadLine().ToLower();

                    /*
                    Console.WriteLine("Please enter a letter.");
                    char yourLetter = char.Parse(Console.ReadLine());
                    
                    switch (yourLetter)
                    {
                        case 'a':
                            Console.WriteLine("This is a vowel");
                            break;
                        case 'e':
                            Console.WriteLine("This is a vowel");
                            break;
                        etc etc etc etc
                    */

                    String[] vowels = new String[] { "a", "e", "i", "o", "u" };
                    String[] consonants = new String[] { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z"};

                    if (vowels.Contains(vowCon))
                    {
                        Console.WriteLine("Your letter is a vowel.");
                    } else if (consonants.Contains(vowCon))
                    {
                        Console.WriteLine("Your letter is a consonant.");
                    } else if (vowCon == "y")
                    {
                        Console.WriteLine("Your letter is sometimes a vowel, but sometimes a consonant.");
                    } else
                    {
                        Console.WriteLine("You broke my program.  Thanks.");
                    }
                } else
                {
                    Console.WriteLine("You've chosen an invalid option.  Try again later.");
                }
            } else if (values == 2)
            {
                Console.WriteLine("What are you trying to check?");
                Console.WriteLine("Choose 1 to check for equality.");
                Console.WriteLine("Choose 2 to check for greater numbers.");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Please input your first whole number.");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please input the second whole number.");
                    int num2 = int.Parse(Console.ReadLine());

                    if (num1 == num2)
                    {
                        Console.WriteLine("Your numbers are equal to each other.");
                    } else if (num1 != num2)
                    {
                        Console.WriteLine("Your numbers are not equal to each other.");
                    } else
                    {
                        Console.WriteLine("You broke my program.  Thanks.");
                    }
                } else if (choice == 2)
                {
                    Console.WriteLine("Please input your first whole number.");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please input the second whole number.");
                    int num2 = int.Parse(Console.ReadLine());

                    if (num1 > num2)
                    {
                        Console.WriteLine(num1 + " is the larger number.");
                    }
                    else if (num1 < num2)
                    {
                        Console.WriteLine(num2 + " is the larger number.");
                    }
                    else if (num1 == num2)
                    {
                        Console.WriteLine("Both numbers are equal.");
                    }
                    else
                    {
                        Console.WriteLine("You broke my program.  Thanks.");
                    }
                } else
                {
                    Console.WriteLine("You've input an incorrect choice.  Try again later.");
                }
            } else if (values == 3)
            {
                Console.WriteLine("This program is designed to find the largest number out of 3 choices.");
                Console.WriteLine("Please input your first whole number.");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please input the second whole number.");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please input the third whole number.");
                int num3 = int.Parse(Console.ReadLine());

                if (num1 > num2 && num1 > num3)
                {
                    Console.WriteLine(num1 + " is the larger number.");
                }
                else if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine(num2 + " is the larger number.");
                }
                else if (num3 > num1 && num3 > num2)
                {
                    Console.WriteLine(num3 + " is the larger number.");
                }
                else if (num1 == num2 && num1 == num3)
                {
                    Console.WriteLine("All numbers are equal.");
                }
                else
                {
                    Console.WriteLine("You broke my program.  Thanks.");
                    }
            } else if (values == 4)
            {
                Console.WriteLine("This program returns the mean for 4 numbers");
                Console.WriteLine("Please input your first number.");
                decimal num1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please input the second number.");
                decimal num2 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please input the third number.");
                decimal num3 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please input the third number.");
                decimal num4 = decimal.Parse(Console.ReadLine());

                decimal mean = (num1 + num2 + num3 + num4) / 4;

                Console.WriteLine("The mean is: " + mean);
            } else
            {
                Console.WriteLine("You've input an incorrect number.  Try again later.");
            }
        }
    }
}
