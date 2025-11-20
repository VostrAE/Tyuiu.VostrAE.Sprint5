using System.Globalization;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VostrAE.Sprint5.Task4.V22.Lib

{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            string strx = File.ReadAllText(path);
            string x = File.ReadAllText(path);
            double z = Convert.ToDouble(x.Replace(".", ","));
            double res = Math.Round(Math.Pow(z,3)*Math.Sin(z)-4* z, 3);
            return res;
        }
    }
}
