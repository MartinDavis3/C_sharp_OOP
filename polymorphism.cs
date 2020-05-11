using System;

namespace polymorphism
{

    class Program
    {
        class Animal {
            public virtual void sound() {
                Console.WriteLine("[Insert Animal Sound]");
            }
        }
        class Pig : Animal {
            public override void sound() {
                Console.WriteLine("Oink!");
            }
        }
        class Duck : Animal {
            public override void sound() {
                Console.WriteLine("Quack!");
            }
        }

        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Pig myPig = new Pig();
            Duck myDuck = new Duck();

            myAnimal.sound();
            myPig.sound();
            myDuck.sound();

        }
    }
}
