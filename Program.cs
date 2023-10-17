
#region task1

int counter = 0;
Console.WriteLine("ilk ededi daxil edin...");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("ikinci ededi daxil edin...");
int numB = int.Parse(Console.ReadLine());
int result = numA + numB;
string sresult = result.ToString();
foreach (var num in sresult)
{
    counter++;
}
if (counter == 2)
{
    Console.WriteLine("Cem 2 reqemlidir...");
}
else if (counter == 3)
{
    Console.WriteLine("Cem 3 reqemlidir...");
}
else
{
    Console.WriteLine("Nezere alinmayib");
}



#endregion

#region task 2

Console.WriteLine("Skafin olculerini yaz");
Console.Write("eni:");
int eni = int.Parse(Console.ReadLine());
Console.Write("hundurluyu:");
int hundurluk = int.Parse(Console.ReadLine());
Console.Write("uzunluq:");
int uzunluq = int.Parse(Console.ReadLine());

int e = 80;
int h = 250;

if ((eni <= e && hundurluk <= h) || (eni <= e && uzunluq <= h) || (uzunluq <= e && hundurluk <= h) || (uzunluq <= e && eni <= h)
    || (hundurluk <= e && uzunluq <= h) || (hundurluk <= e && eni <= h)
    )
{
    Console.WriteLine("skaf qapidan kececek");
}

else
{
    Console.WriteLine("skaf qapidan kecmeyecek");
}


#endregion


