using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 3");
            //f1();            
            //f2();
            f3();
        }
        static void f1()
        {
            int[,] array = { { 1, 2, 4, 6 }, 
                             { 3, 4, 7, 10 } };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Input number: ");
            int number = int.Parse(Console.ReadLine());
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == number)
                    {
                        index1 = i;
                        index2 = j;
                    }
                }
            }
            Console.WriteLine("Number is in [" + index1 + "][" + index2 + "]cell");
            Console.ReadLine();
        }
        static void f2()
        {
            int[][] array = new int[2][];
            array[0] = new[] { 17, 18, 19} ;
            array[1] = new[] { 22,3,6,9,7};

            Console.Write("Input number: ");
            int number = int.Parse(Console.ReadLine());
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]+ " ");
                    if (array[i][j] == number)
                    {
                        index1 = i;
                        index2 = j;
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Number is in [" + index1 + "][" + index2 + "]cell");
            Console.Read();
        }
        static void f3()
        {
            City[] cities = new City[]
                {
                    new City () { name = "wsefwef", population = 65465, square = 56465465},
                    new City () { name = "ASDFADF", population = 234, square = 234},
                    new City () { name = "ykghjk", population = 8965, square = 5555433},
                };
            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i].name == "wsefwef")
                    Console.WriteLine(cities[i].population);
            }
            Phone[] phones = new Phone[]
                {
                    new Phone() {brand = "Apple", model = "IPhone", color = "black", size = 4.7  },
                    new Phone() {brand = "Samsung", model = "galaxy", color = "white", size = 5.5  },
                    new Phone() {brand = "Sony", model = "Xperia", color = "red", size = 5.0  }
                };
            for (int i = 0; i < phones.Length; i++)
            {
                if (phones[i].model == "IPhone")
                    Console.WriteLine(phones[i].color);
            }
            Console.ReadLine();
        }
        struct City
        {
            public string name;
            public int population;
            public double square;
        }
        struct Phone
        {
            public string brand;
            public string model;
            public double size;
            public string color;
        }
    }
}
