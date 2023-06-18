using c_sharp_Inheritance_tasks;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Student student1 = new Student("omran", 27, 14125555, "commEng");
        student1.printData();

        Console.WriteLine("===============================================");
    }
}