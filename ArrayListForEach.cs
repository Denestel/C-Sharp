using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that ask for user input to populate an array for ints
            // then the program will traverse the array and pick out all even numbers in the array
            //and populate a new array **try using arraylist*

            int arraySize;
            int popNum;

            //we will create 2 arraylist, one for the original array and the other for the even numbers
            ArrayList userNums = new ArrayList();
            ArrayList popArray = new ArrayList();

            //we must get the size of the array from the user
            Console.WriteLine("How large is your array?");
            arraySize = Convert.ToInt32(Console.ReadLine());

            //we use a for loop to populate the array with user input untill we have filled the array
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("What is the value of number {0}:", i+1);
                popNum = Convert.ToInt32(Console.ReadLine());
                userNums.Add(popNum);
            }

            //we use for each to check each number in the original array to see if it is even, if it is we want to add it to the new array
            foreach (int num in userNums)
            {
                if (num % 2 == 0)
                {
                    popArray.Add(num);
                }
            }

            //we print out all the numbers in the new array
            foreach(int num in popArray)
            {
                Console.WriteLine("{0} is an even number in your array", num);
            }

        }
    }
}
