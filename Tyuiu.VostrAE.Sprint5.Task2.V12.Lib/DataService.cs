using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.VostrAE.Sprint5.Task2.V12.Lib
{
    public class DataService : ISprint5Task2V12
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string name = "OutPutFileTask2.csv";
            string path = Path.Combine(Path.GetTempPath(), name);
            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;
            if (FileExists)
            {
                File.Delete(path);
            }


            int rows = matrix.GetUpperBound(0)+1;
            int colums = matrix.Length/rows;
            for (int i=0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (matrix[i,j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            string str = "";
            for (int i = 0; i< rows; i++) {
                for (int j = 0; j < colums; j++){
                    if (j != colums - 1)
                    {
                        str += matrix[i, j] + ";";
                    }
                    else str += matrix[i, j];
                }

                if (i !=rows - 1)
                {
                    File.AppendAllText(path,str + Environment.NewLine);
                }
                else { File.AppendAllText(path,str); }
                str = "";
            }
            return path;
        }
    }
}
