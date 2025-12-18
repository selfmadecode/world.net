namespace World.Net.Countries;

internal sealed class Panama : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Panama;

    //<inheritdoc/>
    public string Name { get; } = "Panama";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Panama";

    //<inheritdoc/>
    public string NativeName => "República de Panamá";

    //<inheritdoc/>
    public string Capital { get; } = "Panama City";

    //<inheritdoc/>
    public int NumericCode { get; } = 591;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PA";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PAN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+507"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Bocas del Toro", "PA-1", "Province"),
        new("Chiriquí", "PA-4", "Province"),
        new("Coclé", "PA-2", "Province"),
        new("Colón", "PA-3", "Province"),
        new("Darién", "PA-5", "Province"),
        new("Herrera", "PA-6", "Province"),
        new("Los Santos", "PA-7", "Province"),
        new("Panamá", "PA-8", "Province"),
        new("Veraguas", "PA-9", "Province"),
        new("Panamá Oeste", "PA-10", "Province"),
        new("Kuna Yala", "PA-KY", "Indigenous Region"),
        new("Ngäbe-Buglé", "PA-NB", "Indigenous Region"),
        new("Emberá-Wounaan", "PA-EM", "Indigenous Region")
    ];
}
