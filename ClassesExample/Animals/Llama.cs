using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Llama
    {
        // properties
        // auto-property
        // old and busted way is way longer, but allows for some control
        public int Age { get; set; }
        // read-only prop - set only in the constructor
        //public string Color { get; }
        public bool Spits { get; set; }

        // public property with private setter
        public string Color { get; private set; }

        // constructor
        public Llama(string color, int age)
        {
            Age = age;
            Color = color;
        }

        // methods
        public void Dye(string color)
        {
            if (Age > 3)
            {
                Color = color;
            }
            else
            {
                DressUp("pajamas", "giraffe");
            }
        }

        public void DressUp(string clothing, string style)
        {
            Console.WriteLine($"The {Color} llama is wearing {style} {clothing}");
        }

        // OLD & BUSTED way of declaring properties
        //private int _age;
        //public int Age
        //{
        //    get
        //    {
        //        return _age;
        //    }
        //    set
        //    {
        //        if (value > 100)
        //        {
        //            _age = 100;
        //        }
        //        else
        //        {
        //            _age = value;
        //        }
        //    }
        //}

            }
}
