namespace World.Net.Countries;

internal sealed class Slovenia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Slovenia;

    //<inheritdoc/>
    public string Name { get; } = "Slovenia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Slovenia";

    //<inheritdoc/>
    public string NativeName => "Slovenija";

    //<inheritdoc/>
    public string Capital { get; } = "Ljubljana";

    //<inheritdoc/>
    public int NumericCode { get; } = 705;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SI";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SVN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+386"];

    //<inheritdoc/>
    public IEnumerable<State> States => [];
}
