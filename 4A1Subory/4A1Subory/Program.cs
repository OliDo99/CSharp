using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1Subory
{
    class Program
    {
        static void Main(string[] args)
        {
            string meno = "subor1.dta";
            ZapidDoSuboru(meno);
            Console.ReadLine();
            NacitanieSuboru(meno);
            
            
            
            Console.ReadLine();
        }
        static void ZapidDoSuboru(string meno)
        {
            using (FileStream fStream = new FileStream(meno, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bWriter = new BinaryWriter(fStream))
            {
                Random gen = new Random();
                for(int i = 0; i < 10; i++)
                {
                    bWriter.Write(gen.Next(1, 20));
                }
            }
        }
        static void NacitanieSuboru(string meno)
        {
            using (FileStream fStream = new FileStream(meno, FileMode.Open, FileAccess.Read))
            using (BinaryReader bReader = new BinaryReader(fStream))
            {
                while (fStream.Length > fStream.Position)
                {
                    int cislo = bReader.ReadInt32();
                    ParneCislo(cislo);
                }
            }
        }

        static void ParneCislo(int cislo)
        {
            if (cislo % 2 == 0)
            {
                Console.WriteLine(cislo);
            }
        }

    }
}
