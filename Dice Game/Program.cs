// 0xRETRO https://github.com/0xr3tro
using System;

internal class Program
{
    private static void Main()
    {
        // Powitanie gracza
        Console.WriteLine("Witaj w grze w rzucanie kośćmi!");

        // Pobranie imienia gracza
        Console.Write("Podaj swoje imię: ");
        string imie = Console.ReadLine();

        // Przywitanie gracza
        Console.WriteLine($"Cześć, {imie}! Zaczynamy grę!");

        // Pętla do powtarzania gry
        while (true)
        {
            // Deklaracja zmiennych
            int rzutGracza;
            Random rand = new Random(); // Inicjalizacja generatora liczb losowych

            // Pętla do wprowadzenia poprawnego wyniku
            while (true)
            {
                Console.Write("Podaj swój wynik rzutu kostką (1-6): ");

                // Sprawdzenie, czy dane wejściowe są liczbą
                if (int.TryParse(Console.ReadLine(), out rzutGracza))
                {
                    // Sprawdzenie, czy liczba mieści się w zakresie
                    if (rzutGracza >= 1 && rzutGracza <= 6)
                    {
                        break; // Przerwij pętlę, gdy dane są poprawne
                    }
                    else
                    {
                        Console.WriteLine("Proszę podać liczbę w zakresie 1-6.");
                    }
                }
                else
                {
                    Console.WriteLine("Proszę podać poprawną liczbę.");
                }
            }

            // Symulacja rzutu kostką komputera
            int rzutKostka = rand.Next(1, 7); // Rzucamy kostką (1-6)
            Console.WriteLine($"Wynik rzutu komputera to: {rzutKostka}");

            // Sprawdzenie wyniku gry
            if (rzutGracza > rzutKostka)
            {
                Console.WriteLine("Gratulacje! Wygrałeś!");
            }
            else if (rzutGracza == rzutKostka)
            {
                Console.WriteLine("Remis!");
            }
            else
            {
                Console.WriteLine("Niestety, przegrałeś. Spróbuj ponownie!");
            }

            // Pytanie, czy gracz chce kontynuować
            string odpowiedz;
            while (true)
            {
                Console.Write("Czy chcesz zagrać ponownie? (tak/nie): ");
                odpowiedz = Console.ReadLine().ToLower();

                if (odpowiedz == "tak" || odpowiedz == "nie")
                {
                    break; // Wyjdź z pętli, jeśli odpowiedź jest prawidłowa
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa odpowiedź. Wpisz 'tak' lub 'nie'.");
                }
            }

            // Zakończenie gry, jeśli gracz nie chce kontynuować
            if (odpowiedz != "tak")
            {
                Console.WriteLine("Dziękujemy za grę! Do zobaczenia!");
                break; // Zakończenie gry
            }
        }
    }
}