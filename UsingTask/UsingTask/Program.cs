using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string srcFile = args[0];
            Action<object> FileCopyAction = (object state) =>
            {
                String[] paths = (string[])state;
                File.Copy(paths[0], paths[1]);
                Console.WriteLine("TaskID:{0},TaskID:{1},{2} was copied to {3}",
                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
            };
            Task t1 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });
            Task t2 = Task.Run(() =>
            {
                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
            });

            t1.Start();//비동기 실행
            Task t3 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy2" });
            t3.RunSynchronously(); //동기실행

            t1.Wait();
            t2.Wait();
            t3.Wait();
        }
    }
}
