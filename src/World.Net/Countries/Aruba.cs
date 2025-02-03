namespace World.Net.Countries;

internal sealed class Aruba : ICountry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.Aruba;

    ///<inheritdoc/>
    public string Name => nameof(Aruba);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Country of Aruba";

    ///<inheritdoc/>
    public string NativeName { get; } = "Aruba";

    ///<inheritdoc/>
    public string Capital { get; } = "Oranjestad";

    ///<inheritdoc/>
    public int NumericCode { get; } = 533;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AW";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "ABW";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+297";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Noord", "AW-NO", "Region"),
        new("Oranjestad East", "AW-OE", "Region"),
        new("Oranjestad West", "AW-OW", "Region"),
        new("Paradera", "AW-PA", "Region"),
        new("San Nicolaas Noord", "AW-SNN", "Region"),
        new("San Nicolaas Zuid", "AW-SNZ", "Region"),
        new("Santa Cruz", "AW-SC", "Region"),
        new("Savaneta", "AW-SA", "Region"),
    ];
}
