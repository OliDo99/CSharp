using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1SerializaciaDesecializacia
{
    class Program
    {
        static void Main(string[] args)
        {
            Vozidlo auto1 = new Vozidlo(4, 66700.4, "BMW", 6.7);
            //Serializacia

            FileStream fStream = new FileStream("subor.srz", FileMode.Create);

            BinaryFormatter vystup = new BinaryFormatter();

            vystup.Serialize(fStream, auto1);
            fStream.Close();

            //deserializacia
            BinaryFormatter vstup = new BinaryFormatter();
            fStream = new FileStream("subor.srz", FileMode.Open);

            Vozidlo auto = (Vozidlo)vstup.Deserialize(fStream);
            Console.WriteLine("pcet kolies - " + auto.pocetKolies);
            Console.WriteLine("najazdene km - " + auto.najazdeneKM);
            Console.WriteLine("tovarenska znacak - " + auto.tovarenskaZnacak);
            Console.WriteLine("priemerna spotreba - " + auto.priemernaSpotreba);


            Console.ReadLine();
        }
    }
}
