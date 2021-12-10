using System;

//Создайте собственное пространство имен MyNamespace с классом MyClass и подключите его в другом 
//приложении

using MyNamespace;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.PrintText();

            Console.ReadKey();
        }
    }
}
