using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1Subory3
{
    class Program
    {
        static void Main(string[] args)
        {
            GenRand("textak.dta",5,20);
            
            Vypis("textak.dta");
            Console.WriteLine();
            OdKonca("textak.dta", "textak2.dta");
            Vypis("textak2.dta");


            Console.ReadLine();

        }
        static void GenRand(string name,int min, int max)
        {
            using (FileStream fStream = new FileStream(name, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bWriter = new BinaryWriter(fStream))
            {
                Random gen = new Random();
                for (int i = 0; i < 10; i++)
                {

                    double number = Convert.ToDouble(gen.Next(min, max) +","+ gen.Next(0, 10)+ gen.Next(0, 10)+ gen.Next(0, 10));
                    bWriter.Write(number);
                }
            }
        }
        static void Vypis(string name)
        {
            using (FileStream fStream = new FileStream(name, FileMode.Open, FileAccess.Read))
            using (BinaryReader bReader = new BinaryReader(fStream))
            {
                while (fStream.Length > fStream.Position)
                {
                    Console.WriteLine(bReader.ReadDouble());
                }
            }
        }
        static void OdKonca(string name,string name2)
        {
            double[] pole;
            int len = 0;
            using (FileStream fStream = new FileStream(name, FileMode.Open, FileAccess.Read))
            using (BinaryReader bReader = new BinaryReader(fStream))
            {
                pole = new double[fStream.Length];
                while (fStream.Length > fStream.Position)
                {
                    pole[len] = bReader.ReadDouble();
                    len++;
                }
            }
            using (FileStream fStream = new FileStream(name2, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bWriter = new BinaryWriter(fStream))
            {
                for (int i = len-1; i >= 0 ; i--)
                {
                    bWriter.Write(pole[i]);
                }
            }
        }
    }
}
