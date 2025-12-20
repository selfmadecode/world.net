namespace World.Net.Countries;

internal sealed class Malta : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Malta;

    public string Name { get; } = "Malta";

    public string OfficialName { get; } = "Republic of Malta";

    public string NativeName => "Malta";

    public string Capital { get; } = "Valletta";

    public int NumericCode { get; } = 470;

    public string ISO2Code { get; } = "MT";

    public string ISO3Code { get; } = "MLT";

    public string[] CallingCode { get; } = ["+356"];

    public IEnumerable<State> States => new[]
    {
        new State("Gozo", "MT-45", "Region"),
        new State("Northern Harbour", "MT-48", "Region"),
        new State("Northern", "MT-51", "Region"),
        new State("South Eastern", "MT-52", "Region"),
        new State("Southern Harbour", "MT-53", "Region"),
        new State("Western", "MT-55", "Region")
    };
}

