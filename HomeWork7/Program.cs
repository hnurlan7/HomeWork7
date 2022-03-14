using System;
using HomeWork7.Models;

namespace HomeWork7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = GetInputInt("Ne qeder kitab daxil olunacaq?", 0);
            Book[] books = new Book[length];

            for (int i = 0; i < length; i++)
            {
                int no = GetInputInt("No daxil edin: ", 0);
                string name = GetInputString("Name daxil edin: ", 2, 100);
                double price = GetInputDouble("Price daxiledin: ", 0);
                int count = GetInputInt("Count daxil edin: ", 0);
                string genre = GetInputString("Genre daxil edin: ", 0, 100);


                books[i] = new Book(genre, no, name, price)
                {
                    count = count
                };
            }
            foreach (Book book in books)
            {
                Console.WriteLine(book.GetInfo());

                Console.WriteLine("\n1. Kitablari qiymete gore filterle \n2. Butun kitablari goster \n0. Proqrami bagla");
                int menu = GetInputInt("Davam etmek ucun birini secin: ", 0, 2);

                if (menu == 1)
                {
                    double minPrice = GetInputDouble("Min qiymet qeyd edin: ", 0);
                    double maxPrice = GetInputDouble("Max qiymet qeyd edin: ", minPrice);
                    if (price)
                    {

                    }
                    
                }
            }

            


            static string GetInputString(string name, int min, int max = int.MaxValue)
            {
                string input;
                do
                {
                    Console.WriteLine(name);
                    input = Console.ReadLine();
                } while (input.Length < min || input.Length > max);
                return input;
            }
            static int GetInputInt(string name, int min, int max = int.MaxValue)
            {
                int input;
                do
                {
                    Console.WriteLine(name);
                    input = Convert.ToInt32(Console.ReadLine());
                } while (input < min || input > max);
                return input;
            }
            static double GetInputDouble(string name, double min, double max = double.MaxValue)
            {
                double input;
                do
                {
                    Console.WriteLine(name);
                    input = Convert.ToInt32(Console.ReadLine());
                } while (input < min || input > max);
                return input;
            }
        }
    }
}
