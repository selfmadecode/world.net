namespace World.Net.Countries;

internal sealed class Benin : ICountry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.Benin;

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
        new("Alibori", "BJ-AL", "Department"),
        new("Atakora", "BJ-AK", "Department"),
        new("Atlantique", "BJ-AT", "Department"),
        new("Borgou", "BJ-BO", "Department"),
        new("Collines", "BJ-CO", "Department"),
        new("Donga", "BJ-DO", "Department"),
        new("Kouffo", "BJ-KO", "Department"),
        new("Littoral", "BJ-LI", "Department"),
        new("Mono", "BJ-MO", "Department"),
        new("Ouémé", "BJ-OU", "Department"),
        new("Plateau", "BJ-PL", "Department"),
        new("Zou", "BJ-ZO", "Department")
    ];
}
