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
        new("Belize", "BZ-BZ", "District"),
        new("Cayo", "BZ-CY", "District"),
        new("Corozal", "BZ-CZL", "District"),
        new("Orange Walk", "BZ-OW", "District"),
        new("Stann Creek", "BZ-SC", "District"),
        new("Toledo", "BZ-TOL", "District")
    ];
}
