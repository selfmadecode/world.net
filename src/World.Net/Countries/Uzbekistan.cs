namespace World.Net.Countries;

internal sealed class Uzbekistan : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Uzbekistan;

    public string Name { get; } = "Uzbekistan";

    public string OfficialName { get; } = "Republic of Uzbekistan";

    public string NativeName => "Oʻzbekiston Respublikasi";

    public string Capital { get; } = "Tashkent";

    public int NumericCode { get; } = 860;

    public string ISO2Code { get; } = "UZ";

    public string ISO3Code { get; } = "UZB";

    public string[] CallingCode { get; } = ["+998"];

    public IEnumerable<State> States => new[]
    {
        new State("Andijan", "UZ-AN", "Region"),
        new State("Bukhara", "UZ-BU", "Region"),
        new State("Fergana", "UZ-FA", "Region"),
        new State("Jizzakh", "UZ-JI", "Region"),
        new State("Kashkadarya", "UZ-KA", "Region"),
        new State("Khorezm", "UZ-KH", "Region"),
        new State("Namangan", "UZ-NG", "Region"),
        new State("Navoiy", "UZ-NW", "Region"),
        new State("Samarkand", "UZ-SA", "Region"),
        new State("Sirdaryo", "UZ-SI", "Region"),
        new State("Surxondaryo", "UZ-SU", "Region"),
        new State("Tashkent Region", "UZ-TO", "Region"),
        new State("Republic of Karakalpakstan", "UZ-QA", "Autonomous Republic"),
        new State("Tashkent", "UZ-TK", "City")
    };
}

