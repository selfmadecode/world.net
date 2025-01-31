namespace World.Net.Countries;

internal sealed class Belarus : ICountry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.Belarus;

    ///<inheritdoc/>
    public string Name => nameof(Belarus);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Republic of Belarus";

    ///<inheritdoc/>
    public string NativeName { get; } = "Беларусь";

    ///<inheritdoc/>
    public string Capital { get; } = "Minsk";

    ///<inheritdoc/>
    public int NumericCode { get; } = 112;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "BY";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "BLR";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+375";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Brest", "BY-BR", "Region"),
        new("Gomel", "BY-HO", "Region"),
        new("Grodno", "BY-HR", "Region"),
        new("Minsk", "BY-MI", "Region"),
        new("Mogilev", "BY-MA", "Region"),
        new("Vitebsk", "BY-VI", "Region"),
        new("Minsk City", "BY-MN", "City")
    ];
}
