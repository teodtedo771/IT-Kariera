﻿using System;

namespace Exercises
{
    class SetUp
    {
        static void Main()
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
