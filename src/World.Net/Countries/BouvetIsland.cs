namespace World.Net.Countries;
internal sealed class BouvetIsland : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.BouvetIsland;

    ///<inheritdoc/>
    public string Name => "Bouvet Island";

    ///<inheritdoc/>
    public string OfficialName { get; } = "Bouvetøya";

    ///<inheritdoc/>
    public string NativeName { get; } = "Bouvetøya";

    ///<inheritdoc/>
    public string Capital { get; } = "";

    ///<inheritdoc/>
    public int NumericCode { get; } = 074;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "BV";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "BVT";

    ///<inheritdoc/>
    public string[] CallingCode { get; } = ["+0055"];

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [

    ];
}
