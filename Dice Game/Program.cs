//0xRETRO https://github.com/0xr3tro
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

            // Symulacja rzutu kostką
            int rzutKostka = rand.Next(1, 7); // Rzucamy kostką (1-6)
            Console.WriteLine($"Wynik rzutu kostką to: {rzutKostka}");

            // Sprawdzenie, kto wygrał
            if (rzutGracza == rzutKostka)
            {
                Console.WriteLine("Gratulacje! Wygrałeś!");
            }
            else
            {
                Console.WriteLine("Niestety, przegrałeś. Spróbuj ponownie!");
            }

            // Pytanie, czy gracz chce kontynuować
            Console.Write("Czy chcesz zagrać ponownie? (tak/nie): ");
            string odpowiedz = Console.ReadLine().ToLower();

            // Sprawdzenie odpowiedzi
            if (odpowiedz != "tak")
            {
                Console.WriteLine("Dziękujemy za grę! Do zobaczenia!");
                break; // Zakończenie gry
            }
        }
    }
}