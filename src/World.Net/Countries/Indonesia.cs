namespace World.Net.Countries;

internal sealed class Indonesia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Indonesia;

    //<inheritdoc/>
    public string Name { get; } = "Indonesia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Indonesia";

    //<inheritdoc/>
    public string NativeName => "Indonesia";

    //<inheritdoc/>
    public string Capital { get; } = "Jakarta";

    //<inheritdoc/>
    public int NumericCode { get; } = 360;

    //<inheritdoc/>
    public string ISO2Code { get; } = "ID";

    //<inheritdoc/>
    public string ISO3Code { get; } = "IDN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+62"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Aceh", "ID-AC", "Special Region"),
        new("Bali", "ID-BA", "Province"),
        new("Banten", "ID-BT", "Province"),
        new("Bengkulu", "ID-BE", "Province"),
        new("Central Java", "ID-JT", "Province"),
        new("Central Kalimantan", "ID-KT", "Province"),
        new("Central Sulawesi", "ID-ST", "Province"),
        new("East Java", "ID-JI", "Province"),
        new("East Kalimantan", "ID-KI", "Province"),
        new("East Nusa Tenggara", "ID-NT", "Province"),
        new("Gorontalo", "ID-GO", "Province"),
        new("Jakarta", "ID-JK", "Special Capital Region"),
        new("Jambi", "ID-JA", "Province"),
        new("Lampung", "ID-LA", "Province"),
        new("Maluku", "ID-MA", "Province"),
        new("North Kalimantan", "ID-KU", "Province"),
        new("North Maluku", "ID-MU", "Province"),
        new("North Sulawesi", "ID-SA", "Province"),
        new("North Sumatra", "ID-SU", "Province"),
        new("Papua", "ID-PA", "Province"),
        new("Riau", "ID-RI", "Province"),
        new("Riau Islands", "ID-KR", "Province"),
        new("Southeast Sulawesi", "ID-SG", "Province"),
        new("South Kalimantan", "ID-KS", "Province"),
        new("South Sulawesi", "ID-SN", "Province"),
        new("South Sumatra", "ID-SS", "Province"),
        new("Special Region of Yogyakarta", "ID-YO", "Special Region"),
        new("West Java", "ID-JB", "Province"),
        new("West Kalimantan", "ID-KB", "Province"),
        new("West Nusa Tenggara", "ID-NB", "Province"),
        new("West Papua", "ID-PA", "Province"),
        new("West Sulawesi", "ID-SB", "Province"),
        new("West Sumatra", "ID-SB", "Province"),
        new("South East Sulawesi", "ID-SG", "Province")
    ];
}
