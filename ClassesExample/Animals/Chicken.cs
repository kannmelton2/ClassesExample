using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Chicken
    {
        // property
        public string Name { get; set; }

        // field 
        private bool _isHungry = true;
        
        // constructor
        public Chicken(string name)
        {
            Name = name;
        }

        // the below is a method - it is public, so other files can call it, it doesn't return anything, it is called Peck and it takes a single parameter of a string called typeOfFood
        // method signature:
        // accessibility modifier -> return type -> Name -> parameters -> statements
        public void Peck(string typeOfFood)
        {
            if (_isHungry)
            {
                Console.WriteLine($"{Name} pecks at the {typeOfFood}.");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry.");
            }
        }

        // default constructor, only returns an instance of the class
        // looks like this: public Chicken() { }
        // its function is hidden from us, doesn't seem to do anything
        // identifier/name of the constructor must match the name of the class
        // job of the constructor is to set up all the default values
    }
}
