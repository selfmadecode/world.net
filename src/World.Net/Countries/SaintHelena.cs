namespace World.Net.Countries;

internal sealed class SaintHelena : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SaintHelena;

    //<inheritdoc/>
    public string Name { get; } = "Saint Helena";

    //<inheritdoc/>
    public string OfficialName { get; } = "Saint Helena, Ascension and Tristan da Cunha";

    //<inheritdoc/>
    public string NativeName => "Saint Helena";

    //<inheritdoc/>
    public string Capital { get; } = "Jamestown";

    //<inheritdoc/>
    public int NumericCode { get; } = 654;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SH";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SHN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+290"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Saint Helena", "SH-HL", "District"),
        new("Ascension", "SH-AC", "District"),
        new("Tristan da Cunha", "SH-TR", "District")
    ];
}
