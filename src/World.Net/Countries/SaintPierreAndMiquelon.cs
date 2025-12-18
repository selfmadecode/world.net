namespace World.Net.Countries;

internal sealed class SaintPierreAndMiquelon : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SaintPierreAndMiquelon;

    //<inheritdoc/>
    public string Name { get; } = "Saint Pierre and Miquelon";

    //<inheritdoc/>
    public string OfficialName { get; } = "Saint Pierre and Miquelon";

    //<inheritdoc/>
    public string NativeName => "Saint Pierre and Miquelon";

    //<inheritdoc/>
    public string Capital { get; } = "Saint-Pierre";

    //<inheritdoc/>
    public int NumericCode { get; } = 666;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PM";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SPM";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+508"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Saint-Pierre", "PM-SP", "Commune"),
        new("Miquelon-Langlade", "PM-MQ", "Commune")
    ];
}

