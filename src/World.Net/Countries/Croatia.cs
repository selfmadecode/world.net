namespace World.Net.Countries;

internal sealed class Croatia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Croatia;

    //<inheritdoc/>
    public string Name { get; } = "Croatia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Croatia";

    //<inheritdoc/>
    public string NativeName => "Hrvatska";

    //<inheritdoc/>
    public string Capital { get; } = "Zagreb";

    //<inheritdoc/>
    public int NumericCode { get; } = 191;

    //<inheritdoc/>
    public string ISO2Code { get; } = "HR";

    //<inheritdoc/>
    public string ISO3Code { get; } = "HRV";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+385"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Bjelovar-Bilogora", "HR-07", "County"),
        new("Brod-Posavina", "HR-12", "County"),
        new("Dubrovnik-Neretva", "HR-19", "County"),
        new("Istria", "HR-18", "County"),
        new("Karlovac", "HR-04", "County"),
        new("Koprivnica-Križevci", "HR-06", "County"),
        new("Krapina-Zagorje", "HR-02", "County"),
        new("Lika-Senj", "HR-09", "County"),
        new("Međimurje", "HR-20", "County"),
        new("Osijek-Baranja", "HR-14", "County"),
        new("Požega-Slavonia", "HR-11", "County"),
        new("Primorje-Gorski Kotar", "HR-08", "County"),
        new("Šibenik-Knin", "HR-15", "County"),
        new("Sisak-Moslavina", "HR-03", "County"),
        new("Split-Dalmatia", "HR-17", "County"),
        new("Varaždin", "HR-05", "County"),
        new("Virovitica-Podravina", "HR-10", "County"),
        new("Vukovar-Syrmia", "HR-16", "County"),
        new("Zadar", "HR-13", "County"),
        new("Zagreb", "HR-21", "City"),
        new("Zagreb County", "HR-01", "County")
    ];
}
