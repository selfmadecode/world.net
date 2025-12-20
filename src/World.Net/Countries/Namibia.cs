namespace World.Net.Countries;

internal sealed class Namibia : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Namibia;

    public string Name { get; } = "Namibia";

    public string OfficialName { get; } = "Republic of Namibia";

    public string NativeName => "Namibia";

    public string Capital { get; } = "Windhoek";

    public int NumericCode { get; } = 516;

    public string ISO2Code { get; } = "NA";

    public string ISO3Code { get; } = "NAM";

    public string[] CallingCode { get; } = ["+264"];

    public IEnumerable<State> States => new[]
    {
        new State("Erongo", "NA-ER", "Region"),
        new State("Hardap", "NA-HA", "Region"),
        new State("Kavango East", "NA-KE", "Region"),
        new State("Kavango West", "NA-KW", "Region"),
        new State("Khomas", "NA-KH", "Region"),
        new State("Kunene", "NA-KU", "Region"),
        new State("Ohangwena", "NA-OW", "Region"),
        new State("Omaheke", "NA-OH", "Region"),
        new State("Omusati", "NA-OS", "Region"),
        new State("Oshana", "NA-ON", "Region"),
        new State("Oshikoto", "NA-OT", "Region"),
        new State("Otjozondjupa", "NA-OD", "Region"),
        new State("Zambezi", "NA-CA", "Region")
    };
}

