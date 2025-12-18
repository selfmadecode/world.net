namespace World.Net.Countries;

internal sealed class SaintMartin : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SaintMartinFrenchPart;

    //<inheritdoc/>
    public string Name { get; } = "Saint-Martin";

    //<inheritdoc/>
    public string OfficialName { get; } = "Collectivity of Saint-Martin";

    //<inheritdoc/>
    public string NativeName => "Saint-Martin";

    //<inheritdoc/>
    public string Capital { get; } = "Marigot";

    //<inheritdoc/>
    public int NumericCode { get; } = 663;

    //<inheritdoc/>
    public string ISO2Code { get; } = "MF";

    //<inheritdoc/>
    public string ISO3Code { get; } = "MAF";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+590"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Saint-Martin", "MF-MF", "Territory")
    ];
}

