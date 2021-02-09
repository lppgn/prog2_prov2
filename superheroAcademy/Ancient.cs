using System;

namespace superheroAcademy
{
    public class Ancient: Zoan
    {
        //En subklass till Zoan som förklarar styrkan av djuret. Ancient är den näststarkaste kraften och kan innehålla djur som dinosaurier
        //En konstruktor som ändrar på power, defense och versatility beroende på vad för sista type det är på hjälten
        public Ancient(string zoanName, string zoanCreature) : base(zoanName, zoanCreature)
        {
            //ändrar på variabeln power till vad denna klass har för power
            Power = 80;
            //ändrar på defense
            defense = 80;
            //ändrar på versatility
            versatility = 30;
            //lägger till den i listan
            superheroes.Add(this);
        }
    }
}
