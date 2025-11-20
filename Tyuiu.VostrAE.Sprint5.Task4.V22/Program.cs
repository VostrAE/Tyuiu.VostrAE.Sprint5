using System;
using Tyuiu.VostrAE.Sprint5.Task4.V22.Lib;
class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\DataSprint5\InPutDataFileTask4V22.txt";

        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Результат:                                                               *");
        Console.WriteLine("***************************************************************************");
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан! ");
        Console.ReadKey();
    }
}
