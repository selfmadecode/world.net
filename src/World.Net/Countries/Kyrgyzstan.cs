namespace World.Net.Countries;

internal sealed class Kyrgyzstan : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Kyrgyzstan;
    public string Name { get; } = "Kyrgyzstan";
    public string OfficialName { get; } = "Kyrgyz Republic";
    public string NativeName { get; } = "?????? ????????????";
    public string Capital { get; } = "Bishkek";
    public int NumericCode { get; } = 417;
    public string ISO2Code { get; } = "KG";
    public string ISO3Code { get; } = "KGZ";
    public string[] CallingCode { get; } = ["+996"];
    public IEnumerable<State> States { get; } =
    [
        new State("Batken", "KG-B", "Region"),
        new State("Chuy", "KG-C", "Region"),
        new State("Jalal-Abad", "KG-J", "Region"),
        new State("Naryn", "KG-N", "Region"),
        new State("Osh", "KG-O", "Region"),
        new State("Talas", "KG-T", "Region"),
        new State("Ysyk-Kol", "KG-Y", "Region"),
        new State("Bishkek", "KG-GB", "City"),
        new State("Osh City", "KG-GO", "City")
    ];
}
