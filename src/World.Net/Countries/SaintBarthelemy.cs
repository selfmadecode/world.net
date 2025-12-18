namespace World.Net.Countries;

internal sealed class SaintBarthelemy : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SaintBarthelemy;

    //<inheritdoc/>
    public string Name { get; } = "Saint-Barthélemy";

    //<inheritdoc/>
    public string OfficialName { get; } = "Collectivity of Saint-Barthélemy";

    //<inheritdoc/>
    public string NativeName => "Saint-Barthélemy";

    //<inheritdoc/>
    public string Capital { get; } = "Gustavia";

    //<inheritdoc/>
    public int NumericCode { get; } = 652;

    //<inheritdoc/>
    public string ISO2Code { get; } = "BL";

    //<inheritdoc/>
    public string ISO3Code { get; } = "BLM";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+590"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Saint-Barthélemy", "BL-BL", "Territory")
    ];
}

