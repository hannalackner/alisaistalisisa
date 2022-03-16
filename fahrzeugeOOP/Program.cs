// See https://aka.ms/new-console-template for more information
using fahrzeugeOOP;

Auto a1 = new Auto("grüne");
a1.fahre();

LKW lkw1 = new LKW();
lkw1.fahre(); //hierbei handelt es sich um die geerbte Methode "fahre"

//Der LKW ist ein Fahrzeug
Fahrzeug lkw2 = new LKW(); //string bezeichner = "Test";
lkw2.fahre();

Console.WriteLine();
Auto a2 = new Auto("rote");
a2.Aufsperren();
a2.fahre();
a2.Zusperren();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Cabrio");
Cabrio c1 = new Cabrio("grüne");
c1.fahre();
c1.ToggleDach();



