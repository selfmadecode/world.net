
namespace World.Net.Countries;

internal sealed class TheBahamas : ICountry
{
    public int Id => CountryIdentifier.Bahamas;

    public string Name { get; } = "The Bahamas";

    public string OfficialName { get; } = "Commonwealth of the Bahamas";

    public string NativeName => nameof(TheBahamas);

    public string Capital { get; } = "Nassau";

    public int NumericCode { get; } = 044;

    public string ISO2Code { get; } = "BS";

    public string ISO3Code { get; } = "BHS";

    public string CallingCode { get; } = "+1 242";

    public IEnumerable<State> States =>
    [
        new("Acklins", "AK", "District"),
        new("Acklins and Crooked Islands", "AC", "District"),
        new("Berry Islands", "BY", "District"),
        new("Bimini", "BI", "District"),
        new("Black Point", "BP", "District"),
        new("Cat Island", "CI", "District"),
        new("Central Abaco", "CO", "District"),
        new("Central Andros", "CS", "District"),
        new("Central Eleuthera", "CE", "District"),
        new("Crooked Island", "CK", "District"),
        new("East Grand Bahama", "EG", "District"),
        new("Exuma", "EX", "District"),
        new("Freeport", "FP", "District"),
        new("Fresh Creek", "FC", "District"),
        new("Governor’s Harbour", "GH", "District"),
        new("Grand Cay", "GC", "District"),
        new("Green Turtle Cay", "GT", "District"),
        new("Harbour Island", "HI", "District"),
        new("High Rock", "HR", "District"),
        new("Hope Town", "HT", "District"),
        new("Inagua", "IN", "District"),
        new("Kemps Bay", "KB", "District"),
        new("Long Island", "LI", "District"),
        new("Mangrove Cay", "MC", "District"),
        new("Marsh Harbour", "MH", "District"),
        new("Mayaguana", "MG", "District"),
        new("New Providence", "NP", "Island"),
        new("Nichollstown and Berry Islands", "NB", "District"),
        new("North Abaco", "NO", "District"),
        new("North Andros", "NS", "District"),
        new("North Eleuthera", "NE", "District"),
        new("Ragged Island", "RI", "District"),
        new("Rock Sound", "RS", "District"),
        new("Rum Cay", "RC", "District"),
        new("San Salvador and Rum Cay", "SR", "District"),
        new("San Salvador Island", "SS", "District"),
        new("Sandy Point", "SP", "District"),
        new("South Abaco", "SO", "District"),
        new("South Andros", "SA", "District"),
        new("South Eleuthera", "SE", "District"),
        new("Spanish Wells", "SW", "District"),
        new("West Grand Bahama", "WG", "District")
    ];
}
