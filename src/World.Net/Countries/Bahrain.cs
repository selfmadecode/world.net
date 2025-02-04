namespace World.Net.Countries;

internal sealed class Bahrain : ICountry
{
    public int Id => CountryIdentifier.Bahrain;

    public string Name { get; } = "Bahrain";

    public string OfficialName { get; } = "Kingdom of Bahrain";

    public string NativeName { get; } = "البحرين";

    public string Capital { get; } = "Manama";

    public int NumericCode { get; } = 048;

    public string ISO2Code { get; } = "BH";

    public string ISO3Code { get; } = "BHR";

    public string CallingCode { get; } = "+973";

    public IEnumerable<State> States { get; } =
    [
        new("Capital", "13", "Governorate"),
        new("Central", "16", "Governorate"),
        new("Muharraq", "15", "Governorate"),
        new("Northern", "17", "Governorate"),
        new("Southern", "14", "Governorate")
    ];
}
