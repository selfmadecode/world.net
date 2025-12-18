namespace World.Net.Countries;

internal sealed class Guadeloupe : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Guadeloupe;

    //<inheritdoc/>
    public string Name { get; } = "Guadeloupe";

    //<inheritdoc/>
    public string OfficialName { get; } = "Guadeloupe";

    //<inheritdoc/>
    public string NativeName => "Guadeloupe";

    //<inheritdoc/>
    public string Capital { get; } = "Basse-Terre";

    //<inheritdoc/>
    public int NumericCode { get; } = 312;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GP";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GLP";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+590"];

    //<inheritdoc/>
    public IEnumerable<State> States => [];
}
