namespace World.Net.Countries;

internal sealed class Venezuela : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Venezuela;

    public string Name { get; } = "Venezuela";

    public string OfficialName { get; } = "Bolivarian Republic of Venezuela";

    public string NativeName => "República Bolivariana de Venezuela";

    public string Capital { get; } = "Caracas";

    public int NumericCode { get; } = 862;

    public string ISO2Code { get; } = "VE";

    public string ISO3Code { get; } = "VEN";

    public string[] CallingCode { get; } = ["+58"];

    public IEnumerable<State> States => new[]
    {
        new State("Amazonas", "VE-Z", "State"),
        new State("Anzoátegui", "VE-B", "State"),
        new State("Apure", "VE-C", "State"),
        new State("Aragua", "VE-D", "State"),
        new State("Barinas", "VE-E", "State"),
        new State("Bolívar", "VE-F", "State"),
        new State("Carabobo", "VE-G", "State"),
        new State("Cojedes", "VE-H", "State"),
        new State("Delta Amacuro", "VE-Y", "State"),
        new State("Falcón", "VE-I", "State"),
        new State("Guárico", "VE-J", "State"),
        new State("Lara", "VE-K", "State"),
        new State("Mérida", "VE-L", "State"),
        new State("Miranda", "VE-M", "State"),
        new State("Monagas", "VE-N", "State"),
        new State("Nueva Esparta", "VE-O", "State"),
        new State("Portuguesa", "VE-P", "State"),
        new State("Sucre", "VE-R", "State"),
        new State("Táchira", "VE-S", "State"),
        new State("Trujillo", "VE-T", "State"),
        new State("Vargas", "VE-X", "State"),
        new State("Yaracuy", "VE-U", "State"),
        new State("Zulia", "VE-V", "State"),
        new State("Capital District", "VE-DC", "Capital District")
    };
}
