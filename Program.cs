using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata" );
            
           

            //nsole.Write("Sisesta number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
           // int magicNumber = 33;
            Random random = new Random();
            int randomNumber = random.Next(0, 100);


            
            while (true)
                
            {
                Console.Write("Sisesta number: ");
                Console.ReadLine();



                if (number < randomNumber) //magicNumber)
                {
                    Console.WriteLine("Number on suurem");
                   // Console.Write("Sisesta number: ");
                    
                }
                
                if (number > randomNumber)//magicNumber)
                {
                    Console.WriteLine("Number on väiksem");
                   // Console.Write("Sisesta number: ");
                    
                }
                if (number == randomNumber)//magicNumber)
                {
                    Console.WriteLine("Arvasid numbri ära!");
                    //Console.Write("Sisesta number: ");
                    break;

                }
                
                




            }
            
            Console.ReadLine();

            /* while (true)
               {
                   Console.Write("Sisesta number: ");
                   if (number == randomNumber)
                       Console.ReadLine();
                   break;
               }*/


        }
    }
}
