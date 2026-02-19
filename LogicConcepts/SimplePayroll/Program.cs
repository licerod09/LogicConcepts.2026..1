using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var name = ConsoleExtension.GetString("ingrese nombre ");
    var LastName = ConsoleExtension.GetString("ingrese apellido ");
    var H_Work = ConsoleExtension.GetFloat("ingrese las horas trabajadas ");
    var V_hour = ConsoleExtension.GetDecimal("ingrese el valor por hora ");
    var min_salary = ConsoleExtension.GetDecimal("ingrese el salario minimo legal vigente ");

    var salary = (decimal)H_Work * V_hour;   // se le pide al sistema que se convieta el valor de la operacion e decimal)

    if (min_salary >= salary)
    {
        Console.WriteLine($"nombre  .... :{name} {lastName}");
        Console.WriteLine($"salario .... :{salary:C2}");
    }
    else
    {
        Console.WriteLine($"nombre  .... :{name} {lastName}");
        Console.WriteLine($"salario .... :{min_salary:C2}");

    }
    // esto simpre es igual
    do
    {
        answer = ConsoleExtension.GetValidOptions("Desea continuar [S]i , [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));// validamos que la respuesta del usuario sea igual a alguna de las opciones que tenemos en la lista, el string comparison es para validar que no importe si el usuario escribe mayuscula o minuscula 

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("F mi loco");