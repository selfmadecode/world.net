namespace World.Net.Countries;

internal sealed class Mali : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Mali;

    public string Name { get; } = "Mali";

    public string OfficialName { get; } = "Republic of Mali";

    public string NativeName => "Mali";

    public string Capital { get; } = "Bamako";

    public int NumericCode { get; } = 466;

    public string ISO2Code { get; } = "ML";

    public string ISO3Code { get; } = "MLI";

    public string[] CallingCode { get; } = ["+223"];

    public IEnumerable<State> States => new[]
    {
        new State("Bamako", "ML-BKO", "District"),
        new State("Gao", "ML-7", "Region"),
        new State("Kayes", "ML-1", "Region"),
        new State("Kidal", "ML-8", "Region"),
        new State("Koulikoro", "ML-2", "Region"),
        new State("Mopti", "ML-5", "Region"),
        new State("Ségou", "ML-4", "Region"),
        new State("Sikasso", "ML-3", "Region"),
        new State("Tombouctou", "ML-6", "Region")
    };
}

