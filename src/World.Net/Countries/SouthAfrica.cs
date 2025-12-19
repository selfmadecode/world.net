namespace World.Net.Countries;

internal sealed class SouthAfrica : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SouthAfrica;

    //<inheritdoc/>
    public string Name { get; } = "South Africa";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of South Africa";

    //<inheritdoc/>
    public string NativeName => "South Africa";

    //<inheritdoc/>
    public string Capital { get; } = "Pretoria";

    //<inheritdoc/>
    public int NumericCode { get; } = 710;

    //<inheritdoc/>
    public string ISO2Code { get; } = "ZA";

    //<inheritdoc/>
    public string ISO3Code { get; } = "ZAF";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+27"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Eastern Cape", "ZA-EC", "Province"),
        new State("Free State", "ZA-FS", "Province"),
        new State("Gauteng", "ZA-GT", "Province"),
        new State("KwaZulu-Natal", "ZA-KZN", "Province"),
        new State("Limpopo", "ZA-LP", "Province"),
        new State("Mpumalanga", "ZA-MP", "Province"),
        new State("North West", "ZA-NW", "Province"),
        new State("Northern Cape", "ZA-NC", "Province"),
        new State("Western Cape", "ZA-WC", "Province")
    };
}
