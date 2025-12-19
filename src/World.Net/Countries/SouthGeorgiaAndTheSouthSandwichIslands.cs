namespace World.Net.Countries;

internal sealed class SouthGeorgiaAndTheSouthSandwichIslands : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SouthGeorgia;

    //<inheritdoc/>
    public string Name { get; } = "South Georgia and the South Sandwich Islands";

    //<inheritdoc/>
    public string OfficialName { get; } = "South Georgia and the South Sandwich Islands";

    //<inheritdoc/>
    public string NativeName => "South Georgia and the South Sandwich Islands";

    //<inheritdoc/>
    public string Capital { get; } = "King Edward Point";

    //<inheritdoc/>
    public int NumericCode { get; } = 239;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GS";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SGS";

    //<inheritdoc/>
    public string[] CallingCode { get; } = [];

    //<inheritdoc/>
    public IEnumerable<State> States => [];
}
