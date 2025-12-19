namespace World.Net.Countries;

internal sealed class Sweden : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Sweden;

    //<inheritdoc/>
    public string Name { get; } = "Sweden";

    //<inheritdoc/>
    public string OfficialName { get; } = "Kingdom of Sweden";

    //<inheritdoc/>
    public string NativeName => "Sverige";

    //<inheritdoc/>
    public string Capital { get; } = "Stockholm";

    //<inheritdoc/>
    public int NumericCode { get; } = 752;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SE";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SWE";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+46"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Blekinge", "SE-K", "County"),
        new State("Dalarna", "SE-W", "County"),
        new State("Gävleborg", "SE-X", "County"),
        new State("Gotland", "SE-I", "County"),
        new State("Halland", "SE-N", "County"),
        new State("Jämtland", "SE-Z", "County"),
        new State("Jönköping", "SE-F", "County"),
        new State("Kalmar", "SE-H", "County"),
        new State("Kronoberg", "SE-G", "County"),
        new State("Norrbotten", "SE-B", "County"),
        new State("Örebro", "SE-T", "County"),
        new State("Östergötland", "SE-E", "County"),
        new State("Skåne", "SE-M", "County"),
        new State("Södermanland", "SE-D", "County"),
        new State("Uppsala", "SE-C", "County"),
        new State("Värmland", "SE-S", "County"),
        new State("Västerbotten", "SE-AC", "County"),
        new State("Västernorrland", "SE-Y", "County"),
        new State("Västmanland", "SE-U", "County"),
        new State("Västra Götaland", "SE-O", "County"),
        new State("Öland", "SE-ZX", "County") // included for completeness, adjust if needed
    };
}

