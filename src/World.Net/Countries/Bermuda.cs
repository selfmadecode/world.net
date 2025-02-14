namespace World.Net.Countries;

internal sealed class Bermuda : ICountry
{
    //<inheritdoc/>
    public int Id => CountryIdentifier.Bermuda;

    //<inheritdoc/>
    public string Name => "Bermuda";

    //<inheritdoc/>
    public string OfficialName => "Bermuda";

    //<inheritdoc/>
    public string NativeName => "Bermuda";

    //<inheritdoc/>
    public string Capital { get; } = "Hamilton";

    //<inheritdoc/>
    public int NumericCode { get; } = 060;

    //<inheritdoc/>
    public string ISO2Code { get; } = "BM";

    //<inheritdoc/>
    public string ISO3Code { get; } = "BMU";

    //<inheritdoc/>
    public string CallingCode { get; } = "+1441";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Devonshire", "DEV", "Municipality"),
        new("Hamilton", "HA", "Municipality"),
        new("Paget", "PAG", "Municipality"),
        new("Pembroke", "PEM", "Municipality"),
        new("Saint George's", "SGE", "Municipality"),
        new("Sandys", "SAN", "Municipality"),
        new("Smith's", "SMI", "Municipality"),
        new("Southampton", "SOU", "Municipality"),
        new("Warwick", "WAR", "Municipality")
    ];
}
