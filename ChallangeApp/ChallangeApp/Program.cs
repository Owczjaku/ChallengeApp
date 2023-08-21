
var name = "Ewa";
var gender = "Kobieta";
var age = 27;

if (gender == "Kobieta" && age <= 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender != "Kobieta" && age < 18)
{
    Console.WriteLine("Niepelnoletni Mezczyzna");
}

else
{
    Console.WriteLine("Ktos zupełnie inny");

}