namespace World.Net.Countries;

internal sealed class Cyprus : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Cyprus;

    //<inheritdoc/>
    public string Name { get; } = "Cyprus";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Cyprus";

    //<inheritdoc/>
    public string NativeName => "Κύπρος";

    //<inheritdoc/>
    public string Capital { get; } = "Nicosia";

    //<inheritdoc/>
    public int NumericCode { get; } = 196;

    //<inheritdoc/>
    public string ISO2Code { get; } = "CY";

    //<inheritdoc/>
    public string ISO3Code { get; } = "CYP";

    //<inheritdoc/>
    public string CallingCode { get; } = "+357";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Famagusta", "CY-04", "District"),
        new("Kyrenia", "CY-06", "District"),
        new("Larnaca", "CY-03", "District"),
        new("Limassol", "CY-02", "District"),
        new("Nicosia", "CY-01", "District"),
        new("Paphos", "CY-05", "District")
    ];
}
