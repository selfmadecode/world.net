namespace World.Net.Countries;

internal sealed class Ghana : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Ghana;

    //<inheritdoc/>
    public string Name { get; } = "Ghana";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Ghana";

    //<inheritdoc/>
    public string NativeName => "Ghana";

    //<inheritdoc/>
    public string Capital { get; } = "Accra";

    //<inheritdoc/>
    public int NumericCode { get; } = 288;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GH";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GHA";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+233"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Ahafo", "GH-AF", "Region"),
        new("Ashanti", "GH-AH", "Region"),
        new("Bono", "GH-BO", "Region"),
        new("Bono East", "GH-BE", "Region"),
        new("Central", "GH-CP", "Region"),
        new("Eastern", "GH-EP", "Region"),
        new("Greater Accra", "GH-AA", "Region"),
        new("North East", "GH-NE", "Region"),
        new("Northern", "GH-NP", "Region"),
        new("Oti", "GH-OT", "Region"),
        new("Savannah", "GH-SV", "Region"),
        new("Upper East", "GH-UE", "Region"),
        new("Upper West", "GH-UW", "Region"),
        new("Volta", "GH-TV", "Region"),
        new("Western", "GH-WP", "Region"),
        new("Western North", "GH-WN", "Region")
    ];
}
