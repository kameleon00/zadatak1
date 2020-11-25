using System;

namespace zadatak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil a1 = new Automobil();
            a1.Proizvodjac = "Ford";
            a1.Model = "Mustang";
            a1.Cena = 26670;
            a1.Boja = "Crvena";
            a1.Brzina = 260;
            Console.WriteLine("Podaci o pevom automobilu: ");
            a1.Ispisi();
            Console.WriteLine("===================================");
            Automobil a2 = new Automobil("Opel", "Insignia", 25000, "Crvena", 240);
            Console.WriteLine("Podaci o drugom automobilu: ");
            a2.Ispisi();

            Console.ReadLine();
        }
    }
}
