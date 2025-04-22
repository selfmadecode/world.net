namespace World.Net.Countries;
internal sealed class Dominica : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Dominica;

    ///<inheritdoc/>
    public string Name => nameof(Dominica);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Commonwealth of Dominica";

    ///<inheritdoc/>
    public string NativeName { get; } = "Dominica";

    ///<inheritdoc/>
    public string Capital { get; } = "Roseau";

    ///<inheritdoc/>
    public int NumericCode { get; } = 212;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "DM";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "DMA";

    ///<inheritdoc/>
    public string[] CallingCode { get; } = ["+1"];

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Saint Andrew", "DM-02", "Parish"),
        new("Saint David", "DM-03", "Parish"),
        new("Saint George", "DM-04", "Parish"),
        new("Saint John", "DM-05", "Parish"),
        new("Saint Joseph", "DM-06", "Parish"),
        new("Saint Luke", "DM-07", "Parish"),
        new("Saint Mark", "DM-08", "Parish"),
        new("Saint Patrick", "DM-09", "Parish"),
        new("Saint Paul", "DM-10", "Parish"),
        new("Saint Peter", "DM-11", "Parish"),
    ];
}
