namespace World.Net.Countries;

internal sealed class CzechRepublic : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.CzechRepublic;

    //<inheritdoc/>
    public string Name { get; } = "Czech Republic";

    //<inheritdoc/>
    public string OfficialName { get; } = "Czech Republic";

    //<inheritdoc/>
    public string NativeName => "Česká republika";

    //<inheritdoc/>
    public string Capital { get; } = "Prague";

    //<inheritdoc/>
    public int NumericCode { get; } = 203;

    //<inheritdoc/>
    public string ISO2Code { get; } = "CZ";

    //<inheritdoc/>
    public string ISO3Code { get; } = "CZE";

    //<inheritdoc/>
    public string CallingCode { get; } = "+420";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Central Bohemian", "CZ-20", "Region"),
        new("Hradec Králové", "CZ-52", "Region"),
        new("Karlovy Vary", "CZ-41", "Region"),
        new("Liberec", "CZ-51", "Region"),
        new("Moravian-Silesian", "CZ-80", "Region"),
        new("Olomouc", "CZ-71", "Region"),
        new("Pardubice", "CZ-53", "Region"),
        new("Plzeň", "CZ-32", "Region"),
        new("Prague", "CZ-10", "Capital City"),
        new("South Bohemian", "CZ-31", "Region"),
        new("South Moravian", "CZ-64", "Region"),
        new("Ústí nad Labem", "CZ-42", "Region"),
        new("Vysočina", "CZ-63", "Region"),
        new("Zlín", "CZ-72", "Region")
    ];
}
