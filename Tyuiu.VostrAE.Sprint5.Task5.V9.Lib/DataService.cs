using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VostrAE.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (string x in line.Split(" "))
                    {
                        double z = Convert.ToDouble(x.Replace(".", ","));
                        if (z == Math.Truncate(z))
                        {
                            if (z > res)  { res = z;}
                        }
                    }
                   
                }
                return res;
            }
        }
    }
}
        


