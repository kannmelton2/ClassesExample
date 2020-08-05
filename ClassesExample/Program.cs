using ClassesExample.Animals;
using System;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken = new Chicken("Liza");
            chicken.Peck("corn");
            chicken.Peck("grain");

            var bob = new Chicken("Bob");
            bob.Peck("watermelon");

            var llama = new Llama("brown", 3);
            llama.Dye("blue");

            var cat = new Cat();
            cat.Color = CatColor.Blue;
            cat.BestFriend = bob;

            cat.HaveASnack();

            Console.WriteLine($"The cat is {cat.Color}.");
        }
    }
}
