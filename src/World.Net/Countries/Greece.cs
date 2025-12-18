namespace World.Net.Countries;

internal sealed class Greece : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Greece;

    //<inheritdoc/>
    public string Name { get; } = "Greece";

    //<inheritdoc/>
    public string OfficialName { get; } = "Hellenic Republic";

    //<inheritdoc/>
    public string NativeName => "Ελλάδα";

    //<inheritdoc/>
    public string Capital { get; } = "Athens";

    //<inheritdoc/>
    public int NumericCode { get; } = 300;

    //<inheritdoc/>
    public string ISO2Code { get; } = "GR";

    //<inheritdoc/>
    public string ISO3Code { get; } = "GRC";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+30"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Attica", "GR-I", "Region"),
        new("Central Greece", "GR-H", "Region"),
        new("Central Macedonia", "GR-B", "Region"),
        new("Crete", "GR-M", "Region"),
        new("Eastern Macedonia and Thrace", "GR-A", "Region"),
        new("Epirus", "GR-D", "Region"),
        new("Ionian Islands", "GR-F", "Region"),
        new("North Aegean", "GR-K", "Region"),
        new("Peloponnese", "GR-J", "Region"),
        new("South Aegean", "GR-L", "Region"),
        new("Thessaly", "GR-E", "Region"),
        new("Western Greece", "GR-G", "Region"),
        new("Western Macedonia", "GR-C", "Region")
    ];
}
