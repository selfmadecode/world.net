namespace World.Net.Countries;

internal sealed class Colombia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Colombia;

    //<inheritdoc/>
    public string Name { get; } = "Colombia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Colombia";

    //<inheritdoc/>
    public string NativeName => "Colombia";

    //<inheritdoc/>
    public string Capital { get; } = "Bogotá";

    //<inheritdoc/>
    public int NumericCode { get; } = 170;

    //<inheritdoc/>
    public string ISO2Code { get; } = "CO";

    //<inheritdoc/>
    public string ISO3Code { get; } = "COL";

    //<inheritdoc/>
    public string CallingCode { get; } = "+57";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Amazonas", "CO-AMA", "Department"),
        new("Antioquia", "CO-ANT", "Department"),
        new("Arauca", "CO-ARA", "Department"),
        new("Atlántico", "CO-ATL", "Department"),
        new("Bolívar", "CO-BOL", "Department"),
        new("Boyacá", "CO-BOY", "Department"),
        new("Caldas", "CO-CAL", "Department"),
        new("Caquetá", "CO-CAQ", "Department"),
        new("Casanare", "CO-CAS", "Department"),
        new("Cauca", "CO-CAU", "Department"),
        new("Cesar", "CO-CES", "Department"),
        new("Chocó", "CO-CHO", "Department"),
        new("Córdoba", "CO-COR", "Department"),
        new("Cundinamarca", "CO-CUN", "Department"),
        new("Guainía", "CO-GUA", "Department"),
        new("Guaviare", "CO-GUV", "Department"),
        new("Huila", "CO-HUI", "Department"),
        new("La Guajira", "CO-LAG", "Department"),
        new("Magdalena", "CO-MAG", "Department"),
        new("Meta", "CO-MET", "Department"),
        new("Nariño", "CO-NAR", "Department"),
        new("Norte de Santander", "CO-NSA", "Department"),
        new("Putumayo", "CO-PUT", "Department"),
        new("Quindío", "CO-QUI", "Department"),
        new("Risaralda", "CO-RIS", "Department"),
        new("San Andrés, Providencia and Santa Catalina", "CO-SAP", "Department"),
        new("Santander", "CO-SAN", "Department"),
        new("Sucre", "CO-SUC", "Department"),
        new("Tolima", "CO-TOL", "Department"),
        new("Valle del Cauca", "CO-VAC", "Department"),
        new("Vaupés", "CO-VAU", "Department"),
        new("Vichada", "CO-VIC", "Department")
    ];
}
