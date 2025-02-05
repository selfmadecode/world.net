namespace World.Net.Countries;

internal sealed class Belgium : ICountry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.Belgium;

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
        new("Brussels-Capital Region", "BE-BRU", "Region"),
        new("Flemish Region", "BE-VLG", "Region"),
        new("Walloon Region", "BE-WAL", "Region"),
    
        new("Antwerp", "BE-VAN"),
        new("Flemish Brabant", "BE-VBR"),
        new("West Flanders", "BE-VWV"),
        new("East Flanders", "BE-VOV"),
        new("Limburg", "BE-VLI"),

        new("Walloon Brabant", "BE-WBR"),
        new("Hainaut", "BE-WHT"),
        new("Liège", "BE-WLG"),
        new("Luxembourg", "BE-WLX"),
        new("Namur", "BE-WNA"),
    ];
}
