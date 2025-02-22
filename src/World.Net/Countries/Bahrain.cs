namespace World.Net.Countries;

internal sealed class Bahrain : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Bahrain;

    //<inheritdoc/>
    public string Name { get; } = "Bahrain";

    //<inheritdoc/>
    public string OfficialName { get; } = "Kingdom of Bahrain";

    //<inheritdoc/>
    public string NativeName { get; } = "البحرين";

    //<inheritdoc/>
    public string Capital { get; } = "Manama";

    //<inheritdoc/>
    public int NumericCode { get; } = 048;

    //<inheritdoc/>
    public string ISO2Code { get; } = "BH";

    //<inheritdoc/>
    public string ISO3Code { get; } = "BHR";

    //<inheritdoc/>
    public string CallingCode { get; } = "+973";

    //<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Capital", "13", "Governorate"),
        new("Central", "16", "Governorate"),
        new("Muharraq", "15", "Governorate"),
        new("Northern", "17", "Governorate"),
        new("Southern", "14", "Governorate")
    ];
}
