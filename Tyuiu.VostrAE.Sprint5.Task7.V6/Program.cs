using System;
using System.Globalization;
using Tyuiu.VostrAE.Sprint5.Task7.V6.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask7V6.txt";
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Результат:                                                               *");
        Console.WriteLine("***************************************************************************");
        string pathSave = ds.LoadDataAndSave(path);
        Console.WriteLine("Находится в файле: " + pathSave);
        Console.ReadKey();
    }
}
