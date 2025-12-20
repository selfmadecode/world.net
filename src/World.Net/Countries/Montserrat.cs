namespace World.Net.Countries;

internal sealed class Montserrat : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Montserrat;

    public string Name { get; } = "Montserrat";

    public string OfficialName { get; } = "Montserrat";

    public string NativeName => "Montserrat";

    public string Capital { get; } = "Plymouth";

    public int NumericCode { get; } = 500;

    public string ISO2Code { get; } = "MS";

    public string ISO3Code { get; } = "MSR";

    public string[] CallingCode { get; } = ["+1-664"];

    public IEnumerable<State> States => Array.Empty<State>();
}

