using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrzeugeOOP
{
    internal class LKW : Fahrzeug
    {
        //Der LKW verfügt ebenfalls über eine Mehtode fahre, weil er diese von der Fahrzeug-Klasse erbt.
        //Verebt werden public-Members (Eigenschaften, Methoden),
        //internal und protected. private-Elemente werden Nicht vererbt.
    }
}
