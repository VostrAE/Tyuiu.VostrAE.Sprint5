using System.IO;
using System.Numerics;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VostrAE.Sprint5.Task7.V6.Lib
{
    public class DataService : ISprint5Task7V6
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V6.txt");
            FileInfo fileInfo = new FileInfo(pathSave);
            bool FileExists = fileInfo.Exists;
            if (FileExists)
            {
                File.Delete(pathSave);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string nline = "";
                    foreach (char z in line)
                    {
                        if ((z >= 'a' && z <= 'z') || (z >= 'A' && z <= 'Z'))
                        {
                            nline += '#';
                        }
                        else
                        {
                            nline += z;
                        }
                    }
                    File.WriteAllText(pathSave, nline);
                }
            }
            return pathSave;
        }  
    }
}

