namespace World.Net.Countries;

internal sealed class Norway : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Norway;

    //<inheritdoc/>
    public string Name { get; } = "Norway";

    //<inheritdoc/>
    public string OfficialName { get; } = "Kingdom of Norway";

    //<inheritdoc/>
    public string NativeName => "Norge";

    //<inheritdoc/>
    public string Capital { get; } = "Oslo";

    //<inheritdoc/>
    public int NumericCode { get; } = 578;

    //<inheritdoc/>
    public string ISO2Code { get; } = "NO";

    //<inheritdoc/>
    public string ISO3Code { get; } = "NOR";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+47"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Agder", "NO-01", "County"),
        new("Innlandet", "NO-02", "County"),
        new("Møre og Romsdal", "NO-03", "County"),
        new("Nordland", "NO-04", "County"),
        new("Oslo", "NO-05", "County"),
        new("Rogaland", "NO-06", "County"),
        new("Troms og Finnmark", "NO-07", "County"),
        new("Trøndelag", "NO-08", "County"),
        new("Vestfold og Telemark", "NO-09", "County"),
        new("Vestland", "NO-10", "County"),
        new("Viken", "NO-11", "County")
    ];
}

