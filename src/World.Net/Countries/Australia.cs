namespace World.Net.Countries;

internal sealed class Australia : ICountry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.Australia;

    ///<inheritdoc/>
    public string Name => nameof(Australia);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Commonwealth of Australia";

    ///<inheritdoc/>
    public string NativeName { get; } = "Australia";

    ///<inheritdoc/>
    public string Capital { get; } = "Canberra";

    ///<inheritdoc/>
    public int NumericCode { get; } = 036;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AU";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "AUS";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+61";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Australian Capital Territory", "AU-ACT", "Territory"),
        new("New South Wales", "AU-NSW", "State"),
        new("Northern Territory", "AU-NT", "Territory"),
        new("Queensland", "AU-QLD", "State"),
        new("South Australia", "AU-SA", "State"),
        new("Tasmania", "AU-TAS", "State"),
        new("Victoria", "AU-VIC", "State"),
        new("Western Australia", "AU-WA", "State"),
    ];
}
