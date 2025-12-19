namespace World.Net.Countries;

internal sealed class Zambia : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Zambia;

    public string Name { get; } = "Zambia";

    public string OfficialName { get; } = "Republic of Zambia";

    public string NativeName => "Republic of Zambia";

    public string Capital { get; } = "Lusaka";

    public int NumericCode { get; } = 894;

    public string ISO2Code { get; } = "ZM";

    public string ISO3Code { get; } = "ZMB";

    public string[] CallingCode { get; } = ["+260"];

    public IEnumerable<State> States => new[]
    {
        new State("Central", "ZM-02", "Province"),
        new State("Copperbelt", "ZM-08", "Province"),
        new State("Eastern", "ZM-03", "Province"),
        new State("Luapula", "ZM-04", "Province"),
        new State("Lusaka", "ZM-09", "Province"),
        new State("Muchinga", "ZM-13", "Province"),
        new State("Northern", "ZM-05", "Province"),
        new State("North-Western", "ZM-06", "Province"),
        new State("Southern", "ZM-07", "Province"),
        new State("Western", "ZM-01", "Province")
    };
}
