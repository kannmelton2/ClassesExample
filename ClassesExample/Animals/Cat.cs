using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Cat
    {
        // everything in a class has implicit accessibility modifiers
        // fields and properties are implicitly private
       
        public CatColor Color { get; set; }
        public bool isFeral { get; set; }
        public string FavoriteFood { get; set; }
        public Chicken BestFriend { get; set; }

        public void Dye(CatColor color)
        {
            Color = color;
        }

        public void HaveASnack()
        {
            Console.WriteLine($"The {Color} cat took a bite of {BestFriend.Name}. Oops!");
            BestFriend.Peck($"the {Color} cat");
        }

    }

    enum CatColor
    {
        Orange = 1,
        Gray,
        Black,
        Calico,
        White,
        Tabby,
        Blue
    }
}
