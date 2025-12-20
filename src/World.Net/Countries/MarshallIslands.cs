namespace World.Net.Countries;

internal sealed class MarshallIslands : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.MarshallIslands;

    public string Name { get; } = "Marshall Islands";

    public string OfficialName { get; } = "Republic of the Marshall Islands";

    public string NativeName => "Aelōn̄ in M̧ajeļ";

    public string Capital { get; } = "Majuro";

    public int NumericCode { get; } = 584;

    public string ISO2Code { get; } = "MH";

    public string ISO3Code { get; } = "MHL";

    public string[] CallingCode { get; } = ["+692"];

    public IEnumerable<State> States => new[]
    {
        new State("Ailinglaplap", "MH-ALL", "Municipality"),
        new State("Arno", "MH-ARN", "Municipality"),
        new State("Aur", "MH-AUR", "Municipality"),
        new State("Ebeye", "MH-EBN", "Municipality"),
        new State("Enewetak", "MH-ENI", "Municipality"),
        new State("Jabat", "MH-JAB", "Municipality"),
        new State("Jaluit", "MH-JAL", "Municipality"),
        new State("Kwajalein", "MH-KWA", "Municipality"),
        new State("Lae", "MH-LAE", "Municipality"),
        new State("Lib", "MH-LIB", "Municipality"),
        new State("Likiep", "MH-LIK", "Municipality"),
        new State("Majuro", "MH-MAJ", "Municipality"),
        new State("Maloelap", "MH-MAL", "Municipality"),
        new State("Mejit", "MH-MEJ", "Municipality"),
        new State("Mili", "MH-MIL", "Municipality"),
        new State("Namdrik", "MH-NMK", "Municipality"),
        new State("Namu", "MH-NMU", "Municipality"),
        new State("Rongelap", "MH-RON", "Municipality"),
        new State("Ujae", "MH-UJA", "Municipality"),
        new State("Utrik", "MH-UTI", "Municipality"),
        new State("Wotho", "MH-WTH", "Municipality"),
        new State("Wotje", "MH-WTJ", "Municipality")
    };
}

