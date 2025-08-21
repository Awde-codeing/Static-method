using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        // Statisk tæller til unikke ID'er og antal instanser
        private static int instanceCount = 0;

        // Felt til personens unikke ID
        private int ID;

        // Properties
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Adresse { get; set; }
        public string Postnr { get; set; }
        public string By { get; set; }

        // Konstruktor
        public Person(string fornavn, string efternavn, string adresse, string postnr, string by)
        {
            instanceCount++;
            ID = instanceCount;

            Fornavn = fornavn;
            Efternavn = efternavn;
            Adresse = adresse;
            Postnr = postnr;
            By = by;
        }

        // Instansmetode der skriver ID, navn og adresse pænt ud
        public void SkrivPersonInstans()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Navn: {Fornavn} {Efternavn}");
            Console.WriteLine($"Adresse: {Adresse}, {Postnr} {By}");
        }

        // Statisk metode der skriver ID, navn og totalt antal instanser
        public static void SkrivInstans(Person p)
        {
            Console.WriteLine($"ID: {p.ID}");
            Console.WriteLine($"Navn: {p.Fornavn} {p.Efternavn}");
            Console.WriteLine($"Total antal personer: {instanceCount}");
        }
    }
}
