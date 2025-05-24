namespace World.Net.Countries;

internal sealed class DominicanRepublic : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.DominicanRepublic;

    //<inheritdoc/>
    public string Name { get; } = "Dominican Republic";

    //<inheritdoc/>
    public string OfficialName { get; } = "Dominican Republic";

    //<inheritdoc/>
    public string NativeName => "República Dominicana";

    //<inheritdoc/>
    public string Capital { get; } = "Santo Domingo";

    //<inheritdoc/>
    public int NumericCode { get; } = 214;

    //<inheritdoc/>
    public string ISO2Code { get; } = "DO";

    //<inheritdoc/>
    public string ISO3Code { get; } = "DOM";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+1-809", "+1-829", "+1-849"];

    //<inheritdoc/>
    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Azua", "DO-02"),
        new("Bahoruco", "DO-03"),
        new("Barahona", "DO-04"),
        new("Dajabón", "DO-05"),
        new("Distrito Nacional", "DO-01", "National District"),
        new("Duarte", "DO-06"),
        new("El Seibo", "DO-08"),
        new("Elias Piña", "DO-07"),
        new("Espaillat", "DO-09"),
        new("Hato Mayor", "DO-30"),
        new("Hermanas Mirabal", "DO-19"),
        new("Independencia", "DO-10"),
        new("La Altagracia", "DO-11"),
        new("La Romana", "DO-12"),
        new("La Vega", "DO-13"),
        new("Maria Trinidad Sanchez", "DO-14"),
        new("Monseñor Nouel", "DO-28"),
        new("Monte Cristi", "DO-15"),
        new("Monte Plata", "DO-29"),
        new("Pedernales", "DO-16"),
        new("Peravia", "DO-17"),
        new("Puerto Plata", "DO-18"),
        new("Samana", "DO-20"),
        new("San Cristobal", "DO-21"),
        new("San Jose de Ocoa", "DO-31"),
        new("San Juan", "DO-22"),
        new("San Pedro de Macoris", "DO-23"),
        new("Sanchez Ramirez", "DO-24"),
        new("Santiago", "DO-25"),
        new("Santiago Rodriguez", "DO-26"),
        new("Santo Domingo", "DO-32"),
        new("Valverde", "DO-27")
    ];
}
