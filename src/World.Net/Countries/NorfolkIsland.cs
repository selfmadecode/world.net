namespace World.Net.Countries;

internal sealed class NorfolkIsland : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.NorfolkIsland;

    //<inheritdoc/>
    public string Name { get; } = "Norfolk Island";

    //<inheritdoc/>
    public string OfficialName { get; } = "Territory of Norfolk Island";

    //<inheritdoc/>
    public string NativeName => "Norfolk Island";

    //<inheritdoc/>
    public string Capital { get; } = "Kingston";

    //<inheritdoc/>
    public int NumericCode { get; } = 574;

    //<inheritdoc/>
    public string ISO2Code { get; } = "NF";

    //<inheritdoc/>
    public string ISO3Code { get; } = "NFK";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+672"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Anson Bay", "NF-01", "Settlement"),
        new("Ball Bay", "NF-02", "Settlement"),
        new("Bicentennial", "NF-03", "Settlement"),
        new("Burnt Pine", "NF-04", "Settlement"),
        new("Cascade", "NF-05", "Settlement"),
        new("Kingston", "NF-06", "Settlement"),
        new("Longridge", "NF-07", "Settlement"),
        new("Mount Pitt", "NF-08", "Settlement"),
        new("Queen Elizabeth", "NF-09", "Settlement"),
        new("Royal", "NF-10", "Settlement"),
        new("Suffolk", "NF-11", "Settlement")
    ];
}
