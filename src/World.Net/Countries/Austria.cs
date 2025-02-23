namespace World.Net.Countries;

internal sealed class Austria : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Austria;

    ///<inheritdoc/>
    public string Name => nameof(Austria);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Republic of Austria";

    ///<inheritdoc/>
    public string NativeName { get; } = "Österreich";

    ///<inheritdoc/>
    public string Capital { get; } = "Vienna";

    ///<inheritdoc/>
    public int NumericCode { get; } = 040;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AT";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "AUT";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+43";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Burgenland", "AT-1", "state"),
        new("Carinthia", "AT-2", "state"),
        new("Lower Austria", "AT-3", "state"),
        new("Salzburg", "AT-5", "state"),
        new("Styrian", "AT-6", "state"),
        new("Tyrol", "AT-7", "state"),
        new("Upper Austria", "AT-4", "state"),
        new("Vienna", "AT-9", "state"),
        new("Vorarlberg", "AT-8", "state"),
    ];
}
