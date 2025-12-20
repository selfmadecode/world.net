namespace World.Net.Countries;

internal sealed class Nicaragua : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Nicaragua;

    public string Name { get; } = "Nicaragua";

    public string OfficialName { get; } = "Republic of Nicaragua";

    public string NativeName => "Nicaragua";

    public string Capital { get; } = "Managua";

    public int NumericCode { get; } = 558;

    public string ISO2Code { get; } = "NI";

    public string ISO3Code { get; } = "NIC";

    public string[] CallingCode { get; } = ["+505"];

    public IEnumerable<State> States => new[]
    {
        new State("Boaco", "NI-BO", "Department"),
        new State("Carazo", "NI-CA", "Department"),
        new State("Chinandega", "NI-CI", "Department"),
        new State("Chontales", "NI-CO", "Department"),
        new State("Estelí", "NI-ES", "Department"),
        new State("Granada", "NI-GR", "Department"),
        new State("Jinotega", "NI-JI", "Department"),
        new State("León", "NI-LE", "Department"),
        new State("Madriz", "NI-MD", "Department"),
        new State("Managua", "NI-MN", "Department"),
        new State("Masaya", "NI-MS", "Department"),
        new State("Matagalpa", "NI-MT", "Department"),
        new State("North Caribbean Coast", "NI-AN", "Autonomous Region"),
        new State("South Caribbean Coast", "NI-AS", "Autonomous Region"),
        new State("Nueva Segovia", "NI-NS", "Department"),
        new State("Rivas", "NI-RI", "Department"),
        new State("Río San Juan", "NI-SJ", "Department")
    };
}

