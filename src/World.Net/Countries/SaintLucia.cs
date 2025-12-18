namespace World.Net.Countries;

internal sealed class SaintLucia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SaintLucia;

    //<inheritdoc/>
    public string Name { get; } = "Saint Lucia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Saint Lucia";

    //<inheritdoc/>
    public string NativeName => "Saint Lucia";

    //<inheritdoc/>
    public string Capital { get; } = "Castries";

    //<inheritdoc/>
    public int NumericCode { get; } = 662;

    //<inheritdoc/>
    public string ISO2Code { get; } = "LC";

    //<inheritdoc/>
    public string ISO3Code { get; } = "LCA";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+1-758"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Anse la Raye", "LC-01", "District"),
        new("Canaries", "LC-02", "District"),
        new("Castries", "LC-03", "District"),
        new("Choiseul", "LC-04", "District"),
        new("Dennery", "LC-05", "District"),
        new("Gros Islet", "LC-06", "District"),
        new("Laborie", "LC-07", "District"),
        new("Micoud", "LC-08", "District"),
        new("Praslin", "LC-09", "District"),
        new("Soufriere", "LC-10", "District"),
        new("Vieux Fort", "LC-11", "District")
    ];
}

