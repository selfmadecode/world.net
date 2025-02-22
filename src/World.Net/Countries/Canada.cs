namespace World.Net.Countries;

internal sealed class Canada : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Canada;

    //<inheritdoc/>
    public string Name { get; } = "Canada";

    //<inheritdoc/>
    public string OfficialName { get; } = "Canada";

    //<inheritdoc/>
    public string NativeName => "Canada";

    //<inheritdoc/>
    public string Capital { get; } = "Ottawa";

    //<inheritdoc/>
    public int NumericCode { get; } = 124;

    //<inheritdoc/>
    public string ISO2Code { get; } = "CA";

    //<inheritdoc/>
    public string ISO3Code { get; } = "CAN";

    //<inheritdoc/>
    public string CallingCode { get; } = "+1";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Alberta", "AB"),
        new("British Columbia", "BC"),
        new("Manitoba", "MB"),
        new("New Brunswick", "NB"),
        new("Newfoundland and Labrador", "NL"),
        new("Northwest Territories", "NT", "Territory"),
        new("Nova Scotia", "NS"),
        new("Nunavut", "NU", "Territory"),
        new("Ontario", "ON"),
        new("Prince Edward Island", "PE"),
        new("Quebec", "QC"),
        new("Saskatchewan", "SK"),
        new("Yukon", "YT", "Territory")
    ];
}
