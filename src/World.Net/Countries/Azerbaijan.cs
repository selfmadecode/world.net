
namespace World.Net.Countries;

internal sealed class Azerbaijan : ICountry, ICountryRegistry
{
    //<inheritdoc/>
    public int Id => CountryIdentifier.Azerbaijan;

    //<inheritdoc/>
    public string Name { get; } = "Azerbaijan";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Azerbaijan";

    //<inheritdoc/>
    public string NativeName { get; } = "Azərbaycan";

    //<inheritdoc/>
    public string Capital { get; } = "Baku";

    //<inheritdoc/>
    public int NumericCode { get; } = 031;

    //<inheritdoc/>
    public string ISO2Code { get; } = "AZ";

    //<inheritdoc/>
    public string ISO3Code { get; } = "AZE";

    //<inheritdoc/>
    public string CallingCode { get; } = "+994";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Absheron", "ABS", "District"),
        new("Agdam", "AGM", "District"),
        new("Agdash", "AGS", "District"),
        new("Aghjabadi", "AGC", "District"),
        new("Agstafa", "AGA", "District"),
        new("Agsu", "AGU", "District"),
        new("Astara", "AST", "District"),
        new("Babek", "BAB", "District"),
        new("Baku", "BA", "Municipality"),
        new("Balakan", "BAL", "District"),
        new("Barda", "BAR", "District"),
        new("Beylagan", "BEY", "District"),
        new("Bilasuvar", "BIL", "District"),
        new("Dashkasan", "DAS", "District"),
        new("Fizuli", "FUZ", "District"),
        new("Ganja", "GA", "Municipality"),
        new("Gədəbəy", "GAD", "District"),
        new("Gobustan", "QOB", "District"),
        new("Goranboy", "GOR", "District"),
        new("Goychay", "GOY", "District"),
        new("Goygol", "GYG", "District"),
        new("Hajigabul", "HAC", "District"),
        new("Imishli", "IMI", "District"),
        new("Ismailli", "ISM", "District"),
        new("Jabrayil", "CAB", "District"),
        new("Jalilabad", "CAL", "District"),
        new("Julfa", "CUL", "District"),
        new("Kalbajar", "KAL", "District"),
        new("Kangarli", "KAN", "District"),
        new("Khachmaz", "XAC", "District"),
        new("Khizi", "XIZ", "District"),
        new("Khojali", "XCI", "District"),
        new("Kurdamir", "KUR", "District"),
        new("Lachin", "LAC", "District"),
        new("Lankaran", "LAN", "Municipality"),
        new("Lankaran", "LA", "District"),
        new("Lerik", "LER", "District"),
        new("Martuni", "XVD", "District"),
        new("Masally", "MAS", "District"),
        new("Mingachevir", "MI", "Municipality"),
        new("Nakhchivan", "NX", "Autonomous Republic"),
        new("Neftchala", "NEF", "District"),
        new("Oghuz", "OGU", "District"),
        new("Ordubad", "ORD", "District"),
        new("Qabala", "QAB", "District"),
        new("Qakh", "QAX", "District"),
        new("Qazakh", "QAZ", "District"),
        new("Quba", "QBA", "District"),
        new("Qubadli", "QBI", "District"),
        new("Qusar", "QUS", "District"),
        new("Saatly", "SAT", "District"),
        new("Sabirabad", "SAB", "District"),
        new("Sadarak", "SAD", "District"),
        new("Salyan", "SAL", "District"),
        new("Samukh", "SMX", "District"),
        new("Shabran", "SBN", "District"),
        new("Shahbuz", "SAH", "District"),
        new("Shaki", "SA", "District"),
        new("Shaki", "SAK", "District"),
        new("Shamakhi", "SMI", "District"),
        new("Shamkir", "SKR", "District"),
        new("Sharur", "SAR", "District"),
        new("Shirvan", "SR", "Municipality"),
        new("Shusha", "SUS", "District"),
        new("Siazan", "SIY", "District"),
        new("Sumqayit", "SM", "Municipality"),
        new("Tartar", "TAR", "District"),
        new("Tovuz", "TOV", "District"),
        new("Ujar", "UCA", "District"),
        new("Yardymli", "YAR", "District"),
        new("Yevlakh", "YE", "Municipality"),
        new("Yevlakh", "YEV", "District"),
        new("Zangilan", "ZAN", "District"),
        new("Zaqatala", "ZAQ", "District"),
        new("Zardab", "ZAR", "District")
    ];

    public Dictionary<int, ICountry> GetCountry()
    {
        return new Dictionary<int, ICountry>
        {
            { CountryIdentifier.Azerbaijan, new Azerbaijan() }
        };
    }
}
