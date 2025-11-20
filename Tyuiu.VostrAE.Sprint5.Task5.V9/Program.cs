using System;
using System.Globalization;
using Tyuiu.VostrAE.Sprint5.Task5.V9.Lib;
class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\DataSprint5\InPutDataFileTask5V9.txt";

        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Результат:                                                               *");
        Console.WriteLine("***************************************************************************");
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Максимальное значение в файле: " + res);
        Console.WriteLine("Создан! ");
        Console.ReadKey();
    }
}
