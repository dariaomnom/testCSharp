using System;
using MyMonoProject;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Mono!");
        var myClass = new MyClass();
        string message = myClass.GetMessage();
        Console.WriteLine(message);
    }
}