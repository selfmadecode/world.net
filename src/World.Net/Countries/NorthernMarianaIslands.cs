namespace World.Net.Countries;

internal sealed class NorthernMarianaIslands : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.NorthernMarianaIslands;

    //<inheritdoc/>
    public string Name { get; } = "Northern Mariana Islands";

    //<inheritdoc/>
    public string OfficialName { get; } = "Commonwealth of the Northern Mariana Islands";

    //<inheritdoc/>
    public string NativeName => "Northern Mariana Islands";

    //<inheritdoc/>
    public string Capital { get; } = "Saipan";

    //<inheritdoc/>
    public int NumericCode { get; } = 580;

    //<inheritdoc/>
    public string ISO2Code { get; } = "MP";

    //<inheritdoc/>
    public string ISO3Code { get; } = "MNP";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+1-670"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Saipan", "MP-SA", "Municipality"),
        new("Tinian", "MP-TI", "Municipality"),
        new("Rota", "MP-RO", "Municipality"),
        new("Northern Islands", "MP-NI", "Municipality")
    ];
}
