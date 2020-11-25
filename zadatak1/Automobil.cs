using System;
using System.Collections.Generic;
using System.Text;

namespace zadatak1
{
    class Automobil
    {
        private string proizvodjac;
        private string model;
        private double cena;
        private string boja;
        private int brzina;

        public Automobil()
        {
            proizvodjac = " ";
            model = " ";
            cena = 0;
            boja = " ";
            brzina = 0;
        }

        public Automobil(string pr, string md, double c, string b, int br)
        {
            proizvodjac = pr;
            model = md;
            cena = c;
            boja = b;
            brzina = br;
        }
        public void Ispisi()
        {
            Console.WriteLine("Proizvodjac automobila je : " + proizvodjac);
            Console.WriteLine("Model automobila je " + model);
            Console.WriteLine("Cena automobila je " + cena + " eura.");
            Console.WriteLine("Boja automobila je " + boja);
            Console.WriteLine("Brzina automobila je " + brzina + " km/h.");
        }

        public string Proizvodjac
        {
            get { return proizvodjac; } set { proizvodjac = value; }
        }
        public string Model
        {
            get { return model; } set { model = value; }
        }
        public double Cena
        {
            get { return cena; } set { cena = value; }
        }
        public string Boja
        {
            get { return boja; } set { boja = value; }
        }
        public int Brzina
        {
            get { return brzina; } set { brzina = value; }
        }
    }
}
