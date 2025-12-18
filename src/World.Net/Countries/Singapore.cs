namespace World.Net.Countries;

internal sealed class Singapore : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Singapore;

    //<inheritdoc/>
    public string Name { get; } = "Singapore";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Singapore";

    //<inheritdoc/>
    public string NativeName => "Singapore";

    //<inheritdoc/>
    public string Capital { get; } = "Singapore";

    //<inheritdoc/>
    public int NumericCode { get; } = 702;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SG";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SGP";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+65"];

    //<inheritdoc/>
    public IEnumerable<State> States => [];
}

