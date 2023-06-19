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
    internal abstract class Animal
    {
        string name;
        int age;

        public Animal(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

        public abstract void makeSound();

        public virtual void getSound()
        {
            Console.WriteLine("this is base class");
        }
    }

    sealed class wildAnimal 
    { 
        public string name;
        public int age;

        public wildAnimal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
