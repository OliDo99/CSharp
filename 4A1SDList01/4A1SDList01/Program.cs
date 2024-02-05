using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _4A1SDList01
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba[] osoby = new Osoba[8];
            for (int i = 0; i < osoby.Length; i++)
            {
                osoby[i] = new Osoba(i+10, "Oliver", "Dohnal");
            }

            FileStream fStream = new FileStream("subor.srz", FileMode.Create);
            BinaryFormatter vystup = new BinaryFormatter();
            for (int i = 0; i < osoby.Length; i++)
            {
                vystup.Serialize(fStream, osoby[i]);
                
            }
            fStream.Close();

            Osoba[] newOsoby = new Osoba[osoby.Length];
            BinaryFormatter vstup = new BinaryFormatter();
            fStream = new FileStream("subor.srz", FileMode.Open);
            for (int i = 0; i < osoby.Length; i++)
            {
                newOsoby[i] = (Osoba)vstup.Deserialize(fStream);
            }

            for (int i = 0; i < osoby.Length; i++)
            {
                Console.WriteLine("Vek: "+newOsoby[i].GetVek());
                Console.WriteLine("Meno: "+ newOsoby[i].GetMeno()+ " " + newOsoby[i].GetPriezvisko());
            }

            //get Max
            int max = 0;
            for (int i = 0; i < osoby.Length; i++)
            {
                
                if (max <= osoby[i].GetVek())
                {
                    max = osoby[i].GetVek();
                }
            }
            Console.WriteLine("Max vek: " + max);


            Console.ReadLine();
        }
    }
}
