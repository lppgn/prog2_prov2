using System;
using System.Collections.Generic;
namespace superheroAcademy
{
    public class Superhero
    {
        //min main klass som innehåller grundläggande stats
        //power är ett int tal som förklarar hur stark superhjälten är 
        public int Power = 0;
        //Versatility säger hur användbar kraften är i olika situationer
        public int versatility = 0;
        //Defense säger hur bra den är på försvar
        public int defense = 0;
        //Namnet på hjälten
        public string heroName = "";
        //en lista som håller koll på alla skapade hjältar
        public static List<Superhero> superheroes = new List<Superhero>();
        //Min konstruktor till Superhero där den säger åt dig att du måste skriva in vad för namn hjälten har
        public Superhero(string heroName)
        {
            //jag säger att namnet som skrivs in blir namnet av superhjälten som bildas
            this.heroName = heroName;
        }
    }
}
