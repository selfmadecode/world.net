namespace World.Net.Countries;

internal sealed class Palestine : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.PalestinianTerritoryOccupied;

    //<inheritdoc/>
    public string Name { get; } = "Palestinian Territory, Occupied";

    //<inheritdoc/>
    public string OfficialName { get; } = "State of Palestine";

    //<inheritdoc/>
    public string NativeName => "دولة فلسطين";

    //<inheritdoc/>
    public string Capital { get; } = "Ramallah";

    //<inheritdoc/>
    public int NumericCode { get; } = 275;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PS";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PSE";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+970"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Gaza", "PS-GA", "Governorate"),
        new("West Bank", "PS-WB", "Governorate")
    ];
}
