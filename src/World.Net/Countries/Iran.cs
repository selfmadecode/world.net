namespace World.Net.Countries;

internal sealed class Iran : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Iran;

    //<inheritdoc/>
    public string Name { get; } = "Iran";

    //<inheritdoc/>
    public string OfficialName { get; } = "Islamic Republic of Iran";

    //<inheritdoc/>
    public string NativeName => "ایران";

    //<inheritdoc/>
    public string Capital { get; } = "Tehran";

    //<inheritdoc/>
    public int NumericCode { get; } = 364;

    //<inheritdoc/>
    public string ISO2Code { get; } = "IR";

    //<inheritdoc/>
    public string ISO3Code { get; } = "IRN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+98"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Alborz", "IR-AL", "Province"),
        new("Ardabil", "IR-AR", "Province"),
        new("Bushehr", "IR-BU", "Province"),
        new("Chaharmahal and Bakhtiari", "IR-CH", "Province"),
        new("East Azerbaijan", "IR-ES", "Province"),
        new("Fars", "IR-FA", "Province"),
        new("Gilan", "IR-GI", "Province"),
        new("Golestan", "IR-GO", "Province"),
        new("Hamadan", "IR-HM", "Province"),
        new("Hormozgan", "IR-HR", "Province"),
        new("Ilam", "IR-IL", "Province"),
        new("Isfahan", "IR-IS", "Province"),
        new("Kerman", "IR-KR", "Province"),
        new("Kermanshah", "IR-KS", "Province"),
        new("Khorasan North", "IR-KN", "Province"),
        new("Khorasan Razavi", "IR-KRZ", "Province"),
        new("Khorasan South", "IR-KS", "Province"),
        new("Khuzestan", "IR-KH", "Province"),
        new("Kohgiluyeh and Boyer-Ahmad", "IR-KB", "Province"),
        new("Kurdistan", "IR-KD", "Province"),
        new("Lorestan", "IR-LR", "Province"),
        new("Markazi", "IR-MK", "Province"),
        new("Mazandaran", "IR-MZ", "Province"),
        new("Qazvin", "IR-QZ", "Province"),
        new("Qom", "IR-QM", "Province"),
        new("Semnan", "IR-SM", "Province"),
        new("Sistan and Baluchestan", "IR-SB", "Province"),
        new("Tehran", "IR-TH", "Province"),
        new("West Azerbaijan", "IR-WA", "Province"),
        new("Yazd", "IR-YZ", "Province"),
        new("Zanjan", "IR-ZN", "Province")
    ];
}

