namespace World.Net.Countries;

internal sealed class Maldives : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Maldives;

    public string Name { get; } = "Maldives";

    public string OfficialName { get; } = "Republic of Maldives";

    public string NativeName => "Dhivehi Raajje";

    public string Capital { get; } = "Malé";

    public int NumericCode { get; } = 462;

    public string ISO2Code { get; } = "MV";

    public string ISO3Code { get; } = "MDV";

    public string[] CallingCode { get; } = ["+960"];

    public IEnumerable<State> States => new[]
    {
        new State("Alif Alif", "MV-02", "Administrative Atoll"),
        new State("Alif Dhaal", "MV-00", "Administrative Atoll"),
        new State("Baa", "MV-20", "Administrative Atoll"),
        new State("Dhaalu", "MV-17", "Administrative Atoll"),
        new State("Faafu", "MV-14", "Administrative Atoll"),
        new State("Gaafu Alif", "MV-27", "Administrative Atoll"),
        new State("Gaafu Dhaalu", "MV-28", "Administrative Atoll"),
        new State("Gnaviyani", "MV-29", "Administrative Atoll"),
        new State("Haa Alif", "MV-07", "Administrative Atoll"),
        new State("Haa Dhaalu", "MV-23", "Administrative Atoll"),
        new State("Kaafu", "MV-26", "Administrative Atoll"),
        new State("Laamu", "MV-05", "Administrative Atoll"),
        new State("Lhaviyani", "MV-03", "Administrative Atoll"),
        new State("Meemu", "MV-12", "Administrative Atoll"),
        new State("Noonu", "MV-25", "Administrative Atoll"),
        new State("Raa", "MV-13", "Administrative Atoll"),
        new State("Shaviyani", "MV-24", "Administrative Atoll"),
        new State("Thaa", "MV-08", "Administrative Atoll"),
        new State("Vaavu", "MV-04", "Administrative Atoll"),
        new State("Malé", "MV-MLE", "City")
    };
}

