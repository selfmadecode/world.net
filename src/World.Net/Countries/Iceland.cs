namespace World.Net.Countries;

internal sealed class Iceland : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Iceland;

    //<inheritdoc/>
    public string Name { get; } = "Iceland";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Iceland";

    //<inheritdoc/>
    public string NativeName => "Ísland";

    //<inheritdoc/>
    public string Capital { get; } = "Reykjavík";

    //<inheritdoc/>
    public int NumericCode { get; } = 352;

    //<inheritdoc/>
    public string ISO2Code { get; } = "IS";

    //<inheritdoc/>
    public string ISO3Code { get; } = "ISL";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+354"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Capital Region", "IS-1", "Region"),
        new("Southern Peninsula", "IS-2", "Region"),
        new("West", "IS-3", "Region"),
        new("Westfjords", "IS-4", "Region"),
        new("North", "IS-5", "Region"),
        new("Northwest", "IS-6", "Region"),
        new("East", "IS-7", "Region"),
        new("South", "IS-8", "Region")
    ];
}
