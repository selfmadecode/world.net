namespace World.Net.Countries;

internal sealed class Barbados : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Barbados;

    ///<inheritdoc/>
    public string Name => nameof(Barbados);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Barbados";

    ///<inheritdoc/>
    public string NativeName { get; } = "Barbados";

    ///<inheritdoc/>
    public string Capital { get; } = "Bridgetown";

    ///<inheritdoc/>
    public int NumericCode { get; } = 052;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "BB";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "BRB";

    ///<inheritdoc/>
    public string[] CallingCode { get; } = ["+1-246"];

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Christ Church", "BB-01", "Parish"),
        new("Saint Andrew", "BB-02", "Parish"),
        new("Saint George", "BB-03", "Parish"),
        new("Saint James", "BB-04", "Parish"),
        new("Saint John", "BB-05", "Parish"),
        new("Saint Joseph", "BB-06", "Parish"),
        new("Saint Lucy", "BB-07", "Parish"),
        new("Saint Michael", "BB-08", "Parish"),
        new("Saint Peter", "BB-09", "Parish"),
        new("Saint Philip", "BB-10", "Parish"),
        new("Saint Thomas", "BB-11", "Parish")
    ];
}
