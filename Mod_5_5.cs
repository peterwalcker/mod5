using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5
{
    internal class Mod_5_5
    {
        private void Echo(string message, int depth)
        {
            var str = message;

            if (str.Length > 2)
            {
                str = str.Remove(0, 2);
            }
            else if (str.Length == 1)
            {
                str = "";
            }

            Console.BackgroundColor = (System.ConsoleColor)depth;
            Console.WriteLine(str);

            if (depth > 1)
            {
                Echo(str, depth - 1);
            }
        }
        private int Factorial(int x)
        {
            if(x == 0) return 1;
            else return x * Factorial(x - 1);
        }
        private int PowerUp(int N, byte pow)
        {
            int num = N;
            if (pow == 0)
            {
                return 1;
            }
            else if (pow == 1)
            {
                return num;
            }
            else
            {
                return num * PowerUp(num, --pow);
            }
        }
        public void Test()
        {
            Mod_5_5_8();
        }

        private void Mod_5_5_4()
        {
            Console.Write("Type something: ");
            string str = Console.ReadLine();
            Console.Write("Enter recursion depth: ");
            int depth = Convert.ToInt32(Console.ReadLine());
            Echo(str, depth);
        }

        private void Mod_5_5_8()
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter pow: ");
            byte pow = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Result is {PowerUp(num, pow)}");
        }
    }
}
