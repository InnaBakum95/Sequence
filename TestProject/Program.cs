using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            GetPart(min, max);

        }

        private static void GetPart(int min, int max)
        {
            List<double> numbers = new List<double>() {1,1,1};

            for (int i = 0; i <= max; i++)
            {
                int j = i;
                numbers.Add(numbers[j] + numbers[j + 1] + numbers[j + 2]);
            }
            Console.Write(ReturnNumbers(min, max, numbers));
            Console.ReadKey();
        }
        private static string ReturnNumbers(int min, int max, List<double> numb)
        {
            List<double> numbersRet = new List<double>();
            for (int i = min - 1; i < max; i++)
            {
                numbersRet.Add(numb[i]);
            }
            return "["+ string.Join("; ", numbersRet) + "]";
        }
    }
}
