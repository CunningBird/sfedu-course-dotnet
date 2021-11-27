// MyApplication.cs
using System;
using MyLib;
class App1 {
    static void Main(string[] args) {
        int a, b;
        try {
            Console.Write("Введите a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", a, b, MyClass.add(a, b));
        }
        catch (FormatException) {
            Console.WriteLine("Ошибка ввода");
        }
        Console.WriteLine("Программа завершена");
	a = int.Parse(Console.ReadLine());
    }
}
