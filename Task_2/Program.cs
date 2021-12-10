using System;
using Dll;
//Создайте класс с методом помеченным модификатором доступа public. Докажите, что к данному 
//методу можно обратиться не только из текущей сборки, но и из производного класса внешней сборки.

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassDll.MyMethod();
            Console.ReadKey();
        }
    }
}
