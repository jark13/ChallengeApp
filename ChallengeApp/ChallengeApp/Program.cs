int number = 4566;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }
}

Console.Write("Wyniki dla liczby: ");
Console.WriteLine(numberAsString);

Console.Write("0 => ");
Console.WriteLine(counter0);
Console.Write("1 => ");
Console.WriteLine(counter1);
Console.Write("2 => ");
Console.WriteLine(counter2);
Console.Write("3 => ");
Console.WriteLine(counter3);
Console.Write("4 => ");
Console.WriteLine(counter4);
Console.Write("5 => ");
Console.WriteLine(counter5);
Console.Write("6 => ");
Console.WriteLine(counter6);
Console.Write("7 => ");
Console.WriteLine(counter7);
Console.Write("8 => ");
Console.WriteLine(counter8);
Console.Write("9 => ");
Console.WriteLine(counter9);


//Console.WriteLine("Wyniki dla liczby numberAsString", numberAsString);