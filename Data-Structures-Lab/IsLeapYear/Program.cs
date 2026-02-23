using Shared;

do
{
    var currrentYear = DateTime.Now.Year;
    var message = string.Empty;
    var year = ConsoleExtension.GetInt("Ingrese el año : ");

    if (year == currrentYear)
    {
        message = "es";
    }   else if (year > currrentYear)
    { 
        message = "va a ser";
    }
    else
    {
        message = "fue";
    }


    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                Console.WriteLine($"El año: {year}, SI {message} bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año: {year}, NO {message} bisiesto.");
            }

        }
        else
        {
        Console.WriteLine($"El año: {year}, SI {message} bisiesto.");
        }
    }
    else
    {
        Console.WriteLine($"El año: {year},No {message} bisiesto.");
    }
} while (true);
