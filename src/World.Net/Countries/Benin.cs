namespace World.Net.Countries;

internal sealed class Benin : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Benin;

    ///<inheritdoc/>
    public string Name => nameof(Benin);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Republic of Benin";

    ///<inheritdoc/>
    public string NativeName { get; } = "Bénin";

    ///<inheritdoc/>
    public string Capital { get; } = "Porto-Novo";

    ///<inheritdoc/>
    public int NumericCode { get; } = 204;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "BJ";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "BEN";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+229";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Alibori", "AL", "Department"),
        new("Atakora", "AK", "Department"),
        new("Atlantique", "AT", "Department"),
        new("Borgou", "BO", "Department"),
        new("Collines", "CO", "Department"),
        new("Donga", "DO", "Department"),
        new("Kouffo", "KO", "Department"),
        new("Littoral", "LI", "Department"),
        new("Mono", "MO", "Department"),
        new("Ouémé", "OU", "Department"),
        new("Plateau", "PL", "Department"),
        new("Zou", "ZO", "Department")
    ];
}
