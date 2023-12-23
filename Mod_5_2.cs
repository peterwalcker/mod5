using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5
{
    internal class Mod_5_2
    {
        public void Test()
        {
            Mod_5_2_18();
        }

        private void Mod_5_2_3()
        {
            (string name, int age) = ("Vlad", 33);
            Console.WriteLine($"My name is {name} and my age is {age}");

            Console.WriteLine("Insert your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Insert your age in numbers: ");
            age = Convert.ToInt32(Console.ReadLine());

            //Mod_5_2_3
            //Console.WriteLine($"Your name is {name} and your age is {age}");
            //Mod_5_2_3

            //Mod_5_2_7
            Console.WriteLine($"Your name is {name} and your age is {age}{Environment.NewLine}Please, enter your favorite colors:");
            //Mod_5_2_7

            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name);
            }
            
            Console.WriteLine();
            Console.WriteLine("Your favorite colors is:");
            foreach (string favcolor in favcolors)
            {
                Console.WriteLine(favcolor);
            }

            Console.ReadKey();
        }
        private string ShowColor(string name)
        {
            Console.WriteLine($"{name}, enter your favorite color:");
            string color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan");
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return color;
        }

        private void Mod_5_2_8()
        {
            var arr = GetArrayFromConsole();
            SortArray(arr);
        }
        private int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        private void SortArray(int[] array, int num = 5)
        {
            for (int i = 0; i < /*array.Length this is Mod_5_2_8 code*/ num; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }

        private void Mod_5_2_15()
        {
            var arr = GetArrayFromConsole();
            SortArray(arr);
            int[] sortedarray = new int[arr.Length];
            Array.Copy(arr, 0, sortedarray, 0, arr.Length);
        }

        private void ShowArray(int[] array, bool IsSort = false)
        {
            if (!IsSort)
            {
                SortArray(array, array.Length);
            }
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
        }

        private void Mod_5_2_18()
        {
            var arr = GetArrayFromConsole(10);
            ShowArray(arr, true);
        }
    }
}
