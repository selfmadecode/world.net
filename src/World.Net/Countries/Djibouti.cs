namespace World.Net.Countries;
internal sealed class Djibouti : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Djibouti;

    ///<inheritdoc/>
    public string Name => nameof(Djibouti);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Republic of Djibouti";

    ///<inheritdoc/>
    public string NativeName { get; } = "Djibouti";

    ///<inheritdoc/>
    public string Capital { get; } = "Djibouti";

    ///<inheritdoc/>
    public int NumericCode { get; } = 262;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "DJ";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "DJI";

    ///<inheritdoc/>
    public string[] CallingCode { get; } = ["+253"];

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Ali Sabieh", "DJ-AS", "Region"),
        new("Arta", "DJ-AR", "Region"),
        new("Dikhil", "DJ-DI", "Region"),
        new("Djibouti", "DJ-DJ", "City"),
        new("Obock", "DJ-OB", "Region"),
        new("Tadjourah", "DJ-TA", "Region"),
    ];
}
