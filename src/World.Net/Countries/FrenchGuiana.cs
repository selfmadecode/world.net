namespace World.Net.Countries;
internal sealed class FrenchGuiana : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.FrenchGuiana;

    //<inheritdoc/>
    public string Name { get; } = "French Guiana";

    //<inheritdoc/>
    public string OfficialName { get; } = "Guyane française";

    //<inheritdoc/>
    public string NativeName => "Guyane française";

    //<inheritdoc/>
    public string Capital { get; } = "Cayenne";

    //<inheritdoc/>
    public int NumericCode { get; } = 254;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GF";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GUF";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+594"];

    //<inheritdoc/>
    public IEnumerable<State> States => [];
}
