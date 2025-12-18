namespace World.Net.Countries;

internal sealed class Germany : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Germany;

    //<inheritdoc/>
    public string Name { get; } = "Germany";

    //<inheritdoc/>
    public string OfficialName { get; } = "Federal Republic of Germany";

    //<inheritdoc/>
    public string NativeName => "Deutschland";

    //<inheritdoc/>
    public string Capital { get; } = "Berlin";

    //<inheritdoc/>
    public int NumericCode { get; } = 276;

    //<inheritdoc/>
    public string ISO2Code { get; } = "DE";

    //<inheritdoc/>
    public string ISO3Code { get; } = "DEU";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+49"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Baden-Württemberg", "DE-BW", "State"),
        new("Bavaria", "DE-BY", "State"),
        new("Berlin", "DE-BE", "State"),
        new("Brandenburg", "DE-BB", "State"),
        new("Bremen", "DE-HB", "State"),
        new("Hamburg", "DE-HH", "State"),
        new("Hesse", "DE-HE", "State"),
        new("Lower Saxony", "DE-NI", "State"),
        new("Mecklenburg-Vorpommern", "DE-MV", "State"),
        new("North Rhine-Westphalia", "DE-NW", "State"),
        new("Rhineland-Palatinate", "DE-RP", "State"),
        new("Saarland", "DE-SL", "State"),
        new("Saxony", "DE-SN", "State"),
        new("Saxony-Anhalt", "DE-ST", "State"),
        new("Schleswig-Holstein", "DE-SH", "State"),
        new("Thuringia", "DE-TH", "State")
    ];
}
