namespace World.Net.Countries;

internal sealed class Mayotte : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Mayotte;

    public string Name { get; } = "Mayotte";

    public string OfficialName { get; } = "Department of Mayotte";

    public string NativeName => "Mayotte";

    public string Capital { get; } = "Mamoudzou";

    public int NumericCode { get; } = 175;

    public string ISO2Code { get; } = "YT";

    public string ISO3Code { get; } = "MYT";

    public string[] CallingCode { get; } = ["+262"];

    public IEnumerable<State> States => Array.Empty<State>();
}

