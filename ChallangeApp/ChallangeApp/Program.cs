var name = "Mateusz";
bool sex = true; //sex = true -man; sex = false - woman
var age = 34;

//Komunikat Płeć poniżej/powyżej 30 lat

if (sex == true)
{
    if (age < 30)
    {
        Console.WriteLine("Mężczyzna poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Mężczyzna powyżej 30 lat");
    }
}
else
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }
}

//Komunikat imię + wiek

if (name == "Mateusz")
{
    Console.WriteLine(name + ", lat " + age);
}
else
{
    Console.WriteLine("Podano inne imię");
}


if (age < 18 && sex == true)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    if (sex == true)
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
    else if (age < 18)
    {
        Console.WriteLine("Niepełnoletnia kobieta");
    }
    else
    {
        Console.WriteLine("Pełnoletnia kobieta");
    }
}

