﻿using c_sharp_Inheritance_tasks;
using System.Drawing;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student1 = new Student("omran", 27, 14125555, "commEng");
        student1.printData();

        Console.WriteLine("===============================================");

        Rectangle1 rectangle = new Rectangle1("red", 0, 2.4, 2.5);

        Console.WriteLine("===============================================");

        Dog dog1 = new Dog("jack",2,"breed","wof");
        Dog dog2 = new Dog("jacky", 2, "breed", "wof");
        dog1.makeSound();
        dog1.getSound();

        Console.WriteLine(dog1.Equals(dog2));
    }
}