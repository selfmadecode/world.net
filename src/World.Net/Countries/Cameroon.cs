namespace World.Net.Countries;

internal sealed class Cameroon : ICountry
{
    //<inheritdoc/>
    public int Id => CountryIdentifier.Cameroon;

    //<inheritdoc/>
    public string Name { get; } = "Cameroon";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Cameroon";

    //<inheritdoc/>
    public string NativeName => "République du Cameroun";

    //<inheritdoc/>
    public string Capital { get; } = "Yaoundé";

    //<inheritdoc/>
    public int NumericCode { get; } = 120;

    //<inheritdoc/>
    public string ISO2Code { get; } = "CM";

    //<inheritdoc/>
    public string ISO3Code { get; } = "CMR";

    //<inheritdoc/>
    public string CallingCode { get; } = "+237";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Adamawa", "AD", "Region"),
        new("Centre", "CE", "Region"),
        new("East", "ES", "Region"),
        new("Far North", "FN", "Region"),
        new("Littoral", "LT", "Region"),
        new("North", "NO", "Region"),
        new("North West", "NW", "Region"),
        new("West", "OU", "Region"),
        new("South", "SU", "Region"),
        new("South West", "SW", "Region")
    ];
}
