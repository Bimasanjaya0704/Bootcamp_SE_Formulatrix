
using System.Text;

class Program
{
    static void Main()
    {
        string path = @".\myName.txt";
        using (FileStream fs = new(path, FileMode.OpenOrCreate))
        {
            string name = "Bima Sanjaya";
            byte[] bytes = Encoding.UTF8.GetBytes(name);
            fs.Write(bytes, 0, bytes.Length);
        }
    }
}
