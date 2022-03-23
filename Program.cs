using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Datentypengrößen

            int a = int.MaxValue;
            short b = short.MinValue;  // -2^8 ~ 2^8 - 1        //2*short.MaxValue+1
            long c;
            ushort d;  // 2^16



            Verzweigungen: (if-else Anweisung)

            int x = 5;
            int y = 7;
            if (x+y>10) Console.WriteLine("Hello");
            else if (x == 5)
            {
               int g = 9;
            }
            else
            {}



            Schleifen:  (wiederholte abläufe)

            int zähler;
            while (zähler<10)
            {
               zähler = zähler + 1;
               zähler += 1;
               zähler++;
            }
            
            do
            {
               
            } while (zähler <10);

            for (int i=0; i<10; i++)
            {}
            
            
            string test = Console.ReadLine();
            Console.WriteLine(test);


            */
            //Beispiel
            // Der Benutzer soll nach zwei ganzen Zahlen befragt werden,
            // falls die Summe größer als 125 ist soll das program beendet werden
            // ansonsten von vorn beginnen
            /*
            int a, b;
             do
             {
                 Console.WriteLine("Enter first number:");
                 a = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Enter second number:");
                 b = Convert.ToInt32(Console.ReadLine());
             } while (a + b < 125);
             */

            // Der Benutzer soll nach einer Jahreszahl gefragt werden und es soll ausgegeben werden ob es sich um ein Schaltjahr handelt.
            // Das Program soll von vorne Starten

            /*
            int jahr;
            string i;

            do
            {
                Console.WriteLine("Geben Sie ein Jahr an:");
                jahr = Convert.ToInt32(Console.ReadLine());
                if (jahr % 100 == 0)
                {
                    if (jahr % 400 == 0)
                    {
                        Console.WriteLine("Dieses Jahr ist ein Schaltjahr.");
                    }
                    else
                    {
                        Console.WriteLine("Dieses Jahr ist kein Schaltjahr.");
                    }
                }
                else if (jahr % 4 == 0)
                {
                    Console.WriteLine("Dieses Jahr ist ein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine("Dieses Jahr ist kein Schaltjahr.");
                }
                Console.WriteLine("Nochmal? (j/n):");
                i = Console.ReadLine();
            } while (i == "j" || i=="J");
            */

            // oder ||        und &&

            int jahr;
            string i;

            do
            {
                Console.WriteLine("Geben Sie ein Jahr an:");
                jahr = Convert.ToInt32(Console.ReadLine());
                if (jahr % 4 == 0 && (jahr % 100 != 0 || jahr % 400 == 0)) Console.WriteLine("Dieses Jahr ist ein Schaltjahr.");
                else Console.WriteLine("Dieses Jahr ist kein Schaltjahr.");
                Console.WriteLine("Nochmal? (j/n):");
                i = Console.ReadLine();
            } while (i == "j" || i == "J");

        }
    }
}
