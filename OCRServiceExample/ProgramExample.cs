using System;
using OCRServiceLib;

class ProgramExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Mono!");
        var myClass = new Class1();
        string message = myClass.GetMessage();
        Console.WriteLine(message);
    }
}