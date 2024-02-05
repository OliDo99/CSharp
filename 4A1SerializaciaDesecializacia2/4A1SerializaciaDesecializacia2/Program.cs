using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _4A1SerializaciaDesecializacia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozidlo[] auta = new Vozidlo[10];
            for (int i = 0; i < 10; i++){
                auta[i] = new Vozidlo(i, 66700.4, "BMW", 6.7);
            }

            FileStream fStream = new FileStream("subor.srz", FileMode.Create);

            BinaryFormatter vystup = new BinaryFormatter();
            for (int i = 0; i < 10; i++) { 
                vystup.Serialize(fStream, auta[i]); 
            }
               
            fStream.Close();

            BinaryFormatter vstup = new BinaryFormatter();
            fStream = new FileStream("subor.srz", FileMode.Open);
            Vozidlo auto;
            for (int i = 0; i < 10; i++) {
                auto = (Vozidlo)vstup.Deserialize(fStream);
                Console.WriteLine("pcet kolies - " + auto.GetPocetKolies());
                Console.WriteLine("najazdene km - " + auto.GetNajazdeneKM());
                Console.WriteLine("tovarenska znacak - " + auto.GetToverenskaZnacka());
                Console.WriteLine("priemerna spotreba - " + auto.GetPriemernaSpotreba());
            }
           

            Console.ReadLine();
        }
    }
}
