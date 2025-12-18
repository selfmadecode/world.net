namespace World.Net.Countries;

internal sealed class Pakistan : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Pakistan;

    //<inheritdoc/>
    public string Name { get; } = "Pakistan";

    //<inheritdoc/>
    public string OfficialName { get; } = "Islamic Republic of Pakistan";

    //<inheritdoc/>
    public string NativeName => "پاکستان";

    //<inheritdoc/>
    public string Capital { get; } = "Islamabad";

    //<inheritdoc/>
    public int NumericCode { get; } = 586;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PK";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PAK";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+92"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Balochistan", "PK-BA", "Province"),
        new("Khyber Pakhtunkhwa", "PK-KP", "Province"),
        new("Punjab", "PK-PB", "Province"),
        new("Sindh", "PK-SD", "Province"),
        new("Gilgit-Baltistan", "PK-GB", "Autonomous Territory"),
        new("Azad Jammu and Kashmir", "PK-AJ", "Autonomous Territory"),
        new("Islamabad Capital Territory", "PK-IS", "Federal Territory")
    ];
}

