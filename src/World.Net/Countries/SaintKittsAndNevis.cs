namespace World.Net.Countries;

internal sealed class SaintKittsAndNevis : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SaintKittsAndNevis;

    //<inheritdoc/>
    public string Name { get; } = "Saint Kitts and Nevis";

    //<inheritdoc/>
    public string OfficialName { get; } = "Federation of Saint Kitts and Nevis";

    //<inheritdoc/>
    public string NativeName => "Saint Kitts and Nevis";

    //<inheritdoc/>
    public string Capital { get; } = "Basseterre";

    //<inheritdoc/>
    public int NumericCode { get; } = 659;

    //<inheritdoc/>
    public string ISO2Code { get; } = "KN";

    //<inheritdoc/>
    public string ISO3Code { get; } = "KNA";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+1-869"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Saint Kitts", "KN-K", "Island"),
        new("Nevis", "KN-N", "Island")
    ];
}

