namespace World.Net.Countries;

internal sealed class PitcairnIslands : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.PitcairnIsland;

    //<inheritdoc/>
    public string Name { get; } = "Pitcairn Islands";

    //<inheritdoc/>
    public string OfficialName { get; } = "Pitcairn, Henderson, Ducie and Oeno Islands";

    //<inheritdoc/>
    public string NativeName => "Pitcairn Islands";

    //<inheritdoc/>
    public string Capital { get; } = "Adamstown";

    //<inheritdoc/>
    public int NumericCode { get; } = 612;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PN";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PCN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+64"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Pitcairn Island", "PN-PI", "Island")
    ];
}

