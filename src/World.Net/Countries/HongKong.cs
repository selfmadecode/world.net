namespace World.Net.Countries;

internal sealed class HongKong : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.HongKongSAR;

    //<inheritdoc/>
    public string Name { get; } = "Hong Kong";

    //<inheritdoc/>
    public string OfficialName { get; } = "Hong Kong Special Administrative Region of China";

    //<inheritdoc/>
    public string NativeName => "香港";

    //<inheritdoc/>
    public string Capital { get; } = "Hong Kong";

    //<inheritdoc/>
    public int NumericCode { get; } = 344;

    //<inheritdoc/>
    public string ISO2Code { get; } = "HK";

    //<inheritdoc/>
    public string ISO3Code { get; } = "HKG";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+852"];

    //<inheritdoc/>
    public IEnumerable<State> States => []; // No subdivisions
}
