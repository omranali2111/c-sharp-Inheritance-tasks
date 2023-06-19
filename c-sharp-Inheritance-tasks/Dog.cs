using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c_sharp_Inheritance_tasks
{
    /*
    Task 5:
Create a base class called Animal with the following properties:
string Name: Represents the name of the animal.
int Age: Represents the age of the animal.
Create a derived class called Dog that inherits from the Animal class. 
Add the following additional properties to the Dog class:
string Breed: Represents the breed of the dog.
string Sound: Represents the sound the dog makes.
    */
    internal class Dog : Animal
    {
        string Breed;
        string Sound;

        public Dog(string name, int age,string Breed, string Sound) : base( name,  age)
        {
            this.Breed = Breed;
            this.Sound = Sound;
        }

        public override void makeSound()
        {
            Console.WriteLine("dog sound:wof wof");
        }

        public override void getSound()
        {
            Console.WriteLine("this is derived class getSound()");
        }
        public  void doSomething()
        {
            Console.WriteLine("this is derived class");
        }

    }
}
