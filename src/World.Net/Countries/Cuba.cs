namespace World.Net.Countries;

internal sealed class Cuba : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Cuba;

    //<inheritdoc/>
    public string Name { get; } = "Cuba";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Cuba";

    //<inheritdoc/>
    public string NativeName => "Cuba";

    //<inheritdoc/>
    public string Capital { get; } = "Havana";

    //<inheritdoc/>
    public int NumericCode { get; } = 192;

    //<inheritdoc/>
    public string ISO2Code { get; } = "CU";

    //<inheritdoc/>
    public string ISO3Code { get; } = "CUB";

    //<inheritdoc/>
    public string CallingCode { get; } = "+53";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Artemisa", "CU-15", "Province"),
        new("Camagüey", "CU-09", "Province"),
        new("Ciego de Ávila", "CU-08", "Province"),
        new("Cienfuegos", "CU-06", "Province"),
        new("Granma", "CU-12", "Province"),
        new("Guantánamo", "CU-14", "Province"),
        new("Holguín", "CU-11", "Province"),
        new("Isla de la Juventud", "CU-99", "Special Municipality"),
        new("La Habana", "CU-03", "Province"),
        new("Las Tunas", "CU-10", "Province"),
        new("Matanzas", "CU-04", "Province"),
        new("Mayabeque", "CU-16", "Province"),
        new("Pinar del Río", "CU-01", "Province"),
        new("Sancti Spíritus", "CU-07", "Province"),
        new("Santiago de Cuba", "CU-13", "Province"),
        new("Villa Clara", "CU-05", "Province")
    ];
}
