namespace World.Net.Countries;

internal sealed class WallisAndFutuna : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.WallisAndFutunaIslands;

    public string Name { get; } = "Wallis and Futuna";

    public string OfficialName { get; } = "Territory of the Wallis and Futuna Islands";

    public string NativeName => "Wallis et Futuna";

    public string Capital { get; } = "Mata-Utu";

    public int NumericCode { get; } = 876;

    public string ISO2Code { get; } = "WF";

    public string ISO3Code { get; } = "WLF";

    public string[] CallingCode { get; } = ["+681"];

    public IEnumerable<State> States => new[]
    {
        new State("Alo", "WF-AL", "District"),
        new State("Sigave", "WF-SG", "District"),
        new State("Uvea", "WF-UV", "District")
    };
}

