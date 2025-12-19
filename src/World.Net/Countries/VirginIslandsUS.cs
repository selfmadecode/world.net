namespace World.Net.Countries;

internal sealed class VirginIslandsUS : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.VirginIslandsUS;

    public string Name { get; } = "Virgin Islands (US)";

    public string OfficialName { get; } = "United States Virgin Islands";

    public string NativeName => "United States Virgin Islands";

    public string Capital { get; } = "Charlotte Amalie";

    public int NumericCode { get; } = 850;

    public string ISO2Code { get; } = "VI";

    public string ISO3Code { get; } = "VIR";

    public string[] CallingCode { get; } = ["+1-340"];

    public IEnumerable<State> States => Array.Empty<State>();
}

