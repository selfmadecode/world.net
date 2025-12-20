namespace World.Net.Countries;

internal sealed class Myanmar : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Myanmar;

    public string Name { get; } = "Myanmar";

    public string OfficialName { get; } = "Republic of the Union of Myanmar";

    public string NativeName => "မြန်မာ";

    public string Capital { get; } = "Naypyidaw";

    public int NumericCode { get; } = 104;

    public string ISO2Code { get; } = "MM";

    public string ISO3Code { get; } = "MMR";

    public string[] CallingCode { get; } = ["+95"];

    public IEnumerable<State> States => new[]
    {
        new State("Ayeyarwady", "MM-07", "Region"),
        new State("Bago", "MM-02", "Region"),
        new State("Chin", "MM-14", "State"),
        new State("Kachin", "MM-11", "State"),
        new State("Kayah", "MM-12", "State"),
        new State("Kayin", "MM-13", "State"),
        new State("Magway", "MM-03", "Region"),
        new State("Mandalay", "MM-04", "Region"),
        new State("Mon", "MM-15", "State"),
        new State("Naypyidaw", "MM-18", "Union Territory"),
        new State("Rakhine", "MM-16", "State"),
        new State("Sagaing", "MM-01", "Region"),
        new State("Shan", "MM-17", "State"),
        new State("Tanintharyi", "MM-05", "Region"),
        new State("Yangon", "MM-06", "Region")
    };
}

