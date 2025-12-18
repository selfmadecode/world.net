namespace World.Net.Countries;

internal sealed class Honduras : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Honduras;

    //<inheritdoc/>
    public string Name { get; } = "Honduras";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Honduras";

    //<inheritdoc/>
    public string NativeName => "Honduras";

    //<inheritdoc/>
    public string Capital { get; } = "Tegucigalpa";

    //<inheritdoc/>
    public int NumericCode { get; } = 340;

    //<inheritdoc/>
    public string ISO2Code { get; } = "HN";

    //<inheritdoc/>
    public string ISO3Code { get; } = "HND";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+504"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Atlántida", "HN-AT", "Department"),
        new("Choluteca", "HN-CH", "Department"),
        new("Colón", "HN-CL", "Department"),
        new("Comayagua", "HN-CM", "Department"),
        new("Copán", "HN-CP", "Department"),
        new("Cortés", "HN-CR", "Department"),
        new("El Paraíso", "HN-EP", "Department"),
        new("Francisco Morazán", "HN-FM", "Department"),
        new("Gracias a Dios", "HN-GD", "Department"),
        new("Intibucá", "HN-IN", "Department"),
        new("Islas de la Bahía", "HN-IB", "Department"),
        new("La Paz", "HN-LP", "Department"),
        new("Lempira", "HN-LE", "Department"),
        new("Ocotepeque", "HN-OC", "Department"),
        new("Olancho", "HN-OL", "Department"),
        new("Santa Bárbara", "HN-SB", "Department"),
        new("Valle", "HN-VA", "Department"),
        new("Yoro", "HN-YO", "Department")
    ];
}

