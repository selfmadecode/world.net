namespace World.Net.Countries;

internal sealed class IsleOfMan : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.IsleOfMan;

    public string Name { get; } = "Isle of Man";

    public string OfficialName { get; } = "Isle of Man";

    public string NativeName => "Ellan Vannin";

    public string Capital { get; } = "Douglas";

    public int NumericCode { get; } = 833;

    public string ISO2Code { get; } = "IM";

    public string ISO3Code { get; } = "IMN";

    public string[] CallingCode { get; } = ["+44"];

    public IEnumerable<State> States => new[]
    {
        new State("Ayre", "IM-01", "Sheading"),
        new State("Garff", "IM-02", "Sheading"),
        new State("Glenfaba", "IM-03", "Sheading"),
        new State("Michael", "IM-04", "Sheading"),
        new State("Middle", "IM-05", "Sheading"),
        new State("Rushen", "IM-06", "Sheading")
    };
}

