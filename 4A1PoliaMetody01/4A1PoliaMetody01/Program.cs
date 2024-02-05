using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1PoliaMetody01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole;
            int[] castPola;
            MetodyPola.ZapisDoPola(10, 1, 10, out pole);
            MetodyPola.VypisPola(pole);



            castPola = MetodyPola.CastPola(pole,5,8);

            MetodyPola.VypisPola(castPola);




            /*Console.WriteLine(MetodyPola.Pocetparnych(pole));
            Console.WriteLine(MetodyPola.DruheNajvacsie(pole));
            Console.WriteLine(MetodyPola.DruhePosledne(pole));
            Console.WriteLine(MetodyPola.DruhePosledne(pole));*/



            Console.ReadLine();
        }
    }
   
}
