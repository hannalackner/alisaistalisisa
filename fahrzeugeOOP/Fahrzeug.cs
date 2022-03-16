namespace fahrzeugeOOP
{
    internal class Fahrzeug
    {
        public virtual void fahre()
        {
            this.Aufsperren();
            Console.WriteLine("Das Fahrzeug fährt.");
            this.Zusperren();
        }
        public bool IstVersperrt { get; set; } = true;
        public virtual void Zusperren()
        {
            Console.WriteLine("Das Fahrzeug wird zugesperrt");
            IstVersperrt = true;
        }

        public void Aufsperren()
        {
            Console.WriteLine("Das Fahrzeug ist aufgesperrt");
            IstVersperrt = false;
        }

        
    }
}