using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A1NahdneCislaVPoli
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pole = new int[100000];
            Random rand = new Random();
            for(int i = 0; i < pole.Length; i++)
            {
                pole[i] = i;   
            }
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i]+", ");
            }

            Console.ReadLine();

        }
    }
}
