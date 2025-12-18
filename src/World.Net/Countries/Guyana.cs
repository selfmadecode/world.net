namespace World.Net.Countries;

internal sealed class Guyana : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Guyana;

    //<inheritdoc/>
    public string Name { get; } = "Guyana";

    //<inheritdoc/>
    public string OfficialName { get; } = "Co-operative Republic of Guyana";

    //<inheritdoc/>
    public string NativeName => "Guyana";

    //<inheritdoc/>
    public string Capital { get; } = "Georgetown";

    //<inheritdoc/>
    public int NumericCode { get; } = 328;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GY";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GUY";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+592"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Barima-Waini", "GY-BA", "Region"),
        new("Pomeroon-Supenaam", "GY-PT", "Region"),
        new("Essequibo Islands-West Demerara", "GY-ES", "Region"),
        new("Demerara-Mahaica", "GY-DE", "Region"),
        new("Mahaica-Berbice", "GY-MA", "Region"),
        new("East Berbice-Corentyne", "GY-EB", "Region"),
        new("Cuyuni-Mazaruni", "GY-CU", "Region"),
        new("Potaro-Siparuni", "GY-PT", "Region"),
        new("Upper Takutu-Upper Essequibo", "GY-UT", "Region"),
        new("Upper Demerara-Berbice", "GY-UD", "Region")
    ];
}
