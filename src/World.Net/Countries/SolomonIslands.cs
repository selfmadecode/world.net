namespace World.Net.Countries;

internal sealed class SolomonIslands : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.SolomonIslands;

    //<inheritdoc/>
    public string Name { get; } = "Solomon Islands";

    //<inheritdoc/>
    public string OfficialName { get; } = "Solomon Islands";

    //<inheritdoc/>
    public string NativeName => "Solomon Islands";

    //<inheritdoc/>
    public string Capital { get; } = "Honiara";

    //<inheritdoc/>
    public int NumericCode { get; } = 90;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SB";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SLB";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+677"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Central Province", "SB-CE", "Province"),
        new State("Choiseul Province", "SB-CH", "Province"),
        new State("Guadalcanal Province", "SB-GU", "Province"),
        new State("Isabel Province", "SB-IS", "Province"),
        new State("Makira-Ulawa Province", "SB-MK", "Province"),
        new State("Malaita Province", "SB-ML", "Province"),
        new State("Rennell and Bellona Province", "SB-RB", "Province"),
        new State("Temotu Province", "SB-TE", "Province"),
        new State("Western Province", "SB-WE", "Province"),
        new State("Capital Territory (Honiara)", "SB-CT", "Capital Territory")
    };
}

