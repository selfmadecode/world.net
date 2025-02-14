
namespace World.Net.Countries;

internal sealed class Armenia : ICountry, ICountryRegistry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.Armenia;

    ///<inheritdoc/>
    public string Name => nameof(Armenia);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Armenia";

    ///<inheritdoc/>
    public string NativeName { get; } = "Հայաստան";

    ///<inheritdoc/>
    public string Capital { get; } = "Yerevan";

    ///<inheritdoc/>
    public int NumericCode { get; } = 051;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AM";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "ARM";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+374";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Aragatsotn", "AM-AG", "Region"),
        new("Ararat", "AM-AR", "Region"),
        new("Armavir", "AM-AV", "Region"),
        new("Gegharkunik", "AM-GR", "Region"),
        new("Kotayk", "AM-KT", "Region"),
        new("Lori", "AM-LO", "Region"),
        new("Shirak", "AM-SH", "Region"),
        new("Syunik", "AM-SU", "Region"),
        new("Tavush", "AM-TV", "Region"),
        new("Vayots Dzor", "AM-VD", "Region"),
        new("Yerevan", "AM-ER", "City"),
    ];

    public Dictionary<int, ICountry> GetCountry()
    {
        return new Dictionary<int, ICountry>
        {
            { CountryIdentifier.Armenia, new Armenia() }
        };
    }
}
