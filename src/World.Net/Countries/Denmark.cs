namespace World.Net.Countries;
internal sealed class Denmark : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Denmark;

    ///<inheritdoc/>
    public string Name => nameof(Denmark);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Kingdom of Denmark";

    ///<inheritdoc/>
    public string NativeName { get; } = "Danmark";

    ///<inheritdoc/>
    public string Capital { get; } = "Copenhagen";

    ///<inheritdoc/>
    public int NumericCode { get; } = 208;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "DK";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "DNK";

    ///<inheritdoc/>
    public string[] CallingCode { get; } = ["+45"];

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Central Denmark", "DK-82", "Region"),
        new("Capital Region of Denmark", "DK-84", "Region"),
        new("North Denmark", "DK-81", "Region"),
        new("Southern Denmark", "DK-83", "Region"),
        new("Zealand", "DK-85", "Region"),
    ];
}
