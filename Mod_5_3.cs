using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5
{
    internal class Mod_5_3
    {
        private int[] GetArrayFromConsole(ref int num)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
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
        private void GetName(out string name, out string oldname)
        {
            oldname = "Евгения";
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }
        public void Test()
        {
            Mod_5_3_13();
        }
        
        private void Mod_5_3_8()
        {
            int num = 6;
            var arr = GetArrayFromConsole(ref num);
        }

        private void Mod_5_3_13()
        {
            var array = GetArrayFromConsole();
            SortArray(array, out int[] sortedAsc, out int[] sortedDesc);

        }
        private void SortArray(int[] array, out int[] sortedAsc, out int[] sortedDesc)
        {
            sortedAsc = new int[array.Length];
            sortedDesc = new int[array.Length];
            SortArrayAsc(array);
            Array.Copy(array, 0, sortedAsc, 0, array.Length);
            SortArrayDesc(array);
            Array.Copy(array, 0, sortedDesc, 0, array.Length);
        }
        private void SortArrayAsc(int[] array)
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
        private void SortArrayDesc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }
    }
}
