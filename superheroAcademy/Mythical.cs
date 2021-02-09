using System;

namespace superheroAcademy
{
    public class Mythical: Zoan
    {
        //likadant som ancient förutom att denna klass är lite starkare och innehåller djur som en drake som endast finns inom mytologi
        //konstruktor på Mythical zoan
        public Mythical(string name, string creature) : base(name,creature)
        {
            //ändrar på power till vad som passar denna klass
            Power = 100;
            //samma fast defense
            defense = 100;
            //samma på versatility
            versatility = 50;
            //lägger till i listan
            superheroes.Add(this);
        } 
    }
}
