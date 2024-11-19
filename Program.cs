using System;

class GenericComparer<T> where T : IComparable<T>
{
    private T value; // Поле для зберігання значення

    // Конструктор для ініціалізації значення
    public GenericComparer(T value)
    {
        this.value = value;
    }

    // Метод для знаходження меншого з двох чисел
    public T FindSmaller(T other)
    {
        return value.CompareTo(other) < 0 ? value : other;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад для цілих чисел
        GenericComparer<int> intComparer = new GenericComparer<int>(10);
        Console.WriteLine($"Smaller of 10 and 20: {intComparer.FindSmaller(20)}");

        // Приклад для дійсних чисел
        GenericComparer<double> doubleComparer = new GenericComparer<double>(15.5);
        Console.WriteLine($"Smaller of 15.5 and 10.2: {doubleComparer.FindSmaller(10.2)}");

        Console.ReadKey();
    }
}
