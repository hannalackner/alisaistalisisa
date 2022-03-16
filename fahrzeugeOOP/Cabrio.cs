using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrzeugeOOP
{
    internal class Cabrio : Auto
    {

        public bool IstOffen { get; set; } = false;
        public Cabrio(string farbe) : base(farbe)
        {

        }

        public void ToggleDach()
        {
            if (IstOffen)
            {
                DachZu();
            }
            else
            {
                DachAuf();
            }
        }
        private void DachAuf()
        {
            Console.WriteLine("Das Cabrio öffnet das Dach.");
            IstOffen = true;
        }
        private void DachZu()
        {
            Console.WriteLine("Das Cabrio schließt das Dach.");
            IstOffen = false;
        }
    }
}
