namespace World.Net.Countries;

internal sealed class NorthMacedonia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.NorthMacedonia;

    //<inheritdoc/>
    public string Name { get; } = "North Macedonia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of North Macedonia";

    //<inheritdoc/>
    public string NativeName => "Северна Македонија";

    //<inheritdoc/>
    public string Capital { get; } = "Skopje";

    //<inheritdoc/>
    public int NumericCode { get; } = 807;

    //<inheritdoc/>
    public string ISO2Code { get; } = "MK";

    //<inheritdoc/>
    public string ISO3Code { get; } = "MKD";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+389"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Eastern", "MK-01", "Region"),
        new("North Eastern", "MK-02", "Region"),
        new("Skopje", "MK-03", "Region"),
        new("Pelagonia", "MK-04", "Region"),
        new("Polog", "MK-05", "Region"),
        new("South Eastern", "MK-06", "Region"),
        new("South Western", "MK-07", "Region"),
        new("Vardar", "MK-08", "Region")
    ];
}

