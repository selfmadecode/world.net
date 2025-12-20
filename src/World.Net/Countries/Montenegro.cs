namespace World.Net.Countries;

internal sealed class Montenegro : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Montenegro;

    public string Name { get; } = "Montenegro";

    public string OfficialName { get; } = "Montenegro";

    public string NativeName => "Crna Gora";

    public string Capital { get; } = "Podgorica";

    public int NumericCode { get; } = 499;

    public string ISO2Code { get; } = "ME";

    public string ISO3Code { get; } = "MNE";

    public string[] CallingCode { get; } = ["+382"];

    public IEnumerable<State> States => new[]
    {
        new State("Andrijevica", "ME-01", "Municipality"),
        new State("Bar", "ME-02", "Municipality"),
        new State("Berane", "ME-03", "Municipality"),
        new State("Bijelo Polje", "ME-04", "Municipality"),
        new State("Budva", "ME-05", "Municipality"),
        new State("Cetinje", "ME-06", "Municipality"),
        new State("Danilovgrad", "ME-07", "Municipality"),
        new State("Herceg Novi", "ME-08", "Municipality"),
        new State("Kolašin", "ME-09", "Municipality"),
        new State("Kotor", "ME-10", "Municipality"),
        new State("Mojkovac", "ME-11", "Municipality"),
        new State("Nikšić", "ME-12", "Municipality"),
        new State("Plav", "ME-13", "Municipality"),
        new State("Pljevlja", "ME-14", "Municipality"),
        new State("Plužine", "ME-15", "Municipality"),
        new State("Podgorica", "ME-16", "Municipality"),
        new State("Rožaje", "ME-17", "Municipality"),
        new State("Šavnik", "ME-18", "Municipality"),
        new State("Tivat", "ME-19", "Municipality"),
        new State("Ulcinj", "ME-20", "Municipality"),
        new State("Žabljak", "ME-21", "Municipality")
    };
}

