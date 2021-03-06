﻿using System;

namespace Task_004
{
    class Program
    {
        static void Main(string[] args)
        {
            int userValue = default;
            int[] arr = new int[] { 2, 5, 3, 6, 9};
            SetUserValue(ref userValue);
            Console.WriteLine(
                isValuePositive(userValue) == true ? "Value is Positive" :
                isValueNEgative(userValue) == true ? "Value is Negative" :
                "Value is zero");

            Console.WriteLine(isValueSimple(userValue) == true ? "Value is Simple\n" : "Value is Composite\n");
            CheckDivision(userValue, arr);


            // Delay
            Console.ReadLine();

        }

        static void SetUserValue(ref int userValue)
        {
            bool isCorrect = false;

            while (!isCorrect)
            {
                Console.WriteLine("Type a number...");
                string userInput = Console.ReadLine();

                bool isConvertCorrect = int.TryParse(userInput, out userValue);
                if (isConvertCorrect)
                {
                    userValue = int.Parse(userInput);
                    isCorrect = true;
                }
                else Console.WriteLine("Input error, please try again ");
            }
        }
        static bool isValuePositive(int value)
        {
            return value > 0 ? true : false;
        }

        static bool isValueNEgative(int value)
        {
            return value < 0 ? true : false;
        }

        static bool isValueSimple(int value)
        {
            for (int i = 2; i <= Math.Sqrt(value); i++)
                if (value % i == 0)
                    return false;
            return true;
        }

        static void CheckDivision(int value, int[] values) 
        {
            foreach (var item in values) 
            {
                if (value % item == 0) 
                {
                    
                    Console.WriteLine($"Value {value} devides by {item} without residue");
                }
                else Console.WriteLine($"Число {value} делится на {item} with rest {value%item}");
            }
        }
    }
}
