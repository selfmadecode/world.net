namespace World.Net.Countries;

internal sealed class Poland : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Poland;

    //<inheritdoc/>
    public string Name { get; } = "Poland";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Poland";

    //<inheritdoc/>
    public string NativeName => "Rzeczpospolita Polska";

    //<inheritdoc/>
    public string Capital { get; } = "Warsaw";

    //<inheritdoc/>
    public int NumericCode { get; } = 616;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PL";

    //<inheritdoc/>
    public string ISO3Code { get; } = "POL";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+48"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Greater Poland", "PL-WP", "Voivodeship"),
        new("Kuyavian-Pomeranian", "PL-KP", "Voivodeship"),
        new("Lesser Poland", "PL-MA", "Voivodeship"),
        new("Łódź", "PL-LD", "Voivodeship"),
        new("Lower Silesian", "PL-DS", "Voivodeship"),
        new("Lublin", "PL-LU", "Voivodeship"),
        new("Lubusz", "PL-LB", "Voivodeship"),
        new("Masovian", "PL-MZ", "Voivodeship"),
        new("Opole", "PL-OP", "Voivodeship"),
        new("Podlaskie", "PL-PD", "Voivodeship"),
        new("Pomeranian", "PL-PM", "Voivodeship"),
        new("Silesian", "PL-SL", "Voivodeship"),
        new("Subcarpathian", "PL-PK", "Voivodeship"),
        new("Świętokrzyskie", "PL-SK", "Voivodeship"),
        new("Warmian-Masurian", "PL-WN", "Voivodeship"),
        new("West Pomeranian", "PL-ZP", "Voivodeship")
    ];
}
