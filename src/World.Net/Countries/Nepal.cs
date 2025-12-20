namespace World.Net.Countries;

internal sealed class Nepal : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Nepal;

    public string Name { get; } = "Nepal";

    public string OfficialName { get; } = "Federal Democratic Republic of Nepal";

    public string NativeName => "नेपाल";

    public string Capital { get; } = "Kathmandu";

    public int NumericCode { get; } = 524;

    public string ISO2Code { get; } = "NP";

    public string ISO3Code { get; } = "NPL";

    public string[] CallingCode { get; } = ["+977"];

    public IEnumerable<State> States => new[]
    {
        new State("Koshi", "NP-P1", "Province"),
        new State("Madhesh", "NP-P2", "Province"),
        new State("Bagmati", "NP-P3", "Province"),
        new State("Gandaki", "NP-P4", "Province"),
        new State("Lumbini", "NP-P5", "Province"),
        new State("Karnali", "NP-P6", "Province"),
        new State("Sudurpashchim", "NP-P7", "Province")
    };
}
