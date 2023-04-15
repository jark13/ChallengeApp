string name = "Ewa";
bool kobieta = true;
int age = 33;

string message1 = "Kobieta poniżej 30 lat";
string message2 = "Ewa, lat 33";
string message3 = "Niepełnoletni męzczyzna";



if ((age < 30) & (kobieta))
{
    Console.WriteLine(message1);
}
else
{
    if ((name == "Ewa") && (age == 33))
    {
        Console.WriteLine(message2);
    }
    else
    {
        Console.WriteLine(message3);
    }
}
