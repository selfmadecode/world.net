namespace World.Net.Countries;

internal sealed class Guam : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Guam;

    //<inheritdoc/>
    public string Name { get; } = "Guam";

    //<inheritdoc/>
    public string OfficialName { get; } = "Guam";

    //<inheritdoc/>
    public string NativeName => "Guam";

    //<inheritdoc/>
    public string Capital { get; } = "Hagåtña";

    //<inheritdoc/>
    public int NumericCode { get; } = 316;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GU";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GUM";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+1-671"];

    //<inheritdoc/>
    public IEnumerable<State> States => [];
}
