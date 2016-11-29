using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekend_Work_week4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------Problem 1
            //Console.Write("Please enter sentence to reverse: ");
            //string[] reverseSentence = { };



            //int[] myArray = new int[6];
            //Console.Write("Enter a number: ");
            //myArray[0] = int.Parse(Console.ReadLine());

            //string[] birthMonths = {"October","July",};
            //Console.WriteLine(Array.IndexOf(birthMonths, “October”));

            //Console.ReadKey();
            //------------------------------------------
            /*static int[] Sort(params int[] numbers) //If more than 1 parameter, your var-args parameter must be the last one listed.
{
    // The sorting logic:
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        // Loop operating over the unsorted part of the array
        for (int j = i + 1; j < numbers.Length; j++)
        {
            // Swapping the values
            if (numbers[i] > numbers[j])
            {
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }
        }
    } // End of the sorting logic
    return numbers;*/





    //---------------- Problem 2


     Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your birth month: ");
            string birthMonth = Console.ReadLine();
            nameMonth(birthMonth, firstName);                  
            Console.ReadKey();

            //-------------- Problem 3
            Console.WriteLine("Please write your first name: ");
            string myFirstName = Console.ReadLine();

            Console.WriteLine("Please write your last name: ");
            string myLastName = Console.ReadLine();
        }

        
        static void nameMonth (string birthMonth , string firstName) ////--------------------2nd Problem Method 
        {
            string userBirthMonth = "";
            switch (birthMonth.ToLower())
            {
                case "january":
                    userBirthMonth = " a January";
                    break;
                case "february":
                    userBirthMonth = " a February";
                    break;
                case "march":
                    userBirthMonth = " a March";
                    break;
                case "april":
                    userBirthMonth = " an April";
                    break;
                case "may":
                    userBirthMonth = " a May";
                    break;
                case "june":
                    userBirthMonth = " a June";
                    break;
                case "july":
                    userBirthMonth = " a July";
                    break;
                case "august":
                    userBirthMonth = " an August";
                    break;
                case "september":
                    userBirthMonth = " a September";
                    break;
                case "october":
                    userBirthMonth = " an October";
                    break;
                case "november":
                    userBirthMonth = " a November";
                    break;
                case "december":
                    userBirthMonth = " a December";
                    break;
                default:
                    Console.WriteLine("Wrong month ");
                    break;

            }


            //Console.WriteLine(birthMonth);
            Console.WriteLine(firstName + " is" + userBirthMonth + " baby");
            //---------------------Problem 3 

            //------------------------

        }

        static void FullName(string myFirstName, string myLastName)
        {

        }
    } 
}
