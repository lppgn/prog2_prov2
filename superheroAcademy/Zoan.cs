using System;

namespace superheroAcademy
{
    public class Zoan: Superhero
    {
        //en subklass till superhero som är en hjälte vars kraft är att den kan få förmågorna eller transfomeras helt till ett djur
        //En string som säger vad för djur det är
        public string creature = "";
        //konstruktorn där man måste få in ett namn samt namnet på djuret som hjälten får kraft av
        public Zoan(string name, string creature) : base(name)
        {
            //djuret som tas in blir vad hjälten får krafter från
            this.creature = creature;
        }
    }
}
