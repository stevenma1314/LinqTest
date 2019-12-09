using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fakedata = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            //GetOdd(fakedata);
            getoddbyfoloop(fakedata);

        }

        

        public static void GetOdd(int[] datapool)
        {
            var test = datapool.Where(o => o % 2 == 1);

            foreach (var t in test)
            {
                Console.WriteLine(t);
            }

            var test1 = datapool.Where(o => o % 2 == 0);

            foreach (var t in test1)
            {
                Console.WriteLine(t);
            }
            Console.ReadLine();
        
        }

        public static void getoddbyfoloop( int[] datapool)
        {
            int len = datapool.Length;
            var even = new List<int>();
            var odd = new List<int>();
            for (int i = 0; i < len; i++)
            {

                if (datapool[i] % 2 == 1)
                {
                    odd.Add(datapool[i]);
                }
                else
                {
                    even.Add(datapool[i]);
                }

            };
            Console.WriteLine("the oadd number are:");

            odd.ForEach(Console.WriteLine);
            Console.WriteLine("the even number are:");
            even.ForEach(Console.WriteLine);
            Console.ReadLine();

        }

    }
}
