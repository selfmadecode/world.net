namespace World.Net.Countries;

internal sealed class Malaysia : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Malaysia;

    public string Name { get; } = "Malaysia";

    public string OfficialName { get; } = "Malaysia";

    public string NativeName => "Malaysia";

    public string Capital { get; } = "Kuala Lumpur";

    public int NumericCode { get; } = 458;

    public string ISO2Code { get; } = "MY";

    public string ISO3Code { get; } = "MYS";

    public string[] CallingCode { get; } = ["+60"];

    public IEnumerable<State> States => new[]
    {
        new State("Johor", "MY-01", "State"),
        new State("Kedah", "MY-02", "State"),
        new State("Kelantan", "MY-03", "State"),
        new State("Malacca", "MY-04", "State"),
        new State("Negeri Sembilan", "MY-05", "State"),
        new State("Pahang", "MY-06", "State"),
        new State("Penang", "MY-07", "State"),
        new State("Perak", "MY-08", "State"),
        new State("Perlis", "MY-09", "State"),
        new State("Selangor", "MY-10", "State"),
        new State("Terengganu", "MY-11", "State"),
        new State("Sabah", "MY-12", "State"),
        new State("Sarawak", "MY-13", "State"),
        new State("Kuala Lumpur", "MY-14", "Federal Territory"),
        new State("Labuan", "MY-15", "Federal Territory"),
        new State("Putrajaya", "MY-16", "Federal Territory")
    };
}

