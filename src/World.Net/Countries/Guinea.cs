namespace World.Net.Countries;

internal sealed class Guinea : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Guinea;

    //<inheritdoc/>
    public string Name { get; } = "Guinea";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Guinea";

    //<inheritdoc/>
    public string NativeName => "Guinée";

    //<inheritdoc/>
    public string Capital { get; } = "Conakry";

    //<inheritdoc/>
    public int NumericCode { get; } = 324;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GN";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GIN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+224"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Boké", "GN-B", "Region"),
        new("Conakry", "GN-C", "Region"),
        new("Faranah", "GN-F", "Region"),
        new("Kankan", "GN-K", "Region"),
        new("Kindia", "GN-D", "Region"),
        new("Labé", "GN-L", "Region"),
        new("Mamou", "GN-M", "Region"),
        new("Nzérékoré", "GN-N", "Region")
    ];
}
