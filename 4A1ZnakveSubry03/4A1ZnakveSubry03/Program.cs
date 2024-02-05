using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1ZnakveSubry03
{
    class Program
    { 
        static void Main(string[] args)
        {
            string name = "textak";
            Zapis(name);
            Console.WriteLine();
            Vypis(name);
            Console.ReadLine();
        }
        static void Zapis(string name)
        {
            using (FileStream fStream = new FileStream(name, FileMode.Create, FileAccess.Write))
            using (StreamWriter sWriter = new StreamWriter(fStream))
            {
                for (int i = 1; i <= 4; i++)
                {
                    sWriter.WriteLine(Console.ReadLine());
                }
            }
        }
        static void Vypis(string name)
        {
            using (FileStream fStream = new FileStream(name, FileMode.Open, FileAccess.Read))
            using (StreamReader sReader = new StreamReader(fStream))
            {
                string veta;
                string numbers = "";
                while (!sReader.EndOfStream)
                {
                    veta = sReader.ReadLine();
                    foreach(char znak in veta)
                    {
                        if (Char.IsNumber(znak)){
                            numbers += znak;
                        }
                        else if(numbers != ""){
                            Console.WriteLine(numbers);
                            numbers = "";
                        }
                    }
                    if(numbers != "")
                    {
                        Console.WriteLine(numbers);
                        numbers = "";
                    }
                }
            }
        }
    }
}
