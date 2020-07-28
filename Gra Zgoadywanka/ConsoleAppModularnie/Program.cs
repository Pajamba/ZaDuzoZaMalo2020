using System;

namespace ConsoleAppModularnie
{
    class Program
    {
        const string ZA_DUZO = "za dużo";
       const string ZA_MALO = "za mało";
        const string TRAFIONO = "trafiono";
        static void Main()
        {
            Console.WriteLine("Za dużo - za mało proceduralnie");
            //1. losuj
            //człowiek podaje zakres losowania min max
            int wylosowana = Losuj();

            bool odgadnieto = false;
            do
            {


                //2. zaproponuj
                //int propozycja = wczytajLiczba();
                //3. oceń
            }
            while (!odgadnieto);
        }


        //*****************
        static int Losuj(int min = 1, int max = 101)
        {
            var los = new Random();
            int y = los.Next(min, max);
            return y;
        }
        int Losuj1(int min = 1, int max = 101)
        {
            var los = new Random();
            return los.Next(min, max);
        }
        int Losuj2(int min = 1, int max = 101)
        {
            return (new Random().Next(min, max));
        }

        static string Ocena(int propozycja, int wylosowana)
            if (propozycja<wylosowana )
    {
        return "za dużo";

    }
    else if(propozycja>wylosowana )
         
    {
        return "za mało";
}
    else
{
    return "trafiono";
}
    }
}
