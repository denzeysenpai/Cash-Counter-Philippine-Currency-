using System.Runtime.ConstrainedExecution;

namespace Deposit_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          * Write a program that can break down an amount of money (n) into bills and coins efficiently
          * 
          * 1000 peso bill
          * 500 peso bill
          * 200 peso bill
          * 100 peso bill
          * 50 peso bill
          * 20 peso bill
          * 10 peso coin
          * 5 peso coin
          * 1 peso coin
          * Centavos
          * ___________________________________________________________________________________________
          * 
          * using decimals
          * must output correct total amount
          * 
          * input an amount of money
          * 
          * ______________________________________________________method 1_____________________________
          * check if 
          * (n) >= 1000, 
          * (n) >= 500 && (n) < 1000, 
          * (n) >= 200 && (n) < 500, 
          * (n) >= 100 && (n) < 200, 
          * (n) >= 50 && (n) < 100, 
          * (n) >= 20 && (n) < 50, 
          * (n) >= 10 && (n) < 20, 
          * (n) >= 5 && (n) < 10, ...
          * ______________________________________________________method 2_____________________________
          * using modulus function
          * oneK = ((n-(n % 1000))/1000)
          */

            decimal numInput = 12.66M;
            decimal num1 = ((numInput - (numInput % 1000)) / 1000);
            decimal num2 = (((numInput % 1000) - ((numInput % 1000) % 500)) / 500);
            decimal num3 = ((((numInput % 1000) % 500) - (((numInput % 1000) % 500) % 200)) / 200);
            decimal num4 = (((numInput % 500) % 200) - (numInput % 500) % 100) / 100;
            decimal num5 = ((((numInput - (numInput % 50)) % 500) % 200) % 100) / 50;
            decimal num6 = (((((numInput % 1000) % 500) % 200) % 100) % 50) / 20;
            decimal num7 = (((numInput % 50) % 20) - ((numInput % 50) % 20) % 10) / 10;
            decimal num8 = (((numInput % 20) % 10) - ((numInput % 20) % 10) % 5) / 5;
            decimal num9 = ((numInput % 50) % 5);

            if (numInput >= 1000) { Console.WriteLine($"1000 peso bill: {Math.Round(num1)}"); }
            if (num2 >= 1) { Console.WriteLine($"500 peso bill: {Math.Round(num2)}"); }
            if (num3 >= 1) { Console.WriteLine($"200 peso bill: {Math.Round(num3)}"); }
            if (num4 >= 1) { Console.WriteLine($"100 peso bill: {Math.Round(num4)}"); }
            if (num5 >= 1) { Console.WriteLine($"50 peso bill: {Math.Round(num5)}"); }
            if (num6 >= 1) { Console.WriteLine($"20 peso bill: {Math.Round(num6)}"); }
            if (num7 >= 1) { Console.WriteLine($"10 peso coin: {Math.Round(num7)}"); }
            if (num8 >= 1) { Console.WriteLine($"5 peso coin: {Math.Round(num8)}"); }
            if (num9 >= 1) { Console.WriteLine($"1 peso coin: {Math.Round(num9)}"); }
            // How to get the centavos
            decimal first;
            decimal second;
            decimal last;
            if (Math.Round(numInput) > numInput)
            {
                first = Math.Round(numInput) - numInput;
                second = Math.Round(first,3);
                last = 1 - second;
            }
            else
            {       //0.36                   0
                first = numInput - Math.Round(numInput);
                second = Math.Round(first, 3);
                last = 1 - (1 - second);               
            }


            if (last == 0) { } else { Console.WriteLine($"Centavos: {Math.Round(last,3) * 100}"); }

            Console.ReadKey();
        }
    }
}