namespace World.Net.Countries;

internal sealed class Georgia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Georgia;

    //<inheritdoc/>
    public string Name { get; } = "Georgia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Georgia";

    //<inheritdoc/>
    public string NativeName => "საქართველო";

    //<inheritdoc/>
    public string Capital { get; } = "Tbilisi";

    //<inheritdoc/>
    public int NumericCode { get; } = 268;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GE";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GEO";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+995"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        // Autonomous Republics
        new("Abkhazia", "GE-AB", "Autonomous Republic"),
        new("Adjara", "GE-AJ", "Autonomous Republic"),

        // Regions
        new("Guria", "GE-GU", "Region"),
        new("Imereti", "GE-IM", "Region"),
        new("Kakheti", "GE-KA", "Region"),
        new("Kvemo Kartli", "GE-KK", "Region"),
        new("Mtskheta-Mtianeti", "GE-MM", "Region"),
        new("Racha-Lechkhumi and Kvemo Svaneti", "GE-RL", "Region"),
        new("Samegrelo-Zemo Svaneti", "GE-SZ", "Region"),
        new("Samtskhe-Javakheti", "GE-SJ", "Region"),
        new("Shida Kartli", "GE-SK", "Region"),

        // Capital city
        new("Tbilisi", "GE-TB", "City")
    ];
}
