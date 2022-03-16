using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrzeugeOOP
{
    internal class Auto: Fahrzeug
    {
        public string Farbe { get; set; }
        public Auto(string farbe)
        {
            Farbe = farbe;    
        }
        //Da die Standard-Implementierung in der Fahrzeug-Klasse für das Auto nicht ausreichend war, wurde die Methode fahre in der Klasse Auto überschrieben bzw. verändert
//Wichtig: override (überschreiben) funktioniert nur dann, wenn die zu überschreibende Methode in der Oberklasse bzw. Basisklasse mit "virtual" gekennzeichnet wurde.
        public override void fahre()
        {
            // base.Aufsperren();
            if (!IstVersperrt)
            {
                Console.WriteLine($"Das {this.Farbe} Auto fährt.");
            }
            
           // this.Zusperren(); zuerst in der eigenen Klasse dann erst in Vererbung
            // base => Basisklasse, Oberklasse
           // base.fahre();
        }
        /*
        public override void Zusperren()
        {
            Console.WriteLine("In der Klasse Auto aufgerufen");
        }
        */
    }
}
