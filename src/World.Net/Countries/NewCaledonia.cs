namespace World.Net.Countries;

internal sealed class NewCaledonia : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.NewCaledonia;

    public string Name { get; } = "New Caledonia";

    public string OfficialName { get; } = "New Caledonia";

    public string NativeName => "Nouvelle-Calédonie";

    public string Capital { get; } = "Nouméa";

    public int NumericCode { get; } = 540;

    public string ISO2Code { get; } = "NC";

    public string ISO3Code { get; } = "NCL";

    public string[] CallingCode { get; } = ["+687"];

    public IEnumerable<State> States => new[]
    {
        new State("North Province", "NC-N", "Province"),
        new State("South Province", "NC-S", "Province"),
        new State("Loyalty Islands Province", "NC-L", "Province")
    };
}
