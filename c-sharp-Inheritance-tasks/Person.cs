using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace c_sharp_Inheritance_tasks
{
    /*
    Task 1:
Create a base class called Person with the following properties:
string Name: Represents the name of the person.
int Age: Represents the age of the person.
Create a derived class called Student that inherits from the Person class.
    Add the following additional properties to the Student class:
int StudentId: Represents the student ID.
string Major: Represents the major of the student.
Create constructors for both classes to initialize the properties. 
    Ensure that the constructors of the derived class call the constructor
    of the base class to initialize the inherited properties.
*/
    internal class Person
    {

       public string Name;
       public int Age;

        public Person(string Name,int Age) 
        {
         this.Name = Name;
         this.Age = Age;
        }



    }
}
