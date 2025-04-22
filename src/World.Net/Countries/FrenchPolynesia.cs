namespace World.Net.Countries;
internal sealed class FrenchPolynesia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.FrenchPolynesia;

    //<inheritdoc/>
    public string Name { get; } = "French Polynesia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Polynésie française";

    //<inheritdoc/>
    public string NativeName => "Polynésie française";

    //<inheritdoc/>
    public string Capital { get; } = "Papeete";

    //<inheritdoc/>
    public int NumericCode { get; } = 258;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PF";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PYF";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+689"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("N'Austral Islands", "PF-01", "division"),
        new("Leeward Islands", "PF-02", "division"),
        new("Marquesas Islands", "PF-03", "division"),
        new("Tuamotu-Gambier", "PF-04", "division"),
        new("Windward Islands", "PF-05", "division"),
    ];
}
