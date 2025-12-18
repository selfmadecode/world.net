namespace World.Net.Countries;

internal sealed class Guernsey : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.GuernseyAndAlderney;

    //<inheritdoc/>
    public string Name { get; } = "Guernsey";

    //<inheritdoc/>
    public string OfficialName { get; } = "Guernsey";

    //<inheritdoc/>
    public string NativeName => "Guernsey";

    //<inheritdoc/>
    public string Capital { get; } = "St. Peter Port";

    //<inheritdoc/>
    public int NumericCode { get; } = 831;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GG";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GGY";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+44-1481"];

    //<inheritdoc/>
    public IEnumerable<State> States => [];
}
