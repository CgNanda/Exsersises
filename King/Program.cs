using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace King
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char s = Console.ReadLine()[0];
            int dashes = n / 2;
            int innerS = 1;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}",new string('-',dashes),new string(s,innerS));
                innerS += 2;
                dashes--;
            }

           // Console.WriteLine("{0}",new string(s,n));

            for (int i = 0; i <= n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string(s, innerS));
                innerS -= 2;
                dashes++;
            }
            
            
        }
           
        }
    }

