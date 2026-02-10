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
            
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine($"ФИО: {name}");
                    break;
                case "2":
                    Console.WriteLine($"Группа: {group}");
                    break;
                case "3":
                    Console.WriteLine($"Текущая дата и время: {a}");
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("До свидания!");
                    break;
                default:
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                    break;
            }
        }
        
    }
}