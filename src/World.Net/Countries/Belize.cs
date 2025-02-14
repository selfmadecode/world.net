namespace World.Net.Countries;

internal sealed class Belize : ICountry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.Belize;

    ///<inheritdoc/>
    public string Name => nameof(Belize);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Belize";

    ///<inheritdoc/>
    public string NativeName { get; } = "Belize";

    ///<inheritdoc/>
    public string Capital { get; } = "Belmopan";

    ///<inheritdoc/>
    public int NumericCode { get; } = 084;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "BZ";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "BLZ";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+501";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Belize", "BZ", "District"),
        new("Cayo", "CY", "District"),
        new("Corozal", "CZL", "District"),
        new("Orange Walk", "OW", "District"),
        new("Stann Creek", "SC", "District"),
        new("Toledo", "TOL", "District")
    ];
}
