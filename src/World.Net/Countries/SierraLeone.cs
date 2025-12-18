namespace World.Net.Countries;

internal sealed class SierraLeone : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SierraLeone;

    //<inheritdoc/>
    public string Name { get; } = "Sierra Leone";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Sierra Leone";

    //<inheritdoc/>
    public string NativeName => "Sierra Leone";

    //<inheritdoc/>
    public string Capital { get; } = "Freetown";

    //<inheritdoc/>
    public int NumericCode { get; } = 694;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SL";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SLE";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+232"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Eastern Province", "SL-E", "Province"),
        new("Northern Province", "SL-N", "Province"),
        new("North Western Province", "SL-NW", "Province"),
        new("Southern Province", "SL-S", "Province"),
        new("Western Area", "SL-W", "Province")
    ];
}
