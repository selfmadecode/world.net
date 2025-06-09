namespace World.Net.Countries;
internal sealed class Israel : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Israel;

    //<inheritdoc/>
    public string Name { get; } = "Israel";

    //<inheritdoc/>
    public string OfficialName { get; } = "State of Israel";

    //<inheritdoc/>
    public string NativeName => "יִשְׂרָאֵל";

    //<inheritdoc/>
    public string Capital { get; } = "Jerusalem";

    //<inheritdoc/>
    public int NumericCode { get; } = 376;

    //<inheritdoc/>
    public string ISO2Code { get; } = "IL";

    //<inheritdoc/>
    public string ISO3Code { get; } = "ISR";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+972"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Central", "IL-M", "District"),
        new("Haifa", "IL-HA", "District"),
        new("Jerusalem", "IL-JM", "District"),
        new("Northern", "IL-Z", "District"),
        new("Southern", "IL-D", "District"),
        new("Tel Aviv", "IL-TA", "District")
    ];
}
