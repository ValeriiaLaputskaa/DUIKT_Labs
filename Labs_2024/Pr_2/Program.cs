using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pr_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SecondTask();
            //ThirdTask();
            // FourthTask();

            Console.Write("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your serial number: ");
            int serialNumber = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine(" ");
            Console.WriteLine("Numbers that fit the given interval: ");



            FirstTask(firstNumber, secondNumber, thirdNumber, serialNumber);
            //SecondTask();
            //ThirdTask();
            //FourthTask();
        }


        static void FirstTask(int firstNumber, int secondNumber, int thirdNumber, int serialNumber)
        {
            int lastNumber = 10 + serialNumber;

            if (firstNumber == 0 && secondNumber == 0 && thirdNumber == 0)
            {
                Console.WriteLine("Try again! Enter number greater than 0!");
            }

            if (firstNumber >= 1 && firstNumber <= lastNumber)
            {
                Console.WriteLine(firstNumber);
            }

            if (secondNumber >= 1 && secondNumber <= lastNumber)
            {
                Console.WriteLine(secondNumber);
            }

            if (thirdNumber >= 1 && thirdNumber <= lastNumber)
            {
                Console.WriteLine(thirdNumber);
            }
        }






        static void SecondTask()
        {

            /*Написати програму. Дано три сторони трикутника. Обчислити периметр та площу трикутника.
             Визначити вид трикутника за сторонами. (потрібно робити перевірку на дійсність
             трикутника та на коректність введених даних).*/

            /*півпериметр за формулою р=(а+в+с)/2*/

            Console.WriteLine("Enter first side: ");
            double firstSide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second side: ");
            double secondSide = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third side: ");
            double thirdSide = Convert.ToDouble(Console.ReadLine());

            double P = (firstSide + secondSide + thirdSide);
            double semiPerimeter = ((firstSide + secondSide + thirdSide) / 2);
            double S = Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) *
                                 (semiPerimeter - thirdSide));

            if (firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide &&
                secondSide + thirdSide > firstSide)
            {
                Console.WriteLine("P: " + P);
                Console.WriteLine("S: " + S);

                if (firstSide == secondSide && secondSide == thirdSide)
                {
                    Console.WriteLine("Equilateral triangle (all sides are equal)"); //рівносторонній
                }
                else if (firstSide == secondSide || secondSide == thirdSide || thirdSide == firstSide)
                {
                    Console.WriteLine("Isosceles triangle (two sides are equal)"); //рівнобедрений
                }
                else
                {
                    Console.WriteLine("A versatile triangle."); //різносторонній
                }

            }
            else
            {
                Console.WriteLine("Try again! ");
            }

        }

        static void ThirdTask()
        {


            /*Написати програму. Дано масив Х довжиною 10+№  (де №-остання цифра студента у списку групи).
             Знайти мінімальне та максимальне значення. Вивести на екран масив та самі значення.  */

            Console.Write("Enter your serial number: ");
            int serialNumber1 = Convert.ToInt32(Console.ReadLine());

            int lastNumber1 = 10 + serialNumber1;

            int[] X = new int[lastNumber1];
            Random random = new Random();
            for (int i = 0; i < X.Length; i++)
            {
                X[i] = random.Next(1, lastNumber1);
            }

            Console.WriteLine("Array: ");
            foreach (int i in X)
            {
                Console.Write(i + " ");
            }

            int max = X[0];
            int min = X[0];
            for (int i = 1; i < X.Length; i++)
            {
                max = Math.Max(max, X[i]);
                min = Math.Min(min, X[i]);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
        }




        static void FourthTask()
        {
            /*Написати програму. З масиву Х довжиною 10+№  (де №-остання цифра студента у списку групи), серед елементів якого є позитивні
             та негативні та нуль, сформуйте новий масив Y, узявши тільки елементи з Х які більше по модулю заданого числа М.
            Виведіть на екран число М та масиви заданий та отриманий.*/

            Console.Write("Enter your serial number: ");
            int serialNumber1 = Convert.ToInt32(Console.ReadLine());
            int lastNumber1 = 10 + serialNumber1;

            int[] X = new int[lastNumber1];
            Random random = new Random();

            for (int i = 0; i < X.Length; i++)
            {
                X[i] = random.Next(-50, lastNumber1);
            }

            Console.Write("Enter number M: ");
            int M = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            foreach (int num in X)
            {
                if (Math.Abs(num) > M)
                {
                    count++;
                }
            }

            int[] Y = new int[count];
            int y = 0;

            foreach (int num in X)
            {
                if (Math.Abs(num) > M)
                {
                    Y[y] = num;
                    y++;
                }
            }

            Console.WriteLine("M: " + M);

            Console.WriteLine("Array X:");

            foreach (int i in X)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Array Y:");
            foreach (int i in Y)
            {
                Console.Write(i + " ");
            }
        }

    }
}


