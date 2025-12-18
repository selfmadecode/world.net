namespace World.Net.Countries;

internal sealed class PapuaNewGuinea : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.PapuaNewGuinea;

    //<inheritdoc/>
    public string Name { get; } = "Papua New Guinea";

    //<inheritdoc/>
    public string OfficialName { get; } = "Independent State of Papua New Guinea";

    //<inheritdoc/>
    public string NativeName => "Papua Niugini";

    //<inheritdoc/>
    public string Capital { get; } = "Port Moresby";

    //<inheritdoc/>
    public int NumericCode { get; } = 598;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PG";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PNG";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+675"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Central", "PG-CN", "Province"),
        new("Gulf", "PG-GL", "Province"),
        new("Milne Bay", "PG-MB", "Province"),
        new("Northern", "PG-NB", "Province"),
        new("Southern Highlands", "PG-SH", "Province"),
        new("Western", "PG-WP", "Province"),
        new("Western Highlands", "PG-WH", "Province"),
        new("Enga", "PG-EN", "Province"),
        new("Eastern Highlands", "PG-EH", "Province"),
        new("Hela", "PG-HE", "Province"),
        new("Morobe", "PG-MO", "Province"),
        new("Madang", "PG-MD", "Province"),
        new("New Ireland", "PG-NI", "Province"),
        new("East New Britain", "PG-EB", "Province"),
        new("West New Britain", "PG-WB", "Province"),
        new("Manus", "PG-MA", "Province"),
        new("Bougainville", "PG-BA", "Autonomous Region"),
        new("Chimbu", "PG-CP", "Province"),
        new("Oro", "PG-OR", "Province"),
        new("Sandaun", "PG-SO", "Province"),
        new("Central", "PG-CE", "Province"),
        new("National Capital District", "PG-NCD", "District")
    ];
}

