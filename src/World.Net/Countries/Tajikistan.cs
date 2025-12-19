namespace World.Net.Countries;

internal sealed class Tajikistan : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Tajikistan;

    public string Name { get; } = "Tajikistan";

    public string OfficialName { get; } = "Republic of Tajikistan";

    public string NativeName => "Ҷумҳурии Тоҷикистон";

    public string Capital { get; } = "Dushanbe";

    public int NumericCode { get; } = 762;

    public string ISO2Code { get; } = "TJ";

    public string ISO3Code { get; } = "TJK";

    public string[] CallingCode { get; } = ["+992"];

    public IEnumerable<State> States => new[]
    {
        new State("Sughd", "TJ-SU", "Region"),
        new State("Khatlon", "TJ-KT", "Region"),
        new State("Gorno-Badakhshan", "TJ-GBAO", "Autonomous Region"),
        new State("Districts of Republican Subordination", "TJ-DRS", "Region"),
        new State("Dushanbe", "TJ-DU", "Capital District")
    };
}

