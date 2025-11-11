using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.VostrAE.Sprint5.Task1.V23.Lib
{
    public class DataService : ISprint5Task1V23
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string name = "OutPutFileTask1.txt";
            string path = Path.Combine(Path.GetTempPath(), name);

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;
            if (FileExists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2 == 0) { y = 0; strY = Convert.ToString(Math.Round(y, 2)); }
                else
                {
                    y = Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x;
                    strY = Convert.ToString(Math.Round(y, 2));
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
