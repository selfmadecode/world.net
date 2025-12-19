namespace World.Net.Countries;

internal sealed class Zimbabwe : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Zimbabwe;

    public string Name { get; } = "Zimbabwe";

    public string OfficialName { get; } = "Republic of Zimbabwe";

    public string NativeName => "Republic of Zimbabwe";

    public string Capital { get; } = "Harare";

    public int NumericCode { get; } = 716;

    public string ISO2Code { get; } = "ZW";

    public string ISO3Code { get; } = "ZWE";

    public string[] CallingCode { get; } = ["+263"];

    public IEnumerable<State> States => new[]
    {
        new State("Bulawayo", "ZW-BU", "Province"),
        new State("Harare", "ZW-HA", "Province"),
        new State("Manicaland", "ZW-MA", "Province"),
        new State("Mashonaland Central", "ZW-MC", "Province"),
        new State("Mashonaland East", "ZW-ME", "Province"),
        new State("Mashonaland West", "ZW-MW", "Province"),
        new State("Masvingo", "ZW-MV", "Province"),
        new State("Matabeleland North", "ZW-MN", "Province"),
        new State("Matabeleland South", "ZW-MS", "Province"),
        new State("Midlands", "ZW-MI", "Province")
    };
}

