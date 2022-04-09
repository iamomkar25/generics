﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3 };
            double[] doubleArr = { 10.12, 20.16, 30.68, 56.22 };
            char[] charArr = { 'O', 'M', 'K', 'A', 'R', 'S' };
            Console.WriteLine("1:PrintArray without generic method\n" +
                "2:PrintArray with method\n" +
                "3:GenericClass Concept\n" +
                "4:FindMaximum Value\n float");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)

            {
                case 1:
                    Console.WriteLine("Without generic method");
                    PrintArray.PrintAnArray(intArr);
                    PrintArray.PrintAnArray(doubleArr);
                    PrintArray.PrintAnArray(charArr);
                    break;
                case 2:
                    Console.ReadLine();
                    Console.WriteLine("With generic method");
                    GenericPrintArray.PrintAnArray<int>(intArr);
                    GenericPrintArray.PrintAnArray<double>(doubleArr);
                    GenericPrintArray.PrintAnArray<char>(charArr);
                    break;
                case 3:
                    Console.WriteLine("\n Generic Class");
                    GenericClass<int> intObj = new GenericClass<int>(intArr);//create object
                    intObj.PrintAnArray();
                    GenericClass<double> doubleObj = new GenericClass<double>(doubleArr);
                    doubleObj.PrintAnArray();
                    GenericClass<char> charObj = new GenericClass<char>(charArr);
                    charObj.PrintAnArray();
                    break;
                case 4:
                    int x = 34, y = 23, z = 12;
                    Console.WriteLine("Max value{0} out of {1},{2},{3}", FindMaximum.FindMax(x, y, z), x, y, z);
                    float a = 12.34f, b = 23.34f, c = 12.45f;
                    Console.WriteLine("Max value{0} out of {1},{2},{3}", FindMaximum.FindMax(a, b, c), a, b, c);
                    break;
                case5:

                    break;

            }




            Console.ReadLine();

        }
    }
}
