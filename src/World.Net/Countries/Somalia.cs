namespace World.Net.Countries;

internal sealed class Somalia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Somalia;

    //<inheritdoc/>
    public string Name { get; } = "Somalia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Federal Republic of Somalia";

    //<inheritdoc/>
    public string NativeName => "Soomaaliya";

    //<inheritdoc/>
    public string Capital { get; } = "Mogadishu";

    //<inheritdoc/>
    public int NumericCode { get; } = 706;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SO";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SOM";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+252"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Awdal", "SO-AW", "Region"),
        new State("Bakool", "SO-BK", "Region"),
        new State("Banaadir", "SO-BN", "Region"),
        new State("Bari", "SO-BR", "Region"),
        new State("Bay", "SO-BY", "Region"),
        new State("Galguduud", "SO-GA", "Region"),
        new State("Gedo", "SO-GE", "Region"),
        new State("Hiran", "SO-HI", "Region"),
        new State("Lower Juba", "SO-JH", "Region"),
        new State("Middle Juba", "SO-JD", "Region"),
        new State("Mudug", "SO-MU", "Region"),
        new State("Nugal", "SO-NU", "Region"),
        new State("Sanaag", "SO-SA", "Region"),
        new State("Middle Shabelle", "SO-SD", "Region"),
        new State("Lower Shabelle", "SO-SH", "Region"),
        new State("Sool", "SO-SO", "Region"),
        new State("Togdheer", "SO-TO", "Region"),
        new State("Woqooyi Galbeed", "SO-WO", "Region")
    };
}

