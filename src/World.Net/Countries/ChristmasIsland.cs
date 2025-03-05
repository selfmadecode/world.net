namespace World.Net.Countries;

internal sealed class ChristmasIsland : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.ChristmasIsland;

    //<inheritdoc/>
    public string Name { get; } = "Christmas Island";

    //<inheritdoc/>
    public string OfficialName { get; } = "Territory of Christmas Island";

    //<inheritdoc/>
    public string NativeName => "Christmas Island";

    //<inheritdoc/>
    public string Capital { get; } = "Flying Fish Cove";

    //<inheritdoc/>
    public int NumericCode { get; } = 162;

    //<inheritdoc/>
    public string ISO2Code { get; } = "CX";

    //<inheritdoc/>
    public string ISO3Code { get; } = "CXR";

    //<inheritdoc/>
    public string CallingCode { get; } = "+61";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        
    ];
}
