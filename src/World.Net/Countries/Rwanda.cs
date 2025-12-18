namespace World.Net.Countries;

internal sealed class Rwanda : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Rwanda;

    //<inheritdoc/>
    public string Name { get; } = "Rwanda";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Rwanda";

    //<inheritdoc/>
    public string NativeName => "Rwanda";

    //<inheritdoc/>
    public string Capital { get; } = "Kigali";

    //<inheritdoc/>
    public int NumericCode { get; } = 646;

    //<inheritdoc/>
    public string ISO2Code { get; } = "RW";

    //<inheritdoc/>
    public string ISO3Code { get; } = "RWA";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+250"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Kigali", "RW-KI", "Province"),
        new("Eastern", "RW-ES", "Province"),
        new("Northern", "RW-NO", "Province"),
        new("Western", "RW-WE", "Province"),
        new("Southern", "RW-SO", "Province")
    ];
}

