using System;

namespace GreaterOfTwoValues
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    string typeofValue = Console.ReadLine();
        //    switch(typeofValue)
        //    {
        //        case "int":
        //            int firstNum = int.Parse(Console.ReadLine());
        //            int secondNum = int.Parse(Console.ReadLine());
        //            int greaterValueInt = GetMaxInt(firstNum, secondNum);
        //            Console.WriteLine(greaterValueInt);
        //            break;
        //        case "char":
        //            char firstChar = char.Parse(Console.ReadLine());
        //            char secondChar = char.Parse(Console.ReadLine());
        //            char greaterValueChar = GetMaxChar(firstChar, secondChar);
        //            Console.WriteLine(greaterValueChar);
        //            break;
        //        case "string":
        //            string firstStr = Console.ReadLine();
        //            string secondStr = Console.ReadLine();
        //            string greaterValueString = GetMaxString(firstStr, secondStr);
        //            Console.WriteLine(greaterValueString);
        //            break;
        //    }
        //}
        //static int GetMaxInt(int firstNum, int secondNum)
        //{
        //    if(firstNum > secondNum)
        //    {
        //        return firstNum;
        //    }
        //    else
        //    {
        //        return secondNum;
        //    }
        //}
        //static char GetMaxChar(char firstChar, char secondChar)
        //{
        //    if(firstChar > secondChar)
        //    {
        //        return firstChar;
        //    }
        //    else
        //    {
        //        return secondChar;
        //    }
        //}
        //static string GetMaxString(string firstStr, string secondStr)
        //{
        //    if(firstStr.Length > secondStr.Length)
        //    {
        //        return firstStr;
        //    }
        //    else
        //    {
        //        return secondStr;
        //    }
        //}
            static void Main(string[] args)
            {
                string command = Console.ReadLine();
                if (command == "int")
                {
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    HigherThenTwo(first, second);
                }
                else if (command == "char")
                {
                    char first = char.Parse(Console.ReadLine());
                    char second = char.Parse(Console.ReadLine());
                    HigherThenTwo(first, second);
                }
                else if (command == "string")
                {
                    string first = Console.ReadLine();
                    string second = Console.ReadLine();
                    HigherThenTwo(first, second);
                }

            }

            static int HigherThenTwo(int first, int second)
            {

                int result = 0;
                if (first > second)
                {
                    result = first;
                }
                else
                {
                    result = second;
                }
                Console.WriteLine(result);
                return result;
            }
            static char HigherThenTwo(char first, char second)
            {

                int result;
                if (first > second)
                {
                    result = first;
                }
                else
                {
                    result = second;
                }
                Console.WriteLine((char)result);
                return (char)result;

            }
            static string HigherThenTwo(string first, string second)
            {
                string result = string.Empty;
                int comparison = first.CompareTo(second);
                if (comparison > 0)
                {
                    result = first;
                }
                else
                {
                    result = second;
                }
                Console.WriteLine(result);
                return result;


            }

        }
    }


