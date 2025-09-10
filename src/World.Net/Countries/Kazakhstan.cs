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
    public string NativeName { get; } = "?????????";

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
        new("Akmola", "KZ-AKM", "Region"),
        new("Aktobe", "KZ-AKT", "Region"),
        new("Almaty", "KZ-ALM", "Region"),
        new("Atyrau", "KZ-ATY", "Region"),
        new("East Kazakhstan", "KZ-VOS", "Region"),
        new("Jambyl", "KZ-ZHA", "Region"),
        new("Karaganda", "KZ-KAR", "Region"),
        new("Kostanay", "KZ-KUS", "Region"),
        new("Kyzylorda", "KZ-KZY", "Region"),
        new("Mangystau", "KZ-MAN", "Region"),
        new("Pavlodar", "KZ-PAV", "Region"),
        new("North Kazakhstan", "KZ-SEV", "Region"),
        new("Turkistan", "KZ-TUR", "Region"),
        new("West Kazakhstan", "KZ-ZAP", "Region"),
        new("Nur-Sultan", "KZ-NUR", "City"),
        new("Almaty City", "KZ-ALA", "City"),
        new("Shymkent", "KZ-SHY", "City")
    ];
}
