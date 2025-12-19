namespace World.Net.Countries;

internal sealed class Togo : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Togo;

    public string Name { get; } = "Togo";

    public string OfficialName { get; } = "Togolese Republic";

    public string NativeName => "Togo";

    public string Capital { get; } = "Lomé";

    public int NumericCode { get; } = 768;

    public string ISO2Code { get; } = "TG";

    public string ISO3Code { get; } = "TGO";

    public string[] CallingCode { get; } = ["+228"];

    public IEnumerable<State> States => new[]
    {
        new State("Centrale", "TG-C", "Region"),
        new State("Kara", "TG-K", "Region"),
        new State("Maritime", "TG-M", "Region"),
        new State("Plateaux", "TG-P", "Region"),
        new State("Savanes", "TG-S", "Region")
    };
}

