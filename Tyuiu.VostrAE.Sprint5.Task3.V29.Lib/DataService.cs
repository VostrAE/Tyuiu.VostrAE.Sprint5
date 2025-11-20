using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VostrAE.Sprint5.Task3.V29.Lib
{
    public class DataService : ISprint5Task3V29
    {
        public string SaveToFileTextData(int x)
        {
            string name = "OutPutFileTask2.bin";
            string path = Path.Combine(Path.GetTempPath(), name);
            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;
            if (FileExists)
            {
                File.Delete(path);
            }

            double z = Math.Round(Math.Pow(x,3)+ 2*Math.Pow(x, 2)+5*x+4, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8)) 
            {writer.Write(BitConverter.GetBytes(z)); }
            return path;
        }
    }
}
