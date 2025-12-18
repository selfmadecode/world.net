namespace World.Net.Countries;

internal sealed class Haiti : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Haiti;

    //<inheritdoc/>
    public string Name { get; } = "Haiti";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Haiti";

    //<inheritdoc/>
    public string NativeName => "Haïti";

    //<inheritdoc/>
    public string Capital { get; } = "Port-au-Prince";

    //<inheritdoc/>
    public int NumericCode { get; } = 332;

    //<inheritdoc/>
    public string ISO2Code { get; } = "HT";

    //<inheritdoc/>
    public string ISO3Code { get; } = "HTI";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+509"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Artibonite", "HT-AR", "Department"),
        new("Centre", "HT-CE", "Department"),
        new("Grand'Anse", "HT-GA", "Department"),
        new("Nippes", "HT-NI", "Department"),
        new("Nord", "HT-NO", "Department"),
        new("Nord-Est", "HT-NE", "Department"),
        new("Nord-Ouest", "HT-NW", "Department"),
        new("Ouest", "HT-OU", "Department"),
        new("Sud", "HT-SD", "Department"),
        new("Sud-Est", "HT-SE", "Department")
    ];
}

