using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blabla
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[10];
            InputInt(Arr);
            Console.ReadLine();
        }
        public static void InputInt(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                string str = Console.ReadLine();
                Arr[i] = int.Parse(str);
            }
        }

        public static bool IsContain5(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5) return true;
            }
            return false;
        }

        public static bool IsContain5or6(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5 || Arr[i] == 6) return true;
            }
            return false;
        }

        public static bool IsContain5And6(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5 && Arr[i] == 6) return true;
            }
            return false;
        }

    }
}
