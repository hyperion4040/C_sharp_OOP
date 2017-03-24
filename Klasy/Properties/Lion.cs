using System;

namespace Klasy.Properties
{
    public class Lion
    {

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("zle");
                }
                else
                {
                    _age = value;
                }

            }
        }





        public Lion(int age)
        {
            if(age > 0)
            {
                Age = age;
            }
            else
            {
                Age = 1;
            }

        }
    }
}