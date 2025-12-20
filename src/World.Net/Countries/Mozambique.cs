namespace World.Net.Countries;

internal sealed class Mozambique : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Mozambique;

    public string Name { get; } = "Mozambique";

    public string OfficialName { get; } = "Republic of Mozambique";

    public string NativeName => "Moçambique";

    public string Capital { get; } = "Maputo";

    public int NumericCode { get; } = 508;

    public string ISO2Code { get; } = "MZ";

    public string ISO3Code { get; } = "MOZ";

    public string[] CallingCode { get; } = ["+258"];

    public IEnumerable<State> States => new[]
    {
        new State("Cabo Delgado", "MZ-P", "Province"),
        new State("Gaza", "MZ-G", "Province"),
        new State("Inhambane", "MZ-I", "Province"),
        new State("Manica", "MZ-B", "Province"),
        new State("Maputo Province", "MZ-L", "Province"),
        new State("Maputo City", "MZ-MPM", "City"),
        new State("Nampula", "MZ-N", "Province"),
        new State("Niassa", "MZ-A", "Province"),
        new State("Sofala", "MZ-S", "Province"),
        new State("Tete", "MZ-T", "Province"),
        new State("Zambezia", "MZ-Q", "Province")
    };
}

