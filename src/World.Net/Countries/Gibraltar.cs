namespace World.Net.Countries;

internal sealed class Gibraltar : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Gibraltar;

    //<inheritdoc/>
    public string Name { get; } = "Gibraltar";

    //<inheritdoc/>
    public string OfficialName { get; } = "Gibraltar";

    //<inheritdoc/>
    public string NativeName => "Gibraltar";

    //<inheritdoc/>
    public string Capital { get; } = "Gibraltar";

    //<inheritdoc/>
    public int NumericCode { get; } = 292;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GI";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GIB";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+350"];

    //<inheritdoc/>
    public IEnumerable<State> States => [];
}
