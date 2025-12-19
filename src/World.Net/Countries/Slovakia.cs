namespace World.Net.Countries;

internal sealed class Slovakia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Slovakia;

    //<inheritdoc/>
    public string Name { get; } = "Slovakia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Slovak Republic";

    //<inheritdoc/>
    public string NativeName => "Slovensko";

    //<inheritdoc/>
    public string Capital { get; } = "Bratislava";

    //<inheritdoc/>
    public int NumericCode { get; } = 703;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SK";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SVK";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+421"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Bratislava Region", "SK-BL", "Region"),
        new State("Trnava Region", "SK-TA", "Region"),
        new State("Trenčín Region", "SK-TC", "Region"),
        new State("Nitra Region", "SK-NI", "Region"),
        new State("Žilina Region", "SK-ZI", "Region"),
        new State("Banská Bystrica Region", "SK-BC", "Region"),
        new State("Prešov Region", "SK-PV", "Region"),
        new State("Košice Region", "SK-KI", "Region")
    };
}

