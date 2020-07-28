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
            int zakresOd = WczytajLiczbe("Podaj dolny zakres losowania");
            int zakresDo = WczytajLiczbe("Podaj górny zakres losowania");
            int wylosowana = Losuj(zakresOd, zakresDo);
            Console.WriteLine($"Wylosowano wartość z zakresu od {zakresOd} do {zakresDo}");
#if DEBUG
           Console.WriteLine(wylosowana);
#endif
            do
            {
                //2. zaproponuj
                int propozycja = WczytajLiczbe("Podaj swoją propozycję: ");
                //3. oceń
                string odpowiedz = Ocena(propozycja, wylosowana);
                Console.WriteLine(odpowiedz);
                if (odpowiedz == TRAFIONO)
                {
                    //return; wychodzi z Main
                    break; //wychodzi z pętli
                }
            }
            while (true);
            Console.WriteLine("Koniec gry");
        }


        //*****************

        /// <summary>
        /// Losuje liczbę całkowitą z podanego zakresu włącznie z granicami(min i max)
        /// </summary>
        /// <remarks>
        /// Dłuższy teks z wyjaśnieniami
        /// </remarks>
        /// <param name="min">dolna granica losowania</param>
        /// <param name="max">górna granica losowania, nie mnaiejsza niż granica dolna</param>
        /// <returns>Liczba losowa z zakresu min...max włącznie</returns>
        static int Losuj(int min = 1, int max = 100)
        {
            var los = new Random();
            int y = los.Next(min, max+1);
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

        {
            if (propozycja < wylosowana)
            {
                return "za mało";

            }
            else if (propozycja > wylosowana)

            {
                return "za dużo";
            }
            else
            {
                return "trafiono";
            }
        }

        static int WczytajLiczbe(string tekst = "Podaj liczbę: " + "(X aby zakończyć): ")
        {

            int wynik;

            do
            {
                Console.Write(tekst + "(X aby zakończyć): ");
                string napis = Console.ReadLine();
               // if(napis == "X" || napis == "x")
               if (napis.ToUpper() == "X")
                {
                    Console.WriteLine("Poddałeś się! Koniec programu.");
                    Environment.Exit(0);
                }

                try
                {
                    wynik = int.Parse(napis);
                    return wynik;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Niepoprawny format. Spróbuj jeszcze raz!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Przekroczony zakres. Spróbuj jeszcze raz!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Nieznany błąd. Spróbuj jeszcze raz!");
                }
            }
            while (true);                  
        }
    }
}
