namespace World.Net.Countries;

internal sealed class Turkmenistan : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Turkmenistan;

    public string Name { get; } = "Turkmenistan";

    public string OfficialName { get; } = "Turkmenistan";

    public string NativeName => "Türkmenistan";

    public string Capital { get; } = "Ashgabat";

    public int NumericCode { get; } = 795;

    public string ISO2Code { get; } = "TM";

    public string ISO3Code { get; } = "TKM";

    public string[] CallingCode { get; } = ["+993"];

    public IEnumerable<State> States => new[]
    {
        new State("Ahal", "TM-A", "Region"),
        new State("Balkan", "TM-B", "Region"),
        new State("Dashoguz", "TM-D", "Region"),
        new State("Lebap", "TM-L", "Region"),
        new State("Mary", "TM-M", "Region"),
        new State("Ashgabat", "TM-AŞ", "Capital City")
    };
}

