using System;
using System.Globalization;
using Tyuiu.VostrAE.Sprint5.Task6.V18.Lib;
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
        Console.WriteLine("Количество одноразрядных чисел в заданной строке: " + res);
        Console.ReadKey();
    }
}
