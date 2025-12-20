namespace World.Net.Countries;

internal sealed class Mauritania : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Mauritania;

    public string Name { get; } = "Mauritania";

    public string OfficialName { get; } = "Islamic Republic of Mauritania";

    public string NativeName => "الجمهورية الإسلامية الموريتانية";

    public string Capital { get; } = "Nouakchott";

    public int NumericCode { get; } = 478;

    public string ISO2Code { get; } = "MR";

    public string ISO3Code { get; } = "MRT";

    public string[] CallingCode { get; } = ["+222"];

    public IEnumerable<State> States => new[]
    {
        new State("Adrar", "MR-07", "Region"),
        new State("Assaba", "MR-03", "Region"),
        new State("Brakna", "MR-05", "Region"),
        new State("Dakhlet Nouadhibou", "MR-08", "Region"),
        new State("Gorgol", "MR-04", "Region"),
        new State("Guidimaka", "MR-10", "Region"),
        new State("Hodh Ech Chargui", "MR-01", "Region"),
        new State("Hodh El Gharbi", "MR-02", "Region"),
        new State("Inchiri", "MR-12", "Region"),
        new State("Nouakchott Nord", "MR-14", "Region"),
        new State("Nouakchott Ouest", "MR-13", "Region"),
        new State("Nouakchott Sud", "MR-15", "Region"),
        new State("Tagant", "MR-09", "Region"),
        new State("Tiris Zemmour", "MR-11", "Region"),
        new State("Trarza", "MR-06", "Region")
    };
}

