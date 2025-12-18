namespace World.Net.Countries;

internal sealed class Grenada : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Grenada;

    //<inheritdoc/>
    public string Name { get; } = "Grenada";

    //<inheritdoc/>
    public string OfficialName { get; } = "Grenada";

    //<inheritdoc/>
    public string NativeName => "Grenada";

    //<inheritdoc/>
    public string Capital { get; } = "St. George's";

    //<inheritdoc/>
    public int NumericCode { get; } = 308;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GD";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GRD";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+1-473"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Saint Andrew", "GD-01", "Parish"),
        new("Saint David", "GD-02", "Parish"),
        new("Saint George", "GD-03", "Parish"),
        new("Saint John", "GD-04", "Parish"),
        new("Saint Mark", "GD-05", "Parish"),
        new("Saint Patrick", "GD-06", "Parish"),
        new("Carriacou and Petite Martinique", "GD-10", "Dependency")
    ];
}
