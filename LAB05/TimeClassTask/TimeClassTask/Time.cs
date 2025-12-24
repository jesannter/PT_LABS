public class Time
{
    // Приватные поля для хранения данных
    private int _hours;   // Часы
    private int _minutes; // Минуты
    private int _seconds; // Секунды

    // Конструктор с параметрами по умолчанию (0:0:0)
    public Time(int hours = 0, int minutes = 0, int seconds = 0)
    {
        // Используем свойства для установки, чтобы сработала проверка корректности
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    // Свойства для доступа к полям с проверкой корректности
}
public class Time
{
    // Приватные поля для хранения данных
    private int _hours;   // Часы
    private int _minutes; // Минуты
    private int _seconds; // Секунды

    // Конструктор с параметрами по умолчанию (0:0:0)
    public Time(int hours = 0, int minutes = 0, int seconds = 0)
    {
        // Используем свойства для установки, чтобы сработала проверка корректности
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }

    // ============ ВСТАВЬТЕ СЮДА КОД ИЗ ЭТАПА 2 ============
    // Свойства для доступа к полям с проверкой корректности
    public int Hours
    {
        get { return _hours; } // При чтении просто возвращаем значение поля
        set
        {
            // При записи проверяем корректность
            if (value < 0 || value > 23)
            {
                throw new ArgumentException("Часы должны быть в диапазоне от 0 до 23.");
            }
            _hours = value; // Если проверка пройдена, присваиваем
        }
    }

    public int Minutes
    {
        get { return _minutes; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Минуты должны быть в диапазоне от 0 до 59.");
            }
            _minutes = value;
        }
    }

    public int Seconds
    {
        get { return _seconds; }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Секунды должны быть в диапазоне от 0 до 59.");
            }
            _seconds = value;
        }
    }
    // ============ КОНЕЦ КОДА ИЗ ЭТАПА 2 ============

    // Далее будут другие методы (ToString, Equals, операторы)
}
