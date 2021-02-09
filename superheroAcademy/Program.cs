using System;

namespace superheroAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Mythical ancientZoanType = new Mythical("Kaido", "Dragon");
            System.Console.WriteLine(ancientZoanType.heroName);
            Console.ReadLine();
        }
    }
}
