namespace World.Net.Countries;

internal sealed class SvalbardAndJanMayen : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SvalbardAndJanMayenIslands;

    //<inheritdoc/>
    public string Name { get; } = "Svalbard and Jan Mayen";

    //<inheritdoc/>
    public string OfficialName { get; } = "Svalbard and Jan Mayen";

    //<inheritdoc/>
    public string NativeName => "Svalbard og Jan Mayen";

    //<inheritdoc/>
    public string Capital { get; } = "Longyearbyen";

    //<inheritdoc/>
    public int NumericCode { get; } = 744;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SJ";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SJM";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+47"];

    //<inheritdoc/>
    public IEnumerable<State> States => [];
}

