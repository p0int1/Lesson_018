using System;
//Используя пример выполненного домашнего задания 3 из 15 урока, реализуйте возможность 
//подключения вашего пространства имен и работы с MyDictionary<TKey, TValue> аналогично 
//экземпляру класса Dictionary<TKey, TValue>

using Dictionary; //Подключение пространства имен Dictionary который содержит класс MyDictionary

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<char, string> dictionary = new MyDictionary<char, string>(); //Создание экземпляра класса MyDictionary
            dictionary.Add('a', "Эй"); //Добавление значений в словарь
            dictionary.Add('b', "Би");
            dictionary.Add('c', "Си");
            dictionary.Add('d', "Ди");

            Console.WriteLine(dictionary['b']); //Отображение результата поиска в словаре с помощью индексатора

            foreach (string pair in dictionary)
                Console.WriteLine(pair); //Отображение содержимого словаря

            Console.ReadKey();
        }
    }
}
