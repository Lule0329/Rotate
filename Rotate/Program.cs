using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rotate
            string[] rotateTestData = { "a", "b", "c", "d", "e" };
            Console.WriteLine("Demonstration av Rotate:");
            Console.WriteLine("Före: " + string.Join(",", rotateTestData));
            string[] rotateTestDataResult = Rotate(rotateTestData, 2);
            Console.WriteLine("Efter: " + string.Join(",", rotateTestDataResult));
        }

        public static string[] Rotate(string[] strings, int n)
        {
            string[] result = new string[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                if (i + n > strings.Length - 1)
                {
                    result[i] = strings[i % n];
                } 
                else if (i + n < strings.Length)
                {
                    result[i] = strings[i + n];
                }
            }

            return result;
        }
    }
}
