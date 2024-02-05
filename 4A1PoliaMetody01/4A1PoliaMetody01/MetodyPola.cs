using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1PoliaMetody01
{
    class MetodyPola
    {
        
        public static void ZapisDoPola(int len, int min, int max, out int[] pole) 
        {
            Random rand = new Random();
            pole = new int[len];
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rand.Next(min, max);
            }
        }
        public static void VypisPola(int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
            Console.WriteLine();
        }
        public static int Pocetparnych(int[] pole)
        {
            int pocetParnych = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if(pole[i] % 2 == 0)
                {
                    pocetParnych++;
                }
            }
            return pocetParnych;
        }
        public static int DruheNajvacsie(int[] pole)
        {
            int pocet = 0;
            int sLargest = 0;
            
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < pole.Max() && pole[i] > sLargest)
                {
                    sLargest = pole[i];
                }
            }
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i]== sLargest)
                {
                    pocet++;
                }
            }
            return pocet;
        }
        public static int DruhePosledne(int[] pole)
        {
            int pocet = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] == pole[pole.Length-1])
                {
                    pocet++;
                }
            }
            return pocet;
        }
        public static int[] CastPola(int[] pole, int prve)
        {
            if (prve <= pole.Length && prve >=0) {
                int[] castPola = new int[prve];
                for (int i = 0; i < prve; i++){
                    castPola[i] = pole[i];
                }
                return castPola;
            }
            else
            {
                Console.WriteLine("No.");
                return null;
            }
            
        }
        public static int[] CastPola(int posledne, int[] pole)
        {
            int counter = 0;
            if (posledne <= pole.Length && posledne >= 0)
            {
                int[] castPola = new int[posledne];
                for (int i = pole.Length-posledne; i < pole.Length; i++)
                {
                    castPola[counter] = pole[i];
                    counter++;
                }
                return castPola;
            }
            else
            {
                Console.WriteLine("No.");
                return null;
            }

        }

        public static int[] CastPola(int[] pole, int prve, int posledne)
        {
            int counter = 0;
            if (prve <= pole.Length && prve >= 0 && posledne <= pole.Length && posledne >= 0)
            {
                int[] castPola = new int[posledne-prve+1];
                for (int i = pole.Length - prve-1; i < posledne; i++)
                {
                    castPola[counter] = pole[i];
                    counter++;
                }
                return castPola;
            }
            else
            {
                Console.WriteLine("No.");
                return null;
            }

        }

    }
}
