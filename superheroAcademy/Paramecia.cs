using System;

namespace superheroAcademy
{
    public class Paramecia :Superhero
    {
        //den ska ha subklasser men han inte så det finns endast paramecia vilket är att du får krafter från ett objekt eller ett item. t.ex. en bil
        //en string som förklarar vad för item du får kraft av som superhjälte av paramecia sort
        public string Item = "";
        //konstruktor för en paramecia user
        public Paramecia(string name, string Item) : base(name)
        {
            //itemet som du skriver in blir itemet hjälten har kraft från
            this.Item = Item;
            //power som är passande för klassen
            Power = 70;
            //samma för defence
            defense = 50;
            //samma för versatility
            versatility = 40;
            //lägger till den i listan
            superheroes.Add(this);
        }
    }
}
