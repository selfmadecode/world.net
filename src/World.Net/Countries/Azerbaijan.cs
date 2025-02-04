
namespace World.Net.Countries;

internal class Azerbaijan : ICountry
{
    public int Id => CountryIdentifier.Azerbaijan;

    public string Name { get; } = "Azerbaijan";

    public string OfficialName { get; } = "Republic of Azerbaijan";

    public string NativeName { get; } = "Azərbaycan";

    public string Capital { get; } = "Baku";

    public int NumericCode { get; } = 031;

    public string ISO2Code { get; } = "AZ";

    public string ISO3Code { get; } = "AZE";

    public string CallingCode { get; } = "+994";

    public IEnumerable<State> States => [
        new State("Absheron", "ABS", "District"),
        new State("Agdam", "AGM", "District"),
        new State("Agdash", "AGS", "District"),
        new State("Aghjabadi", "AGC", "District"),
        new State("Agstafa", "AGA", "District"),
        new State("Agsu", "AGU", "District"),
        new State("Astara", "AST", "District"),
        new State("Babek", "BAB", "District"),
        new State("Baku", "BA", "Municipality"),
        new State("Balakan", "BAL", "District"),
        new State("Barda", "BAR", "District"),
        new State("Beylagan", "BEY", "District"),
        new State("Bilasuvar", "BIL", "District"),
        new State("Dashkasan", "DAS", "District"),
        new State("Fizuli", "FUZ", "District"),
        new State("Ganja", "GA", "Municipality"),
        new State("Gədəbəy", "GAD", "District"),
        new State("Gobustan", "QOB", "District"),
        new State("Goranboy", "GOR", "District"),
        new State("Goychay", "GOY", "District"),
        new State("Goygol", "GYG", "District"),
        new State("Hajigabul", "HAC", "District"),
        new State("Imishli", "IMI", "District"),
        new State("Ismailli", "ISM", "District"),
        new State("Jabrayil", "CAB", "District"),
        new State("Jalilabad", "CAL", "District"),
        new State("Julfa", "CUL", "District"),
        new State("Kalbajar", "KAL", "District"),
        new State("Kangarli", "KAN", "District"),
        new State("Khachmaz", "XAC", "District"),
        new State("Khizi", "XIZ", "District"),
        new State("Khojali", "XCI", "District"),
        new State("Kurdamir", "KUR", "District"),
        new State("Lachin", "LAC", "District"),
        new State("Lankaran", "LAN", "Municipality"),
        new State("Lankaran", "LA", "District"),
        new State("Lerik", "LER", "District"),
        new State("Martuni", "XVD", "District"),
        new State("Masally", "MAS", "District"),
        new State("Mingachevir", "MI", "Municipality"),
        new State("Nakhchivan", "NX", "Autonomous Republic"),
        new State("Neftchala", "NEF", "District"),
        new State("Oghuz", "OGU", "District"),
        new State("Ordubad", "ORD", "District"),
        new State("Qabala", "QAB", "District"),
        new State("Qakh", "QAX", "District"),
        new State("Qazakh", "QAZ", "District"),
        new State("Quba", "QBA", "District"),
        new State("Qubadli", "QBI", "District"),
        new State("Qusar", "QUS", "District"),
        new State("Saatly", "SAT", "District"),
        new State("Sabirabad", "SAB", "District"),
        new State("Sadarak", "SAD", "District"),
        new State("Salyan", "SAL", "District"),
        new State("Samukh", "SMX", "District"),
        new State("Shabran", "SBN", "District"),
        new State("Shahbuz", "SAH", "District"),
        new State("Shaki", "SA", "District"),
        new State("Shaki", "SAK", "District"),
        new State("Shamakhi", "SMI", "District"),
        new State("Shamkir", "SKR", "District"),
        new State("Sharur", "SAR", "District"),
        new State("Shirvan", "SR", "Municipality"),
        new State("Shusha", "SUS", "District"),
        new State("Siazan", "SIY", "District"),
        new State("Sumqayit", "SM", "Municipality"),
        new State("Tartar", "TAR", "District"),
        new State("Tovuz", "TOV", "District"),
        new State("Ujar", "UCA", "District"),
        new State("Yardymli", "YAR", "District"),
        new State("Yevlakh", "YE", "Municipality"),
        new State("Yevlakh", "YEV", "District"),
        new State("Zangilan", "ZAN", "District"),
        new State("Zaqatala", "ZAQ", "District"),
        new State("Zardab", "ZAR", "District")
    ];
}
