using System;

namespace PracticalWork1
{
    // Класс Квитанция
    class Receipt
    {
        public int Number;
        public string Date;
        public float Amount;

        // Конструктор с параметрами
        public Receipt(int number, string date, float amount)
        {
            Number = number;
            Date = date;
            Amount = amount;
        }

        // Метод вывода информации
        public void ShowInfo()
        {
            Console.WriteLine("Квитанция:");
            Console.WriteLine("Номер: " + Number);
            Console.WriteLine("Дата: " + Date);
            Console.WriteLine("Сумма: " + Amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта с параметрами
            Receipt receipt1 = new Receipt(101, "04.05.2026", 150.75f);

            // Вывод данных
            receipt1.ShowInfo();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}