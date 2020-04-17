using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncThreads
{
    class DoStuffAsync
    {
        private async Task simulateCPUOperation(char token)
        {
            Console.WriteLine($"(cpu{token}-start)");
            for (int i = 0; i < 1000000; i++)
            {
                Math.Sqrt(Math.Cos(i) + Math.Sin(i));
            }
            Console.WriteLine($"(cpu{token}-stop)");
        }
        private async Task simulateIOOperation(char token)
        {
            Console.WriteLine($"(cpu{token}-start)");
            await Task.Delay(500);
            Console.WriteLine($"(cpu{token}-stop)");
        }
        public async Task process(int n, char token, bool IO, bool CPU)
        {
            for (int i = 0; i < n; i++)
            {
                if (CPU) await simulateCPUOperation(token); // if you remove await keyword goes way faster :p
                if (IO) await simulateIOOperation(token);
                Console.Write(token);
            }
        }
        public async Task<string> getMessage(string who) 
        {
            return $"async message from {who}";
        }
        public async Task<string> getIOutput(string fakeFileName) 
        {
            Console.WriteLine($"start {fakeFileName}");
            await Task.Delay(10);
            for (int i = 0; i < 100000; i++)
            {
                Math.Cos(i); //fake action
            }
            Console.WriteLine($"stop {fakeFileName}");
            return $"results from {fakeFileName}";
        }
    }
}
