var numberString = string.Empty;
do
{
    Console.Write("Ingrese número o presione 'Salir' para salir de la ejecución:");
    numberString = Console.ReadLine();


    if (numberString!.ToLower() == "salir")
    {
        continue;
    }
    var numberInt = 0;

    
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt} es par.");
        }
        else
        {
            Console.WriteLine($"El número {numberInt} es Impar.");
        }

    }
    else
    {
        Console.WriteLine($"El valor que digitaste {numberString}, no es un número entero.");
    }




} while (numberString!.ToLower() != "salir");
Console.WriteLine("Perfecto");
