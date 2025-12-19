namespace World.Net.Countries;

internal sealed class SouthSudan : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SouthSudan;

    //<inheritdoc/>
    public string Name { get; } = "South Sudan";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of South Sudan";

    //<inheritdoc/>
    public string NativeName => "South Sudan";

    //<inheritdoc/>
    public string Capital { get; } = "Juba";

    //<inheritdoc/>
    public int NumericCode { get; } = 728;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SS";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SSD";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+211"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Central Equatoria", "SS-EC", "State"),
        new State("Eastern Equatoria", "SS-EE", "State"),
        new State("Jonglei", "SS-JG", "State"),
        new State("Lakes", "SS-LK", "State"),
        new State("Northern Bahr el Ghazal", "SS-BN", "State"),
        new State("Unity", "SS-UY", "State"),
        new State("Upper Nile", "SS-NU", "State"),
        new State("Warrap", "SS-WR", "State"),
        new State("Western Bahr el Ghazal", "SS-BW", "State"),
        new State("Western Equatoria", "SS-EW", "State")
    };
}

