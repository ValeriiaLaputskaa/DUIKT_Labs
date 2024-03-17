using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Pr_3.Pr_3_task1;
using Pr_3.Pr_3_task2;

namespace Pr_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1 

             Book book = new Book();

             book.Show();

             book.AuthorOfBook = "New Author's Name";
             book.ContentOfBook = "New text of the book";

             book.Show();

             


            //Task2
            /*
            Console.Write("Enter the number of points (3 to 5): ");
            int numberOfPoints = int.Parse(Console.ReadLine());

            if (numberOfPoints < 3 || numberOfPoints > 5)
            {
                Console.WriteLine("Try again! The shape should have 3 to 5 points!");
                return; 
            }



            Point[] points = new Point[numberOfPoints];


            for (int i = 0; i < numberOfPoints; i++)
            {
                Console.Write($"Enter X coordinate for point {i + 1}: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write($"Enter Y coordinate for point {i + 1}: ");
                int y = int.Parse(Console.ReadLine());

                Console.Write($"Enter name for point {i + 1}: ");
                string name = Console.ReadLine();

                points[i] = new Point(x, y, name);
            }

            Figure figure;

            switch (numberOfPoints)
            {
                case 3:
                    figure = new Figure(points[0], points[1], points[2], "ABC");
                    break;
                case 4:
                    figure = new Figure(points[0], points[1], points[2], points[3], "ABCD");
                    break;
                case 5:
                    figure = new Figure(points[0], points[1], points[2], points[3], points[4], "ABCDE");
                    break;
                default:
                    Console.WriteLine("Please enter number between 3 and 5.");
                    return;
            }

            figure.PerimeterCalculator();*/
        }
   
     }

}
