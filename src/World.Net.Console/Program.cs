// See https://aka.ms/new-console-template for more information
//PrintSeparator("All Countries");

//var countries = CountryProvider.GetAllCountries();
//foreach (var country in countries)
//{
//    Console.WriteLine($"Name: {country.Name,-20} | Capital: {country.Capital}");
//}

//Console.WriteLine();
PrintSeparator("Afghanistan");

try
{
    var afghanistan = CountryProvider.GetCountry(CountryIdentifier.Afghanistan);
    Console.WriteLine($"Official Name: {afghanistan.OfficialName}");
    Console.WriteLine($"Capital: {afghanistan.Capital}");

    foreach( var timeZone in afghanistan.TimeZones)
    {
        Console.WriteLine($"Time Zone: {timeZone}");
    }

    Console.WriteLine($"Currency Name: {afghanistan.Currency.Name}");
    Console.WriteLine($"Currency Code: {afghanistan.Currency.Code}");
    Console.WriteLine($"Currency Symbol: {afghanistan.Currency.Symbol}");

}
catch (CountryNotFoundException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

PrintSeparator("Selected Countries");
var indentifiers = new List<CountryIdentifier>
{
    CountryIdentifier.Afghanistan,
    CountryIdentifier.UnitedStates,
    CountryIdentifier.Ghana,
    CountryIdentifier.Nigeria
};

var selectedCountries = CountryProvider.GetCountries(indentifiers);
foreach (var country in selectedCountries)
{
    Console.WriteLine($"Name: {country.Name,-20} | Capital: {country.Capital}");
}

Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();


/// <summary>
/// Prints a formatted section separator in the console.
/// </summary>
/// <param name="title">The title to display in the separator.</param>
static void PrintSeparator(string title)
{
    Console.WriteLine(new string('-', 30));
    Console.WriteLine($"--- {title} ---");
    Console.WriteLine(new string('-', 30));
    Console.WriteLine();
}
