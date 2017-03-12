using System;

namespace Polymorphism
{
    public class MidDeveloper : JuniorDeveloper
    {
        public new virtual void f()
        {
            Console.WriteLine("Mid Developer");
        }
    }
}