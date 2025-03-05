namespace World.Net.Countries;

internal sealed class CocosKeelingIslands : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.CocosKeelingIslands;

    //<inheritdoc/>
    public string Name { get; } = "Cocos (Keeling) Islands";

    //<inheritdoc/>
    public string OfficialName { get; } = "Territory of Cocos (Keeling) Islands";

    //<inheritdoc/>
    public string NativeName => "Pulu Kokos (Malay)";

    //<inheritdoc/>
    public string Capital { get; } = "West Island";

    //<inheritdoc/>
    public int NumericCode { get; } = 166;

    //<inheritdoc/>
    public string ISO2Code { get; } = "CC";

    //<inheritdoc/>
    public string ISO3Code { get; } = "CCK";

    //<inheritdoc/>
    public string CallingCode { get; } = "+61";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("West Island", "CC-WI", "Island"),
        new("Home Island", "CC-HI", "Island")
    ];
}
