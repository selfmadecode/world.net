namespace World.Net.Countries;

internal sealed class Philippines : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Philippines;

    //<inheritdoc/>
    public string Name { get; } = "Philippines";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of the Philippines";

    //<inheritdoc/>
    public string NativeName => "Republika ng Pilipinas";

    //<inheritdoc/>
    public string Capital { get; } = "Manila";

    //<inheritdoc/>
    public int NumericCode { get; } = 608;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PH";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PHL";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+63"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Ilocos Region", "PH-01", "Region"),
        new("Cagayan Valley", "PH-02", "Region"),
        new("Central Luzon", "PH-03", "Region"),
        new("CALABARZON", "PH-04", "Region"),
        new("MIMAROPA", "PH-05", "Region"),
        new("Bicol Region", "PH-06", "Region"),
        new("Western Visayas", "PH-07", "Region"),
        new("Central Visayas", "PH-08", "Region"),
        new("Eastern Visayas", "PH-09", "Region"),
        new("Zamboanga Peninsula", "PH-10", "Region"),
        new("Northern Mindanao", "PH-11", "Region"),
        new("Davao Region", "PH-12", "Region"),
        new("SOCCSKSARGEN", "PH-13", "Region"),
        new("Caraga", "PH-14", "Region"),
        new("Bangsamoro Autonomous Region in Muslim Mindanao", "PH-15", "Autonomous Region"),
        new("Cordillera Administrative Region", "PH-16", "Region"),
        new("National Capital Region", "PH-NCR", "Capital Region")
    ];
}

