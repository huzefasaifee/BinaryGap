using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 17651;
            int m = 0x01;
            //Console.WriteLine(N&m);

            //int N = 1;
            int len = 0, prev_len = 0;
            bool start = false;
            while (N > 0)
            {
                int r = N & 1;
                if (r == 1)
                {
                    if (start == false)
                    {
                        start = true;
                    }
                    else
                    {
                        if (len > prev_len)
                        {
                            prev_len = len;
                           
                        }
                        len = 0;
                    }
                }
                else
                {
                    if (start)
                    {
                        len++;
                    }
                }
                N = N >> 1;
            }
            if (prev_len > len)
            {
                Console.WriteLine(prev_len);
            }
            else
            {
                Console.WriteLine(len);
            }
        }
    }
}
