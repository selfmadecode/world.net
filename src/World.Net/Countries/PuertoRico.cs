namespace World.Net.Countries;

internal sealed class PuertoRico : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.PuertoRico;

    //<inheritdoc/>
    public string Name { get; } = "Puerto Rico";

    //<inheritdoc/>
    public string OfficialName { get; } = "Commonwealth of Puerto Rico";

    //<inheritdoc/>
    public string NativeName => "Puerto Rico";

    //<inheritdoc/>
    public string Capital { get; } = "San Juan";

    //<inheritdoc/>
    public int NumericCode { get; } = 630;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PR";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PRI";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+1-787", "+1-939"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Puerto Rico", "PR-PR", "Territory")
    ];
}

