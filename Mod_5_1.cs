using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5
{
    internal class Mod_5_1
    {
        public void Test()
        {
            Mod_5_1_6();
        }

        internal void Mod_5_1_Legacy()
        {
            (string Name, string[] Dishes) User;

            Console.Write("Enter name: ");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];

            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.Write($"Enter dish #{i + 1}:");
                User.Dishes[i] = Console.ReadLine();
            }

            Console.ReadLine();
        }

        internal void Mod_5_1_5()
        {
            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }
            Console.WriteLine();
            Console.WriteLine("Your favorite colors is:");
            foreach (string favcolor in favcolors)
            {
                Console.WriteLine(favcolor);
            }
        }
        private string ShowColor()
        {
            Console.WriteLine("Enter your favorite color:");
            return Console.ReadLine();
        }

        internal void Mod_5_1_6()
        {
            int[] array = GetArrayFromConsole();
            SortArray(array);
            ShowArray(array);
        }
        private int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        private void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
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
        private void ShowArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
