namespace World.Net.Countries;

internal sealed class SaintVincentAndTheGrenadines : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SaintVincentAndTheGrenadines;

    //<inheritdoc/>
    public string Name { get; } = "Saint Vincent and the Grenadines";

    //<inheritdoc/>
    public string OfficialName { get; } = "Saint Vincent and the Grenadines";

    //<inheritdoc/>
    public string NativeName => "Saint Vincent and the Grenadines";

    //<inheritdoc/>
    public string Capital { get; } = "Kingstown";

    //<inheritdoc/>
    public int NumericCode { get; } = 670;

    //<inheritdoc/>
    public string ISO2Code { get; } = "VC";

    //<inheritdoc/>
    public string ISO3Code { get; } = "VCT";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+1-784"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Charlotte", "VC-C", "Parish"),
        new("Saint Andrew", "VC-A", "Parish"),
        new("Saint David", "VC-D", "Parish"),
        new("Saint George", "VC-G", "Parish"),
        new("Saint Patrick", "VC-P", "Parish"),
        new("Grenadines", "VC-VG", "Parish")
    ];
}
