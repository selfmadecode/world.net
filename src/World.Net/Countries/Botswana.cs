namespace World.Net.Countries;

internal sealed class Botswana : ICountry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.Botswana;

    ///<inheritdoc/>
    public string Name => nameof(Botswana);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Republic of Botswana";

    ///<inheritdoc/>
    public string NativeName { get; } = "Botswana";

    ///<inheritdoc/>
    public string Capital { get; } = "Gaborone";

    ///<inheritdoc/>
    public int NumericCode { get; } = 072;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "BW";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "BWA";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+267";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Central", "CE", "District"),
        new("Ghanzi", "GH", "District"),
        new("Kgalagadi", "KG", "District"),
        new("Kgatleng", "KL", "District"),
        new("Kweneng", "KW", "District"),
        new("Ngamiland", "NG", "City"),
        new("North-East", "NE", "District"),
        new("North-West", "NW", "District"),
        new("South-East", "SE", "District"),
        new("Southern", "SO", "District"),
    ];
}
