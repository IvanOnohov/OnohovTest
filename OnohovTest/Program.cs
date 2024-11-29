using System;
using InspectorLib;

public class Program
{
    public static void Main(string[] args)
    {
        FunctionInsp inspector = new FunctionInsp();

        Console.WriteLine($"Главный инспектор: {inspector.GetInspector()}");
        Console.WriteLine($"Название автоинспекции: {inspector.GetCarInspection()}");
        bool success1 = inspector.SetInspector("Макаров А.Д.");
        Console.WriteLine($"Изменение главного инспектора не произошло: {success1}");
        bool success2 = inspector.SetInspector("Зиронов Т.А.");
        Console.WriteLine($"Изменение главного инспектора успешно: {success2}");
        Console.WriteLine($"Новый главный инспектор: {inspector.GetInspector()}");
        Random random = new Random();
        char symbol = (char)random.Next('A', 'Z' + 1);
        string number = Convert.ToString(random.Next(100, 999));
        string code = "75";
        string licensePlate = inspector.GenerateNumber(symbol, number, code);
        Console.WriteLine($"Сгенерированный госномер: {licensePlate}");

        Console.WriteLine("Список сотрудников:");
        foreach (string worker in inspector.GetWorker())
        {
            Console.WriteLine($"- {worker}");
        }

        inspector.AddWorker("Петров П.П.");
        Console.WriteLine("\nСписок сотрудников после добавления:");
        foreach (string worker in inspector.GetWorker())
        {
            Console.WriteLine($"- {worker}");
        }

        Console.ReadKey();
    }
}