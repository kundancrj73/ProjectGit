using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
         static int Hello(string s)
        {
            int pcount = 0;
            int ccount = 0;
            int mcount = 0;
            int zcount = 0;
            int bcount = 0;
            int k = 0;
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'p')
                {
                    pcount++;
                }
                if (s[i] == 'c')
                {
                    ccount++;
                }
                if (s[i] == 'm')
                {
                    mcount++;
                }
                if (s[i] == 'z')
                {
                    zcount++;
                }
                if (s[i] == 'b')
                {
                    bcount++;
                }
            }
            int[] a = { pcount, ccount, mcount, zcount, bcount };
            for (int j = 1; j < a.Length; j++)
            {
                if (a[j - 1] < a[j])
                {
                    a[j] = a[j - 1];
                    k = a[j];
                }
                else
                {
                    k = a[j];
                }
            }
            return k;
        }
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            Console.WriteLine(Hello(s));
            Console.Read();
            
        }
    }
}
