using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    //Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //string greeting = "My name is Little Bill";
            //string[] words = greeting.Split();

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //string[] days = { "Monday", "Tuesday", "Wednesday" };

            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //string fairyTale = "Once upon a time";
            //string[] storyWords = fairyTale.Split();
            //Array.Reverse(storyWords);

            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            //foreach (string month in months)
            //{
            //    Console.WriteLine(month);
            //}

            //string[] bands = { "Neil Young", "The Kinks", "The Magnetic Fields", "A Tribe Called Quest", "Those Darlins" };

            //foreach (string lalalala in bands)
            //{
            //    Console.WriteLine(lalalala);
            //}

            //string[] favFoods = { "Pizza", "Cake", "Pasta", "Ice Cream", "Candy in General", "Stuffed Peppers" };

            //foreach (string food in favFoods)
            //{
            //    Console.WriteLine(food);
            //}

            //int[] luckyNumbers = { 4, 5, 77, 99, 105, 44, 2, 1, 9 };

            //foreach (int number in luckyNumbers)
            //{
            //    Console.WriteLine("Your Lucky Number is: " + number);
            //}

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Do you want to play the game? (YES/NO)");
            //string playAgain = Console.ReadLine().ToUpper().Trim();
            //while(playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you  want to play again?");
            //    playAgain = Console.ReadLine().ToUpper().Trim();     

            //}

            //Console.WriteLine("Would you like to check into your appointment (YES/NO)");
            //string checkIn = Console.ReadLine().ToUpper().Trim();
            //while(checkIn != "YES" || checkIn == "YES")
            //{
            //    Console.WriteLine("PATIENT CHECK IN SYSTEM");
            //    Console.WriteLine("Please enter your full name");
            //    string fullName = Console.ReadLine();
            //    Console.WriteLine("What is your 6-digit Patient ID?");
            //    string patientID = Console.ReadLine();
            //    Console.WriteLine("What is your appointment time?");
            //    string apptTime = Console.ReadLine();
            //    Console.WriteLine("Would you like to check into your appointment (YES/NO)");
            //    checkIn = Console.ReadLine().ToUpper().Trim();

            //string playAgain;

            //do
            //{
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine().ToUpper();

            //}
            //while (playAgain == "YES");

            //Console.WriteLine("Thanks for playing the game!");

            //string gpaAnswer;
            //string letterGrade;
            //string anotherClass;
            //string salesPush;

            //do
            //{
            //    Console.WriteLine("Which class would you like to add to your GPA?");
            //    gpaAnswer = Console.ReadLine().ToUpper().Trim();
            //    Console.WriteLine("What is your letter grade for the class? (disregard + or -)");
            //    letterGrade = Console.ReadLine().ToUpper().Trim();
            //    Console.WriteLine("Do you have another class your would like to add to your GPA?");
            //    anotherClass = Console.ReadLine().ToUpper().Trim();
            //}
            //while (anotherClass == "YES");

            //Console.WriteLine("Maybe you should take some more classes then. You can sign up here");
            //salesPush = Console.ReadLine().ToUpper().Trim();
            //    if (salesPush != "ab")
            //{
            //    Console.WriteLine("We have mailed the catalog to your address");
            //}

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 13 == 0)
            //    {
            //        break;
            //    }
            //            Console.WriteLine(i);
            //        }
            //Console.WriteLine("The loop has been finished");

            // nested loops below

            //for (int i = 1; i <= 7; i++)
            //{
            //    for (int j = 1; j <= 8; j++)
            //    {
            //        Console.Write(j); // columns
            //    }
            //    Console.WriteLine(); // next row
            //}

            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
