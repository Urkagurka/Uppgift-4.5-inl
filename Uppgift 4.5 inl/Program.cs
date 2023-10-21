using System;

namespace Uppgift_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string input = Console.ReadLine();
            string output = "";

            for (int i = 0;i< input.Length;i++)
            {
                string tecken = input[i].ToString ();
                try
                {
                    int siffra = int.Parse(tecken) + 1;
                    //    ++siffra;
                    //    siffra = siffra +  1;
                    if (siffra == 10)
                    {
                        siffra = 0;
                    }
                    output = output + siffra;
                }
                catch (Exception ex)
                {
                    Console.WriteLine ("tecken är inte en siffra: " + tecken);
                }
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}