using System;
using Tyuiu.VostrAE.Sprint5.Task3.V29.Lib;
class Program
{
    static void Main(string[] args)
    {
        int x = 3;

        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("x = " +x );
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Результат:                                                               *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(x);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан! ");
        Console.ReadKey();
    }
}
