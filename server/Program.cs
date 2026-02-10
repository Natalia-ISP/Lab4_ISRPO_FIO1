using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Здравствуйте!");
        string name = "Пономарева Наталья Андреевна";
        string group = "ИСП-232";
        DateTime a = DateTime.Now;

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1 — Показать ФИО");
            Console.WriteLine("2 — Показать группу");
            Console.WriteLine("3 — Показать дату");
            Console.WriteLine("4 — Выход");
            Console.Write("Введите номер пункта: ");
        }
        
    }
}