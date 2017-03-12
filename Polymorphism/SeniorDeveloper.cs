using System;

namespace Polymorphism
{
    public abstract class SeniorDeveloper : MidDeveloper
    {
        public override void f()
        {
            Console.WriteLine("Senior Developer");
        }

        public abstract void d();
    }
}