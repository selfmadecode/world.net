namespace World.Net.Countries;

internal sealed class SriLanka : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SriLanka;

    //<inheritdoc/>
    public string Name { get; } = "Sri Lanka";

    //<inheritdoc/>
    public string OfficialName { get; } = "Democratic Socialist Republic of Sri Lanka";

    //<inheritdoc/>
    public string NativeName => "ශ්‍රී ලංකාව";

    //<inheritdoc/>
    public string Capital { get; } = "Sri Jayawardenepura Kotte";

    //<inheritdoc/>
    public int NumericCode { get; } = 144;

    //<inheritdoc/>
    public string ISO2Code { get; } = "LK";

    //<inheritdoc/>
    public string ISO3Code { get; } = "LKA";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+94"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Central", "LK-CE", "Province"),
        new State("Eastern", "LK-EP", "Province"),
        new State("North Central", "LK-NC", "Province"),
        new State("Northern", "LK-NU", "Province"),
        new State("North Western", "LK-NW", "Province"),
        new State("Sabaragamuwa", "LK-SG", "Province"),
        new State("Southern", "LK-SO", "Province"),
        new State("Uva", "LK-UVA", "Province"),
        new State("Western", "LK-WP", "Province")
    };
}
