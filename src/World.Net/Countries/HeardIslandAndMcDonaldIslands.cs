namespace World.Net.Countries;

internal sealed class HeardIslandAndMcDonaldIslands : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.HeardIslandAndMcDonaldIslands;

    //<inheritdoc/>
    public string Name { get; } = "Heard Island and McDonald Islands";

    //<inheritdoc/>
    public string OfficialName { get; } = "Heard Island and McDonald Islands";

    //<inheritdoc/>
    public string NativeName => "Heard Island and McDonald Islands";

    //<inheritdoc/>
    public string Capital { get; } = "Atlas Cove";

    //<inheritdoc/>
    public int NumericCode { get; } = 334;

    //<inheritdoc/>
    public string ISO2Code { get; } = "HM";

    //<inheritdoc/>
    public string ISO3Code { get; } = "HMD";

    //<inheritdoc/>
    public string[] CallingCode { get; } = []; // No population, no calling code

    //<inheritdoc/>
    public IEnumerable<State> States => [];
}
