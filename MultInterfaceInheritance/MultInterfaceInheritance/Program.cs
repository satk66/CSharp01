using System;

namespace MultInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }

    class FlyingCat : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Run! Run!");
        }

        public void Run()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FlyingCat car = new FlyingCat();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();

        }
    }
}
