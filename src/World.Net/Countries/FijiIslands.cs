namespace World.Net.Countries;

internal sealed class FijiIslands : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.FijiIslands;

    //<inheritdoc/>
    public string Name { get; } = "Fiji";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Fiji";

    //<inheritdoc/>
    public string NativeName => "Matanitu ko Viti";

    //<inheritdoc/>
    public string Capital { get; } = "Suva";

    //<inheritdoc/>
    public int NumericCode { get; } = 242;

    //<inheritdoc/>
    public string ISO2Code { get; } = "FJ";

    //<inheritdoc/>
    public string ISO3Code { get; } = "FJI";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+679"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Ba", "FJ-01"),
        new("Bua", "FJ-02"),
        new("Cakaudrove", "FJ-03"),
        new("Kadavu", "FJ-04"),
        new("Lau", "FJ-05"),
        new("Lomaiviti", "FJ-06"),
        new("Macuata", "FJ-07"),
        new("Nadroga-Navosa", "FJ-08"),
        new("Naitasiri", "FJ-09"),
        new("Namosi", "FJ-10"),
        new("Ra", "FJ-11"),
        new("Rewa", "FJ-12"),
        new("Serua", "FJ-13"),
        new("Tailevu", "FJ-14"),
        new("Rotuma", "FJ-15", "Dependency")
    ];
}
