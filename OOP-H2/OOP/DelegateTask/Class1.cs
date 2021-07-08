using System;

namespace DelegateTask
{
    public delegate void Del(string message);
    public class Class1
    {
        Del handler = DelegateMethod;
        handler("Hello World");
    }

    public void DelegateMethod(string message)
    {
        Console.WriteLine(message);
    }
}
