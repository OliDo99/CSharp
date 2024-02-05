using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1Subory02
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "textak.dta";
            string file2 = "textak2.dta";
            string file3 = "textak3.dta";
            Zapis(file);
            Console.Write("Vypis file1: ");
            Vypis(file);
            Console.WriteLine();
            Console.WriteLine(PocetIntov(file));
            Prepis(file, file2);
            Console.Write("Vypis file2 /prepis: ");
            Vypis(file2);
            Console.WriteLine();
            Parne(file, file2, file3);
            Console.Write("Vypis file3 /parne z 1 a 2: ");
            Vypis(file3);


            Console.ReadLine();
        }
        static void Zapis(string name)
        {
            using (FileStream fStream = new FileStream(name, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bWriter = new BinaryWriter(fStream))
            {
                Random gen = new Random();
                for(int i = 0; i < gen.Next(1, 100); i++)
                {
                    bWriter.Write(gen.Next(1, 100));
                }
            }
        }
        static void Vypis(string name)
        {
            using (FileStream fStream = new FileStream(name, FileMode.Open, FileAccess.Read))
            using (BinaryReader bReader= new BinaryReader(fStream))
            {
                while (fStream.Length > fStream.Position)
                {
                    Console.Write(bReader.ReadInt32()+", ");
                }
            }
        }
        static int PocetIntov(string name)
        {
            int counter = 0;
            using (FileStream fStream = new FileStream(name, FileMode.Open, FileAccess.Read))
            using (BinaryReader bReader = new BinaryReader(fStream))
            {
                while (fStream.Length > fStream.Position)
                {
                    bReader.ReadInt32();
                    counter++;
                }
            }
            return counter;
        }
        static void Prepis(string name1, string name2)
        {
            int[] pole = new int[PocetIntov(name1)];
            using (FileStream fStream = new FileStream(name1, FileMode.Open, FileAccess.Read))
            using (BinaryReader bReader = new BinaryReader(fStream))
            {
                for(int i = 0; fStream.Length > fStream.Position; i++)
                {
                    pole[i] = bReader.ReadInt32();
                }
            }

            using (FileStream fStream = new FileStream(name2, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bWriter = new BinaryWriter(fStream))
            {
                for (int i = 0; i < pole.Length; i++)
                {
                    bWriter.Write(pole[i]);
                }
            }
        }
        static void Parne(string name1, string name2,string name3)
        {
            int[] pole = new int[PocetIntov(name1) + PocetIntov(name2)];
            int i = 0;
            using (FileStream fStream = new FileStream(name1, FileMode.Open, FileAccess.Read))
            using (BinaryReader bReader = new BinaryReader(fStream))
            {
                while (fStream.Length > fStream.Position)
                {
                    if (bReader.ReadInt32() % 2 == 0) { pole[i] = bReader.ReadInt32(); }
                    
                    i++;
                }
            }
            using (FileStream fStream = new FileStream(name2, FileMode.Open, FileAccess.Read))
            using (BinaryReader bReader = new BinaryReader(fStream))
            {
                while (fStream.Length > fStream.Position)
                {
                    if (bReader.ReadInt32() % 2 == 0) { pole[i] = bReader.ReadInt32(); }
                    i++;
                }
            }
            using (FileStream fStream = new FileStream(name3, FileMode.Create, FileAccess.Write))
            using (BinaryWriter bWriter = new BinaryWriter(fStream))
            {
                for (int x = 0; x < i; x++)
                {
                    bWriter.Write(pole[x]);
                }
            }

        }
    }
}
