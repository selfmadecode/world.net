namespace World.Net.Countries;

internal sealed class GuineaBissau : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.GuineaBissau;

    //<inheritdoc/>
    public string Name { get; } = "Guinea-Bissau";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Guinea-Bissau";

    //<inheritdoc/>
    public string NativeName => "Guiné-Bissau";

    //<inheritdoc/>
    public string Capital { get; } = "Bissau";

    //<inheritdoc/>
    public int NumericCode { get; } = 624;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GW";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GNB";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+245"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Bafatá", "GW-BFA", "Region"),
        new("Biombo", "GW-BIB", "Region"),
        new("Bissau", "GW-BS", "Region"), // autonomous sector
        new("Bolama", "GW-BM", "Region"),
        new("Cacheu", "GW-CA", "Region"),
        new("Gabu", "GW-GA", "Region"),
        new("Oio", "GW-OI", "Region"),
        new("Quinara", "GW-QU", "Region"),
        new("Tombali", "GW-TO", "Region")
    ];
}
