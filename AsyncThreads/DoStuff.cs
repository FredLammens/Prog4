using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncThreads
{
    class DoStuff
    {
        public async Task Working(string msg, int n) 
        {
            Console.WriteLine("Start working");
            for (int i = 0; i < n; i++)
            {
                await Task.Delay(100);
                Console.WriteLine($"working {msg},{i}");
            }
        }
    }
}
