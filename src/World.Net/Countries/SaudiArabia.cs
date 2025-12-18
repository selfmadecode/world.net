namespace World.Net.Countries;

internal sealed class SaudiArabia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SaudiArabia;

    //<inheritdoc/>
    public string Name { get; } = "Saudi Arabia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Kingdom of Saudi Arabia";

    //<inheritdoc/>
    public string NativeName => "المملكة العربية السعودية";

    //<inheritdoc/>
    public string Capital { get; } = "Riyadh";

    //<inheritdoc/>
    public int NumericCode { get; } = 682;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SA";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SAU";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+966"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Riyadh", "SA-01", "Region"),
        new("Makkah", "SA-02", "Region"),
        new("Al Madinah", "SA-03", "Region"),
        new("Eastern Province", "SA-04", "Region"),
        new("Asir", "SA-05", "Region"),
        new("Tabuk", "SA-07", "Region"),
        new("Hail", "SA-06", "Region"),
        new("Northern Borders", "SA-08", "Region"),
        new("Jazan", "SA-09", "Region"),
        new("Najran", "SA-10", "Region"),
        new("Al Bahah", "SA-11", "Region"),
        new("Al Jawf", "SA-12", "Region"),
        new("Qassim", "SA-14", "Region")
    ];
}
