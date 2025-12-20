namespace World.Net.Countries;

internal sealed class Morocco : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Morocco;

    public string Name { get; } = "Morocco";

    public string OfficialName { get; } = "Kingdom of Morocco";

    public string NativeName => "المغرب";

    public string Capital { get; } = "Rabat";

    public int NumericCode { get; } = 504;

    public string ISO2Code { get; } = "MA";

    public string ISO3Code { get; } = "MAR";

    public string[] CallingCode { get; } = ["+212"];

    public IEnumerable<State> States => new[]
    {
        new State("Tanger-Tetouan-Al Hoceima", "MA-01", "Region"),
        new State("Oriental", "MA-02", "Region"),
        new State("Fes-Meknes", "MA-03", "Region"),
        new State("Rabat-Sale-Kenitra", "MA-04", "Region"),
        new State("Beni Mellal-Khenifra", "MA-05", "Region"),
        new State("Casablanca-Settat", "MA-06", "Region"),
        new State("Marrakesh-Safi", "MA-07", "Region"),
        new State("Draa-Tafilalet", "MA-08", "Region"),
        new State("Souss-Massa", "MA-09", "Region"),
        new State("Guelmim-Oued Noun", "MA-10", "Region"),
        new State("Laayoune-Sakia El Hamra", "MA-11", "Region"),
        new State("Dakhla-Oued Ed-Dahab", "MA-12", "Region")
    };
}

