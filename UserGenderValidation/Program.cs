// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (mees või naine)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [Kasutaja perekonnanimi] / "Welcome, Ms. [Kasutaja perekonnanimi]

Console.WriteLine("Please, select your gender(m/f):");

char userGender = char.Parse(Console.ReadLine()); //Loeb konsoolist andmeid string(sõne) formaadis

Console.WriteLine("Please, enter your last name):");

String UserLastName = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {UserLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {UserLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {UserLastName}!");
}