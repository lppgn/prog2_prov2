using System;

namespace superheroAcademy
{
    public class Logia: Superhero
    {
        //Ska ha subklasser men en Logia user får krafter från ett visst material och din kropp blir det materialet. T.ex. om din kraft är vatten så är du vatten och kan kontrollera det
        //material är det materialet man får kraft från
        public string material = "";
        //konstruktor
        public Logia(string name, string material) : base(name)
        {
            //materialet som skrivs in blir hjältens kraft
            this.material = material;
            //power som passar klassen
            Power = 100;
            //samma med defense
            defense = 100;
            //samma med versatility
            versatility = 100;
            //lägg till i listan
            superheroes.Add(this);
        }
    }
}
