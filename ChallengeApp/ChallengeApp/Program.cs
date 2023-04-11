var name = "Michał";
var isMale = true;
var age = 23;
//(1)
if (isMale && age < 30)
{
    Console.WriteLine("Mężczyzna poniżej 30 lat");
    //(2)
    if (isMale && name == "Michał" && age == 23)
    {
        Console.WriteLine("Michał, lat 23");
    }
}
//(3)
else if (!isMale && age < 18)
{
    Console.WriteLine("Niepełnoletnia kobieta");
}