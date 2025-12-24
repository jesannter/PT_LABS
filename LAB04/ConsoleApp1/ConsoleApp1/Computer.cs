
using System;

public class Computer
{
    // Внутренние "ящики" для хранения данных
    private string _processor;
    private int _ram;
    private int _storage;
    private decimal _price;

    // Свойство: Процессор
    public string Processor
    {
        get => _processor;
        set => _processor = value ?? throw new ArgumentNullException("Процессор не может быть пустым.");
    }

    // Свойство: ОЗУ (должна быть > 0)
    public int RAM
    {
        get => _ram;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("ОЗУ должна быть больше 0.");
            _ram = value;
        }
    }

    // Свойство: Жёсткий диск (должен быть > 0)
    public int Storage
    {
        get => _storage;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Жёсткий диск должен быть больше 0.");
            _storage = value;
        }
    }

    // Свойство: Цена (не может быть < 0)
    public decimal Price
    {
        get => _price;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Цена не может быть отрицательной.");
            _price = value;
        }
    }

    // Конструктор: как "рождается" компьютер
    public Computer(string processor, int ram, int storage, decimal price)
    {
        Processor = processor;
        RAM = ram;
        Storage = storage;
        Price = price;
    }

    // Метод: подходит ли для игр?
    public bool IsGamingReady()
    {
        return RAM >= 8;
    }

    // Метод: сколько стоит 1 ГБ ОЗУ?
    public decimal GetPricePerGB()
    {
        if (RAM == 0)
            throw new InvalidOperationException("Нельзя делить на ноль!");
        return Price / RAM;
    }

    // Метод: красиво рассказать о себе
    public void PrintComputerInfo()
    {
        Console.WriteLine($"Процессор: {Processor}");
        Console.WriteLine($"ОЗУ: {RAM} ГБ");
        Console.WriteLine($"Жёсткий диск: {Storage} ГБ");
        Console.WriteLine($"Цена: {Price:C}");
        Console.WriteLine($"Подходит для игр: {(IsGamingReady() ? "Да" : "Нет")}");
        Console.WriteLine($"Цена за 1 ГБ ОЗУ: {GetPricePerGB():C}");
        Console.WriteLine(new string('-', 40));
    }
}