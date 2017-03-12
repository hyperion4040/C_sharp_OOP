using System;

namespace Polymorphism
{
    public sealed class PrincipalDeveloper : SeniorDeveloper//C# sealed is equal to final from Java
    {
        public override void d()
        {
            Console.WriteLine("Implements abstract method from abstract class");
            Console.WriteLine("From now on it is imposible to inheritage because of sealed class");
        }

    }
}