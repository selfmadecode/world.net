namespace World.Net.Countries;

internal sealed class CentralAfricanRepublic : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.CentralAfricanRepublic;

    public string Name => "Central African Republic";

    public string OfficialName => "Central African Republic";

    public string NativeName => "Ködörösêse tî Bêafrîka";

    public string Capital => "Bangui";

    public int NumericCode => 140;

    public string ISO2Code => "CF";

    public string ISO3Code => "CAF";

    public string CallingCode => "+236";

    public IEnumerable<State> States =>
    [
        new("Bamingui-Bangoran", "BB", "Prefecture"),
        new("Bangui", "BGF", "Capital District"),
        new("Basse-Kotto", "BK", "Prefecture"),
        new("Haut-Mbomou", "HM", "Prefecture"),
        new("Haut-Oubangui", "HK", "Prefecture"),
        new("Kémo", "KG", "Prefecture"),
        new("Lobaye", "LB", "Prefecture"),
        new("Mambéré-Kadéï", "CF", "Prefecture"),
        new("Mbomou", "MB", "Prefecture"),
        new("Nana-Mambéré", "NM", "Prefecture"),
        new("Nana-Grébizi", "NG", "Prefecture"),
        new("Ombella-M'Poko", "OM", "Prefecture"),
        new("Sangha-Mbaéré", "SM", "Prefecture"),
        new("Vakaga", "VK", "Prefecture")
    ];
}
