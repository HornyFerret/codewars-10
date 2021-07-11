using System;
using System.Linq;

namespace codewars_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lst = new int[] { 1, 5, 6, 2, 3 };
            for (int i = 0; i < lst.Length; i++)
            {
                Console.WriteLine(lst[i]);
            }
            Console.WriteLine("------");
            int[] w = minMax(lst);
            for (int i = 0; i < w.Length; i++)
            {
                Console.WriteLine(w[i]);
            }
        }
        public static int[] minMax(int[] lst)
        {
            int n = lst.Min();
            int m = lst.Max();
            int[] f = new int [] { n, m };
            return f;
        }
    }
}
