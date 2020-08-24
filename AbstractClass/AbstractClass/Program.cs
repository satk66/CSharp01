using System;

namespace AbstractClass
{
    abstract class AbstractBase
        {
    protected void PrivateMethoda()
    {
        Console.WriteLine("AbstravtBase.PrivateMethoda()");
    }
        public void PrivateMethoda()
    {
       Console.WriteLine("AbstravtBase.PrivateMethoda()");
    }
        public abstract void AbstractMethodA();
   }
class Derived : AbstractBase
{
    // public void PrivateMethodA()
    // {
    //    Console.WriteLine(" PrivateMethodA()")
    //}

        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethoda();
        }
    }
class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PrivateMethoda();
        }
    }
}
