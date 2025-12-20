namespace World.Net.Countries;

internal sealed class Netherlands : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Netherlands;

    public string Name { get; } = "Netherlands";

    public string OfficialName { get; } = "Kingdom of the Netherlands";

    public string NativeName => "Nederland";

    public string Capital { get; } = "Amsterdam";

    public int NumericCode { get; } = 528;

    public string ISO2Code { get; } = "NL";

    public string ISO3Code { get; } = "NLD";

    public string[] CallingCode { get; } = ["+31"];

    public IEnumerable<State> States => new[]
    {
        new State("Drenthe", "NL-DR", "Province"),
        new State("Flevoland", "NL-FL", "Province"),
        new State("Friesland", "NL-FR", "Province"),
        new State("Gelderland", "NL-GE", "Province"),
        new State("Groningen", "NL-GR", "Province"),
        new State("Limburg", "NL-LI", "Province"),
        new State("North Brabant", "NL-NB", "Province"),
        new State("North Holland", "NL-NH", "Province"),
        new State("Overijssel", "NL-OV", "Province"),
        new State("South Holland", "NL-ZH", "Province"),
        new State("Utrecht", "NL-UT", "Province"),
        new State("Zeeland", "NL-ZE", "Province")
    };
}

