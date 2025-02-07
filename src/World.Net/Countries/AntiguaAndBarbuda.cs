
namespace World.Net.Countries;

internal sealed class AntiguaAndBarbuda : ICountry, ICountryRegistry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.AntiguaAndBarbuda;

    ///<inheritdoc/>
    public string Name => "Antigua and Barbuda";

    ///<inheritdoc/>
    public string OfficialName { get; } = "Antigua and Barbuda";

    ///<inheritdoc/>
    public string NativeName { get; } = "Antigua and Barbuda";

    ///<inheritdoc/>
    public string Capital { get; } = "St. John's";

    ///<inheritdoc/>
    public int NumericCode { get; } = 028;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AG";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "ATG";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+1";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Barbuda", "AG-10", "Dependency"),
        new("Redonda", "AG-11", "Dependency"),
        new("Saint George", "AG-03", "Parish"),
        new("Saint John", "AG-04", "Parish"),
        new("Saint Mary", "AG-05", "Parish"),
        new("Saint Paul", "AG-06", "Parish"),
        new("Saint Peter", "AG-07", "Parish"),
        new("Saint Philip", "AG-08", "Parish")
    ];

    public Dictionary<int, ICountry> GetCountry()
    {
        return new Dictionary<int, ICountry>
        {
            { CountryIdentifier.AntiguaAndBarbuda, new AntiguaAndBarbuda() }
        };
    }
}
