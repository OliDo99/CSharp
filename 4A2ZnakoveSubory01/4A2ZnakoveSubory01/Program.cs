using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A2ZnakoveSubory01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "textak.txt";
            Zapis(name);
            Vypis(name);

            Console.ReadLine();
        }
        static void Zapis(string name)
        {
            using (FileStream fStream = new FileStream(name,FileMode.Create, FileAccess.Write))
            using(StreamWriter sWriter = new StreamWriter(fStream))
            {
                for (int i = 1; i<=3; i++)
                {
                    string veta = Console.ReadLine();
                    sWriter.WriteLine(veta);
                }
            }
        }
        static void Vypis(string name)
        {
            using (FileStream fStream = new FileStream(name, FileMode.Open, FileAccess.Read))
            using (StreamReader sReader = new StreamReader(fStream))
            {
                string veta;
                while((veta=sReader.ReadLine()) != null)
                {
                    Console.WriteLine(veta);
                }
            }
        }
    }
}
