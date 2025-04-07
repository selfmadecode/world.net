namespace World.Net.Countries;

internal sealed class Burundi : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Burundi;

    //<inheritdoc/>
    public string Name { get; } = "Burundi";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Burundi";

    //<inheritdoc/>
    public string NativeName => "Uburundi";

    //<inheritdoc/>
    public string Capital { get; } = "Gitega";

    //<inheritdoc/>
    public int NumericCode { get; } = 108;

    //<inheritdoc/>
    public string ISO2Code { get; } = "BI";

    //<inheritdoc/>
    public string ISO3Code { get; } = "BDI";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+257"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Bubanza", "BB"),
        new("Bujumbura Mairie", "BM"),
        new("Bujumbura Rural", "BR"),
        new("Bururi", "BU"),
        new("Cankuzo", "CA"),
        new("Cibitoke", "CI"),
        new("Gitega", "GI"),
        new("Karuzi", "KR"),
        new("Kayanza", "KY"),
        new("Kirundo", "KI"),
        new("Makamba", "MA"),
        new("Muramvya", "MU"),
        new("Muyinga", "MY"),
        new("Mwaro", "MW"),
        new("Ngozi", "NG"),
        new("Rumonge", "RM"),
        new("Rutana", "RT"),
        new("Ruyigi", "RY")
    ];
}
