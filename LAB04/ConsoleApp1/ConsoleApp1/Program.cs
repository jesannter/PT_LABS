using System;
using System.Text; // Добавляем для работы с кодировками

class Program
{
    static void Main()
    {
        // Настраиваем консоль для правильного отображения русских символов
        Console.OutputEncoding = Encoding.UTF8; // Для вывода русских букв
        Console.InputEncoding = Encoding.UTF8;  // Для ввода русских букв с клавиатуры

        Console.WriteLine("=== Нормальные компьютеры ===\n");

        // Создаём три правильных компьютера
        var pc1 = new Computer("Intel i7", 16, 1024, 1200m);
        var pc2 = new Computer("AMD Ryzen 5", 8, 512, 700m);
        var pc3 = new Computer("Intel Celeron", 4, 256, 300m);

        // Просим каждый рассказать о себе
        pc1.PrintComputerInfo();
        pc2.PrintComputerInfo();
        pc3.PrintComputerInfo();

        Console.WriteLine("\n=== Проверка ошибок (валидация) ===\n");

        // Попытка создать компьютер с ОЗУ = 0 → ошибка!
        try
        {
            var bad1 = new Computer("Test", 0, 500, 500m);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        // Попытка с отрицательной ценой → ошибка!
        try
        {
            var bad2 = new Computer("Test", 8, 512, -100m);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        // Попытка с null-процессором → ошибка!
        try
        {
            var bad3 = new Computer(null, 8, 512, 500m);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        Console.WriteLine("\nВсё работает!");
    }
}
