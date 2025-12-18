namespace World.Net.Countries;

internal sealed class Niue : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Niue;

    //<inheritdoc/>
    public string Name { get; } = "Niue";

    //<inheritdoc/>
    public string OfficialName { get; } = "Niue";

    //<inheritdoc/>
    public string NativeName => "Niuē";

    //<inheritdoc/>
    public string Capital { get; } = "Alofi";

    //<inheritdoc/>
    public int NumericCode { get; } = 570;

    //<inheritdoc/>
    public string ISO2Code { get; } = "NU";

    //<inheritdoc/>
    public string ISO3Code { get; } = "NIU";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+683"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Alofi North", "NU-01", "Village"),
        new("Alofi South", "NU-02", "Village"),
        new("Avatele", "NU-03", "Village"),
        new("Hakupu", "NU-04", "Village"),
        new("Hikutavake", "NU-05", "Village"),
        new("Lakepa", "NU-06", "Village"),
        new("Liku", "NU-07", "Village"),
        new("Makefu", "NU-08", "Village"),
        new("Mutalau", "NU-09", "Village"),
        new("Namukulu", "NU-10", "Village"),
        new("Talava", "NU-11", "Village"),
        new("Toi", "NU-12", "Village"),
        new("Tufukia", "NU-13", "Village"),
        new("Vaiea", "NU-14", "Village")
    ];
}

