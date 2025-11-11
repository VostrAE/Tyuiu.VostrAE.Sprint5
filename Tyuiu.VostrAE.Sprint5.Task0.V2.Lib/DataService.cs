using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.VostrAE.Sprint5.Task0.V2.Lib
{
    public class DataService : ISprint5Task0V2
    {
        public string SaveToFileTextData(int x)
        {
            string name = "OutPutFileTask0.txt";
            string path = Path.Combine(Path.GetTempPath(), name);
            double y = (Math.Pow(Math.E,x)/x);
            y =Math.Round(y,3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
