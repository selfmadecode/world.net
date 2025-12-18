namespace World.Net.Countries;

internal sealed class Samoa : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Samoa;

    //<inheritdoc/>
    public string Name { get; } = "Samoa";

    //<inheritdoc/>
    public string OfficialName { get; } = "Independent State of Samoa";

    //<inheritdoc/>
    public string NativeName => "Sāmoa";

    //<inheritdoc/>
    public string Capital { get; } = "Apia";

    //<inheritdoc/>
    public int NumericCode { get; } = 882;

    //<inheritdoc/>
    public string ISO2Code { get; } = "WS";

    //<inheritdoc/>
    public string ISO3Code { get; } = "WSM";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+685"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("A'ana", "WS-AA", "District"),
        new("Aiga-i-le-Tai", "WS-AL", "District"),
        new("Atua", "WS-AT", "District"),
        new("Fa'asaleleaga", "WS-FS", "District"),
        new("Gaga'emauga", "WS-GE", "District"),
        new("Gaga'ifomauga", "WS-GF", "District"),
        new("Palauli", "WS-PA", "District"),
        new("Satupa'itea", "WS-SA", "District"),
        new("Tuamasaga", "WS-TU", "District"),
        new("Va'a-o-Fonoti", "WS-VF", "District"),
        new("Vaisigano", "WS-VS", "District")
    ];
}
