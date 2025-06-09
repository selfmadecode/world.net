namespace World.Net.Countries;
internal sealed class Jersey : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Jersey;

    //<inheritdoc/>
    public string Name { get; } = "Jersey";

    //<inheritdoc/>
    public string OfficialName { get; } = "Bailiwick of Jersey";

    //<inheritdoc/>
    public string NativeName => "Jersey";

    //<inheritdoc/>
    public string Capital { get; } = "Saint Helier";

    //<inheritdoc/>
    public int NumericCode { get; } = 832;

    //<inheritdoc/>
    public string ISO2Code { get; } = "JE";

    //<inheritdoc/>
    public string ISO3Code { get; } = "JEY";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+44"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Grouville", "JE-01", "parish"),
        new("St Brelade", "JE-02", "parish"),
        new("St Clement", "JE-03", "parish"),
        new("St Helier", "JE-04", "parish"),
        new("St John", "JE-05", "parish"),
        new("St Lawrence", "JE-06", "parish"),
        new("St Martin", "JE-07", "parish"),
        new("St Mary", "JE-08", "parish"),
        new("St Ouen", "JE-09", "parish"),
        new("St Peter", "JE-10", "parish"),
        new("St Saviour", "JE-11", "parish"),
        new("Trinity", "JE-12", "parish"),
    ];
}
