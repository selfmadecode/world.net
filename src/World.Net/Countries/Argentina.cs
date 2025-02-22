namespace World.Net.Countries;

internal sealed class Argentina : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Argentina;

    ///<inheritdoc/>
    public string Name => nameof(Argentina);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Argentine Republic";

    ///<inheritdoc/>
    public string NativeName { get; } = "Argentina";

    ///<inheritdoc/>
    public string Capital { get; } = "Buenos Aires";

    ///<inheritdoc/>
    public int NumericCode { get; } = 032;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AR";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "ARG";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+54";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Buenos Aires", "AR-B", "Province"),
        new("Catamarca", "AR-K", "Province"),
        new("Chaco", "AR-H", "Province"),
        new("Chubut", "AR-U", "Province"),
        new("Ciudad Autónoma de Buenos Aires", "AR-C", "City"),
        new("Córdoba", "AR-X", "Province"),
        new("Corrientes", "AR-W", "Province"),
        new("Entre Ríos", "AR-E", "Province"),
        new("Formosa", "AR-P", "Province"),
        new("Jujuy", "AR-Y", "Province"),
        new("La Pampa", "AR-L", "Province"),
        new("La Rioja", "AR-F", "Province"),
        new("Mendoza", "AR-M", "Province"),
        new("Misiones", "AR-N", "Province"),
        new("Neuquén", "AR-Q", "Province"),
        new("Río Negro", "AR-R", "Province"),
        new("Salta", "AR-A", "Province"),
        new("San Juan", "AR-J", "Province"),
        new("San Luis", "AR-D", "Province"),
        new("Santa Cruz", "AR-Z", "Province"),
        new("Santa Fe", "AR-S", "Province"),
        new("Santiago del Estero", "AR-G", "Province"),
        new("Tierra del Fuego", "AR-V", "Province"),
        new("Tucumán", "AR-T", "Province"),
    ];
}
