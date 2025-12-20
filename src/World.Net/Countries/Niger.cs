namespace World.Net.Countries;

internal sealed class Niger : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Niger;

    public string Name { get; } = "Niger";

    public string OfficialName { get; } = "Republic of the Niger";

    public string NativeName => "Niger";

    public string Capital { get; } = "Niamey";

    public int NumericCode { get; } = 562;

    public string ISO2Code { get; } = "NE";

    public string ISO3Code { get; } = "NER";

    public string[] CallingCode { get; } = ["+227"];

    public IEnumerable<State> States => new[]
    {
        new State("Agadez", "NE-1", "Region"),
        new State("Diffa", "NE-2", "Region"),
        new State("Dosso", "NE-3", "Region"),
        new State("Maradi", "NE-4", "Region"),
        new State("Tahoua", "NE-5", "Region"),
        new State("Tillabéri", "NE-6", "Region"),
        new State("Zinder", "NE-7", "Region"),
        new State("Niamey", "NE-8", "Capital District")
    };
}

