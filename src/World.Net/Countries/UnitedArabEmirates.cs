namespace World.Net.Countries;

internal sealed class UnitedArabEmirates : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.UnitedArabEmirates;

    public string Name { get; } = "United Arab Emirates";

    public string OfficialName { get; } = "United Arab Emirates";

    public string NativeName => "الإمارات العربية المتحدة";

    public string Capital { get; } = "Abu Dhabi";

    public int NumericCode { get; } = 784;

    public string ISO2Code { get; } = "AE";

    public string ISO3Code { get; } = "ARE";

    public string[] CallingCode { get; } = ["+971"];

    public IEnumerable<State> States => new[]
    {
        new State("Abu Dhabi", "AE-AZ", "Emirate"),
        new State("Ajman", "AE-AJ", "Emirate"),
        new State("Dubai", "AE-DU", "Emirate"),
        new State("Fujairah", "AE-FU", "Emirate"),
        new State("Ras Al Khaimah", "AE-RK", "Emirate"),
        new State("Sharjah", "AE-SH", "Emirate"),
        new State("Umm Al Quwain", "AE-UQ", "Emirate")
    };
}

