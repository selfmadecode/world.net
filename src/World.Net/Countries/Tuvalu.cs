namespace World.Net.Countries;

internal sealed class Tuvalu : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Tuvalu;

    public string Name { get; } = "Tuvalu";

    public string OfficialName { get; } = "Tuvalu";

    public string NativeName => "Tuvalu";

    public string Capital { get; } = "Funafuti";

    public int NumericCode { get; } = 798;

    public string ISO2Code { get; } = "TV";

    public string ISO3Code { get; } = "TUV";

    public string[] CallingCode { get; } = ["+688"];

    public IEnumerable<State> States => new[]
    {
        new State("Funafuti", "TV-FUN", "Island"),
        new State("Nanumea", "TV-NAN", "Island"),
        new State("Nanumanga", "TV-NMG", "Island"),
        new State("Niutao", "TV-NT", "Island"),
        new State("Nui", "TV-NUI", "Island"),
        new State("Nukufetau", "TV-NKF", "Island"),
        new State("Nukulaelae", "TV-NKL", "Island"),
        new State("Vaitupu", "TV-VAI", "Island"),
        new State("Nukulaelae", "TV-NKL", "Island")
    };
}
