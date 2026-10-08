namespace World.Net.Countries;

internal sealed class Kazakhstan : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Kazakhstan;

    ///<inheritdoc/>
    public string Name => "Kazakhstan";

    ///<inheritdoc/>
    public string OfficialName { get; } = "Republic of Kazakhstan";

    ///<inheritdoc/>
    public string NativeName { get; } = "Қазақстан";

    ///<inheritdoc/>
    public string Capital { get; } = "Astana";

    ///<inheritdoc/>
    public int NumericCode { get; } = 398;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "KZ";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "KAZ";

    ///<inheritdoc/>
    public string[] CallingCode { get; } = ["+7"];

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Abai", "KZ-10", "Region"),
        new("Akmola", "KZ-11", "Region"),
        new("Aktobe", "KZ-15", "Region"),
        new("Almaty", "KZ-19", "Region"),
        new("Atyrau", "KZ-23", "Region"),
        new("East Kazakhstan", "KZ-63", "Region"),
        new("Jambyl", "KZ-31", "Region"),
        new("Jetisu", "KZ-33", "Region"),
        new("Karaganda", "KZ-35", "Region"),
        new("Kostanay", "KZ-39", "Region"),
        new("Kyzylorda", "KZ-43", "Region"),
        new("Mangystau", "KZ-47", "Region"),
        new("Pavlodar", "KZ-55", "Region"),
        new("North Kazakhstan", "KZ-59", "Region"),
        new("Turkistan", "KZ-61", "Region"),
        new("Ulytau", "KZ-62", "Region"),
        new("West Kazakhstan", "KZ-27", "Region"),
        new("Astana", "KZ-71", "City"),
        new("Almaty City", "KZ-75", "City"),
        new("Shymkent", "KZ-79", "City")
    ];
}
