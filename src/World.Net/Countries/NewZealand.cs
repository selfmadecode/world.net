namespace World.Net.Countries;

internal sealed class NewZealand : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.NewZealand;

    public string Name { get; } = "New Zealand";

    public string OfficialName { get; } = "New Zealand";

    public string NativeName => "Aotearoa";

    public string Capital { get; } = "Wellington";

    public int NumericCode { get; } = 554;

    public string ISO2Code { get; } = "NZ";

    public string ISO3Code { get; } = "NZL";

    public string[] CallingCode { get; } = ["+64"];

    public IEnumerable<State> States => new[]
    {
        new State("Auckland", "NZ-AUK", "Region"),
        new State("Bay of Plenty", "NZ-BOP", "Region"),
        new State("Canterbury", "NZ-CAN", "Region"),
        new State("Chatham Islands Territory", "NZ-CIT", "Territory"),
        new State("Gisborne", "NZ-GIS", "Region"),
        new State("Hawke's Bay", "NZ-HKB", "Region"),
        new State("Manawatu-Whanganui", "NZ-MWT", "Region"),
        new State("Marlborough", "NZ-MBH", "Region"),
        new State("Nelson", "NZ-NSN", "Region"),
        new State("Northland", "NZ-NTL", "Region"),
        new State("Otago", "NZ-OTA", "Region"),
        new State("Southland", "NZ-STL", "Region"),
        new State("Taranaki", "NZ-TKI", "Region"),
        new State("Tasman", "NZ-TAS", "Region"),
        new State("Waikato", "NZ-WKO", "Region"),
        new State("Wellington", "NZ-WGN", "Region"),
        new State("West Coast", "NZ-WTC", "Region")
    };
}

