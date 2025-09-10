namespace World.Net.Countries;
internal sealed class Jamaica : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Jamaica;

    //<inheritdoc/>
    public string Name { get; } = "Jamaica";

    //<inheritdoc/>
    public string OfficialName { get; } = "Jamaica";

    //<inheritdoc/>
    public string NativeName => "Jamaica";

    //<inheritdoc/>
    public string Capital { get; } = "Kingston";

    //<inheritdoc/>
    public int NumericCode { get; } = 388;

    //<inheritdoc/>
    public string ISO2Code { get; } = "JM";

    //<inheritdoc/>
    public string ISO3Code { get; } = "JAM";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+1-876"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Clarendon", "JM-13", "Parish"),
        new("Hanover", "JM-09", "Parish"),
        new("Kingston", "JM-01", "Parish"),
        new("Manchester", "JM-12", "Parish"),
        new("Portland", "JM-04", "Parish"),
        new("Saint Andrew", "JM-02", "Parish"),
        new("Saint Ann", "JM-06", "Parish"),
        new("Saint Catherine", "JM-14", "Parish"),
        new("Saint Elizabeth", "JM-11", "Parish"),
        new("Saint James", "JM-08", "Parish"),
        new("Saint Mary", "JM-05", "Parish"),
        new("Saint Thomas", "JM-03", "Parish"),
        new("Trelawny", "JM-07", "Parish"),
        new("Westmoreland", "JM-10", "Parish"),
    ];
}
