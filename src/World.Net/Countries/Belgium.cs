namespace World.Net.Countries;

internal sealed class Belgium : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Belgium;

    ///<inheritdoc/>
    public string Name => nameof(Belgium);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Kingdom of Belgium";

    ///<inheritdoc/>
    public string NativeName { get; } = "België";

    ///<inheritdoc/>
    public string Capital { get; } = "Brussels";

    ///<inheritdoc/>
    public int NumericCode { get; } = 056;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "BE";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "BEL";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+32";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Antwerp", "VAN"),
        new("Brussels-Capital Region", "BRU", "Region"),
        new("East Flanders", "VOV"),
        new("Flemish Brabant", "VBR"),
        new("Flemish Region", "VLG", "Region"),
        new("Hainaut", "WHT"),
        new("Liège", "WLG"),
        new("Limburg", "VLI"),
        new("Luxembourg", "WLX"),
        new("Namur", "WNA"),
        new("Walloon Brabant", "WBR"),
        new("Walloon Region", "WAL", "Region"),
        new("West Flanders", "VWV")
    ];
}
