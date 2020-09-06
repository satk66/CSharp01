using System;
using System.Threading;

namespace InterruptingThread
{
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                Console.WriteLine("Running thread isn't gonna be interrupted");
                Thread.SpinWait(10000000);
                while(count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Console.WriteLine("Entering into WaitJoinSleep State...");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e);

            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;
            Console.WriteLine("Starting thread");
            t1.Start();
            Thread.Sleep(100);
            Console.WriteLine("Interrupted thread...");
            t1.Interrupt();
            Console.WriteLine("Waiting until thread stops...");
            t1.Join();
            Console.WriteLine("Finished");
        }
    }
}
