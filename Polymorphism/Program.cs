using System;
using System.Collections.Generic;
using ConsoleApplication;

namespace Polymorphism
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Developer dev = new Developer();
            dev.f();
            dev = new JuniorDeveloper();
            dev.f();
            dev = new MidDeveloper();
            dev.f();
            dev = new SeniorDeveloper();
            dev.f();
        }
    }
}