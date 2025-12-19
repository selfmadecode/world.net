namespace World.Net.Countries;

internal sealed class Tokelau : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Tokelau;

    public string Name { get; } = "Tokelau";

    public string OfficialName { get; } = "Tokelau";

    public string NativeName => "Tokelau";

    public string Capital { get; } = "Nukunonu";

    public int NumericCode { get; } = 772;

    public string ISO2Code { get; } = "TK";

    public string ISO3Code { get; } = "TKL";

    public string[] CallingCode { get; } = ["+690"];

    public IEnumerable<State> States => new[]
    {
        new State("Atafu", "TK-A", "Atoll"),
        new State("Nukunonu", "TK-N", "Atoll"),
        new State("Fakaofo", "TK-F", "Atoll")
    };
}

