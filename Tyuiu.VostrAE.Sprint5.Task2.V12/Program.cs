using System;
using Tyuiu.VostrAE.Sprint5.Task2.V12.Lib;
class program
{
    static void Main(string[] args)
    {
        int[,] mtrx = new int[3, 3] { { -5, -5, 9 },{-7, 3, -4 }, { 8, 7, 9 } };
        int rows = mtrx.GetUpperBound(0) + 1;
        int colums = mtrx.Length / rows;
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Массив:                                                                  *");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            { Console.Write($"{mtrx[i, j]}\t"); }
            Console.WriteLine();
        }
        Console.WriteLine() ;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Результат:                                                               *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(mtrx);
        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан! ");
        Console.ReadKey();
    }
}
