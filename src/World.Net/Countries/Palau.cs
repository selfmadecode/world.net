namespace World.Net.Countries;

internal sealed class Palau : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Palau;

    //<inheritdoc/>
    public string Name { get; } = "Palau";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Palau";

    //<inheritdoc/>
    public string NativeName => "Belau";

    //<inheritdoc/>
    public string Capital { get; } = "Ngerulmud";

    //<inheritdoc/>
    public int NumericCode { get; } = 585;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PW";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PLW";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+680"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Aimeliik", "PW-002", "State"),
        new("Airai", "PW-004", "State"),
        new("Angaur", "PW-010", "State"),
        new("Hatohobei", "PW-050", "State"),
        new("Kayangel", "PW-100", "State"),
        new("Koror", "PW-150", "State"),
        new("Melekeok", "PW-212", "State"),
        new("Ngaraard", "PW-214", "State"),
        new("Ngarchelong", "PW-218", "State"),
        new("Ngardmau", "PW-222", "State"),
        new("Ngatpang", "PW-224", "State"),
        new("Ngchesar", "PW-226", "State"),
        new("Ngeremlengui", "PW-227", "State"),
        new("Ngiwal", "PW-228", "State"),
        new("Peleliu", "PW-350", "State"),
        new("Sonsorol", "PW-370", "State")
    ];
}
