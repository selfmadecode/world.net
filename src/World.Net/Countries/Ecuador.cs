namespace World.Net.Countries;

internal sealed class Ecuador : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Ecuador;

    //<inheritdoc/>
    public string Name { get; } = "Ecuador";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Ecuador";

    //<inheritdoc/>
    public string NativeName => "República del Ecuador";

    //<inheritdoc/>
    public string Capital { get; } = "Quito";

    //<inheritdoc/>
    public int NumericCode { get; } = 218;

    //<inheritdoc/>
    public string ISO2Code { get; } = "EC";

    //<inheritdoc/>
    public string ISO3Code { get; } = "ECU";

    //<inheritdoc/>
    public string CallingCode { get; } = "+593";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Azuay", "EC-A"),
        new("Bolívar", "EC-B"),
        new("Cañar", "EC-F"),
        new("Carchi", "EC-C"),
        new("Chimborazo", "EC-H"),
        new("Cotopaxi", "EC-X"),
        new("El Oro", "EC-O"),
        new("Esmeraldas", "EC-E"),
        new("Galápagos", "EC-W"),
        new("Guayas", "EC-G"),
        new("Imbabura", "EC-I"),
        new("Loja", "EC-L"),
        new("Los Ríos", "EC-R"),
        new("Manabí", "EC-M"),
        new("Morona Santiago", "EC-S"),
        new("Napo", "EC-N"),
        new("Orellana", "EC-D"),
        new("Pastaza", "EC-Y"),
        new("Pichincha", "EC-P"),
        new("Santa Elena", "EC-SE"),
        new("Santo Domingo de los Tsáchilas", "EC-SD"),
        new("Sucumbíos", "EC-U"),
        new("Tungurahua", "EC-T"),
        new("Zamora Chinchipe", "EC-Z")
    ];
}
