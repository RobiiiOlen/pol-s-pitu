using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6by6_table
{
    class Program
    {
        static void Main(string[] args)
        {   //lisan sisendi "x", annan talle väärtuse, ülesssande(i <= 6) ja y++ tähendab et liidab ida loobi järel +1 eelmisele arvule.
            for (int x = 0; x <= 6; x++)
            {   //lisan samamooodi teise väärtuse
                for (int y = 0; y <= 6; y++)
                {   //korrutan mõlemad, /t teeb lisa tabi
                    Console.Write(x * y + "   |\t");
                    
                }
                Console.Write("\n\n");
                Console.WriteLine("--------------------------------------------------");
            }

            Console.ReadLine();

        }
    }
}
