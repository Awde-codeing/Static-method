namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Opret personer
            Person p1 = new Person("Anna", "Hansen", "Vej 1", "1000", "København");
            Person p2 = new Person("Lars", "Olsen", "Vej 2", "8000", "Aarhus");

            // Kald instansmetoden
            p1.SkrivPersonInstans();
            p2.SkrivPersonInstans();

            // Kald statisk metode
            Person.SkrivInstans(p1);
            Person.SkrivInstans(p2);
        }
    }
}
