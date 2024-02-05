using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1ZnakoveSubory02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string name = "textak.txt";
            string name2 = "textak2.txt";
            string name3 = "textak3.txt";
            Prepis(name,name2);
            Prepis2(name, name3);
            Vypis(name3);
            Console.ReadLine();
        }
        static void Zapis(string name)
        {
            using (FileStream fStream = new FileStream(name, FileMode.Create, FileAccess.Write))
            using (StreamWriter sWriter = new StreamWriter(fStream))
            {
                for (int i = 1; i <= 4; i++)
                {
                    string veta = Console.ReadLine();
                    sWriter.WriteLine(veta);
                }
            }
        }
        static void Prepis(string name,string name2)
        {
            string[] pole;
            using (FileStream fStream = new FileStream(name, FileMode.Open, FileAccess.Read))
            using (StreamReader sReader = new StreamReader(fStream))
            {
                string veta;
                pole = new string[4];
                int i = 0;
                while ((veta = sReader.ReadLine()) != null)
                { 
                    pole[i] = veta;
                    i++;
                }
            }
            
            using (FileStream fStream = new FileStream(name2, FileMode.Create, FileAccess.Write))
            using (StreamWriter sWriter = new StreamWriter(fStream))
            {
                for (int i = 0; i < 4; i++)
                {
                    sWriter.WriteLine(pole[i]);
                }
            }
        }
        static void Prepis2(string name, string name2)
        {
            using (FileStream fStream = new FileStream(name2, FileMode.Create, FileAccess.Write))
            using (StreamWriter sWriter = new StreamWriter(fStream))
            {
                string[] cringe = File.ReadAllLines(name);
                foreach (string veta in cringe)
                {
                    string[] slova = veta.Split(' ');
                    Array.Reverse(slova);
                    string reverse = string.Join(" ", slova);
                    sWriter.WriteLine(reverse);
                }
            }
        }

        static void Vypis(string name)
        {   
            using (FileStream fStream = new FileStream(name, FileMode.Open, FileAccess.Read))
            using (StreamReader sReader = new StreamReader(fStream))
            {
                string veta;
                while ((veta = sReader.ReadLine()) != null)
                {
                    Console.WriteLine(veta);
                }
            }
        }
    }
}
