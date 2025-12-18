namespace World.Net.Countries;

internal sealed class Senegal : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Senegal;

    //<inheritdoc/>
    public string Name { get; } = "Senegal";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Senegal";

    //<inheritdoc/>
    public string NativeName => "Sénégal";

    //<inheritdoc/>
    public string Capital { get; } = "Dakar";

    //<inheritdoc/>
    public int NumericCode { get; } = 686;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SN";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SEN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+221"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Dakar", "SN-DK", "Region"),
        new("Diourbel", "SN-DB", "Region"),
        new("Fatick", "SN-FK", "Region"),
        new("Kaffrine", "SN-KA", "Region"),
        new("Kaolack", "SN-KL", "Region"),
        new("Kédougou", "SN-KE", "Region"),
        new("Kolda", "SN-KD", "Region"),
        new("Louga", "SN-LG", "Region"),
        new("Matam", "SN-MT", "Region"),
        new("Saint-Louis", "SN-SL", "Region"),
        new("Sédhiou", "SN-SE", "Region"),
        new("Tambacounda", "SN-TC", "Region"),
        new("Thiès", "SN-TH", "Region"),
        new("Ziguinchor", "SN-ZG", "Region")
    ];
}
