using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncThreads
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            #region sync : Time elapsed: 00:00:25.0447534
            //DoStuffSync ds = new DoStuffSync();
            //ds.process(10, '1', true, false);
            //ds.process(10, '2', true, false);
            //ds.process(10, '3', true, false);
            //ds.process(10, '4', true, false);
            //ds.process(10, '5', true, false);
            #endregion
            #region Async : Time elapsed: 00:00:25.2598031
            //DoStuffAsync ds = new DoStuffAsync();
            //await ds.process(10, '1', true, false);
            //await ds.process(10, '2', true, false);
            //await ds.process(10, '3', true, false);
            //await ds.process(10, '4', true, false);
            //await ds.process(10, '5', true, false);
            #endregion
            #region parallel : Time elapsed: 00:00:05.1731011
            //DoStuffAsync ds = new DoStuffAsync();
            //List<Task> tasks = new List<Task>();
            //tasks.Add(ds.process(10, '1', true, false));
            //tasks.Add(ds.process(10, '2', true, false));
            //tasks.Add(ds.process(10, '3', true, false));
            //tasks.Add(ds.process(10, '4', true, false));
            //tasks.Add(ds.process(10, '5', true, false));
            //Task.WaitAll(tasks.ToArray());
            #endregion
            #region Threading : Time elapsed: 00:00:05.1429970
            //DoStuffAsync ds = new DoStuffAsync();
            //List<Task> tasks = new List<Task>();
            //tasks.Add(Task.Run(() => ds.process(10, '1', true, false)));
            //tasks.Add(Task.Run(() => ds.process(10, '2', true, false)));
            //tasks.Add(Task.Run(() => ds.process(10, '3', true, false)));
            //tasks.Add(Task.Run(() => ds.process(10, '4', true, false)));
            //tasks.Add(Task.Run(() => ds.process(10, '5', true, false)));
            //Task.WaitAll(tasks.ToArray());
            #endregion
            #region Async with return values
            //DoStuffAsync ds = new DoStuffAsync();
            //string msg = await ds.getMessage("Fré");
            //Console.WriteLine(msg);
            #endregion
            #region Async with return values2 : Time elapsed: 00:00:00.0924781
            DoStuffAsync ds = new DoStuffAsync();
            List<Task<string>> tasks = new List<Task<string>>();
            tasks.Add(ds.getIOutput("file1"));
            tasks.Add(ds.getIOutput("file2"));
            tasks.Add(ds.getIOutput("file3"));
            tasks.Add(ds.getIOutput("file4"));
            tasks.Add(ds.getIOutput("file5"));
            var res = await Task.WhenAll(tasks.ToArray());
            foreach (var x in res)
            {
                Console.WriteLine(x);
            }
            #endregion
            stopwatch.Stop();
            Console.WriteLine($"\n Time elapsed: {stopwatch.Elapsed}");
        }

    }
}
