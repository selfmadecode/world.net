namespace World.Net.Countries;

internal sealed class Kiribati : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Kiribati;
    public string Name => "Kiribati";
    public string OfficialName => "Republic of Kiribati";
    public string NativeName => "Kiribati";
    public string Capital => "South Tarawa";
    public int NumericCode => 296;
    public string ISO2Code => "KI";
    public string ISO3Code => "KIR";
    public string[] CallingCode => ["+686"];
    public IEnumerable<State> States =>
    [
        new("Gilbert Islands", "KI-G", "Group"),
        new("Line Islands", "KI-L", "Group"),
        new("Phoenix Islands", "KI-P", "Group")
    ];
}
