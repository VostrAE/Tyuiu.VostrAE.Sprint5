using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VostrAE.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (string x in line.Split(" "))
                        if (int.TryParse(x, out int z))
                        {
                            if ((z >= 0) && (z <= 9))
                            {
                                count++;
                            }
                        }
                }
                return count;
            }
        }
    }
}