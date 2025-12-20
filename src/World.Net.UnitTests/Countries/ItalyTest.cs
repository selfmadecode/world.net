namespace World.Net.UnitTests.Countries;
public sealed class ItalyTest : AssertCountryTestBase
{
    private const string ITALY_COUNTRY_NAME = "Italy";
    private const string ITALY_NATIVE_NAME = "Italia";
    private const string ITALY_CAPITAL = "Rome";
    private const string ITALY_OFFICIAL_NAME = "Italian Republic";
    private const string ITALY_ISO2_CODE = "IT";
    private const string ITALY_ISO3_CODE = "ITA";
    private const int ITALY_NUMERIC_CODE = 380;
    private readonly string[] ITALY_CALLING_CODE = ["+39"];
    private const CountryIdentifier ExpectedId = CountryIdentifier.Italy;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Abruzzo", "IT-65", "Region"),
        ("Agrigento", "IT-AG", "Free Municipal Consortium"),
        ("Alessandria", "IT-AL", "Province"),
        ("Ancona", "IT-AN", "Province"),
        ("Aosta Valley", "IT-23", "Autonomous Region"),
        ("Apulia", "IT-75", "Region"),
        ("Arezzo", "IT-AR", "Province"),
        ("Ascoli Piceno", "IT-AP", "Province"),
        ("Asti", "IT-AT", "Province"),
        ("Avellino", "IT-AV", "Province"),
        ("Barletta-Andria-Trani", "IT-BT", "Province"),
        ("Basilicata", "IT-77", "Region"),
        ("Belluno", "IT-BL", "Province"),
        ("Benevento", "IT-BN", "Province"),
        ("Bergamo", "IT-BG", "Province"),
        ("Biella", "IT-BI", "Province"),
        ("Brescia", "IT-BS", "Province"),
        ("Brindisi", "IT-BR", "Province"),
        ("Calabria", "IT-78", "Region"),
        ("Caltanissetta", "IT-CL", "Free Municipal Consortium"),
        ("Campania", "IT-72", "Region"),
        ("Campobasso", "IT-CB", "Province"),
        ("Caserta", "IT-CE", "Province"),
        ("Catanzaro", "IT-CZ", "Province"),
        ("Chieti", "IT-CH", "Province"),
        ("Como", "IT-CO", "Province"),
        ("Cosenza", "IT-CS", "Province"),
        ("Cremona", "IT-CR", "Province"),
        ("Crotone", "IT-KR", "Province"),
        ("Cuneo", "IT-CN", "Province"),
        ("Emilia-Romagna", "IT-45", "Region"),
        ("Enna", "IT-EN", "Free Municipal Consortium"),
        ("Fermo", "IT-FM", "Province"),
        ("Ferrara", "IT-FE", "Province"),
        ("Foggia", "IT-FG", "Province"),
        ("Forlì-Cesena", "IT-FC", "Province"),
        ("Friuli–Venezia Giulia", "IT-36", "Autonomous Region"),
        ("Frosinone", "IT-FR", "Province"),
        ("Gorizia", "IT-GO", "Decentralized Regional Entity"),
        ("Grosseto", "IT-GR", "Province"),
        ("Imperia", "IT-IM", "Province"),
        ("Isernia", "IT-IS", "Province"),
        ("L'Aquila", "IT-AQ", "Province"),
        ("La Spezia", "IT-SP", "Province"),
        ("Latina", "IT-LT", "Province"),
        ("Lazio", "IT-62", "Region"),
        ("Lecce", "IT-LE", "Province"),
        ("Lecco", "IT-LC", "Province"),
        ("Liguria", "IT-42", "Region"),
        ("Livorno", "IT-LI", "Province"),
        ("Lodi", "IT-LO", "Province"),
        ("Lombardy", "IT-25", "Region"),
        ("Lucca", "IT-LU", "Province"),
        ("Macerata", "IT-MC", "Province"),
        ("Mantua", "IT-MN", "Province"),
        ("Marche", "IT-57", "Region"),
        ("Massa and Carrara", "IT-MS", "Province"),
        ("Matera", "IT-MT", "Province"),
        ("Modena", "IT-MO", "Province"),
        ("Molise", "IT-67", "Region"),
        ("Monza and Brianza", "IT-MB", "Province"),
        ("Novara", "IT-NO", "Province"),
        ("Nuoro", "IT-NU", "Province"),
        ("Oristano", "IT-OR", "Province"),
        ("Padua", "IT-PD", "Province"),
        ("Palermo", "IT-PA", "Metropolitan City"),
        ("Parma", "IT-PR", "Province"),
        ("Pavia", "IT-PV", "Province"),
        ("Perugia", "IT-PG", "Province"),
        ("Pesaro and Urbino", "IT-PU", "Province"),
        ("Pescara", "IT-PE", "Province"),
        ("Piacenza", "IT-PC", "Province"),
        ("Piedmont", "IT-21", "Region"),
        ("Pisa", "IT-PI", "Province"),
        ("Pistoia", "IT-PT", "Province"),
        ("Pordenone", "IT-PN", "Decentralized Regional Entity"),
        ("Potenza", "IT-PZ", "Province"),
        ("Prato", "IT-PO", "Province"),
        ("Ragusa", "IT-RG", "Free Municipal Consortium"),
        ("Ravenna", "IT-RA", "Province"),
        ("Reggio Emilia", "IT-RE", "Province"),
        ("Rieti", "IT-RI", "Province"),
        ("Rimini", "IT-RN", "Province"),
        ("Rovigo", "IT-RO", "Province"),
        ("Salerno", "IT-SA", "Province"),
        ("Sardinia", "IT-88", "Autonomous Region"),
        ("Sassari", "IT-SS", "Province"),
        ("Savona", "IT-SV", "Province"),
        ("Sicily", "IT-82", "Autonomous Region"),
        ("Siena", "IT-SI", "Province"),
        ("Siracusa", "IT-SR", "Free Municipal Consortium"),
        ("Sondrio", "IT-SO", "Province"),
        ("South Sardinia", "IT-SU", "Province"),
        ("Taranto", "IT-TA", "Province"),
        ("Teramo", "IT-TE", "Province"),
        ("Terni", "IT-TR", "Province"),
        ("Trapani", "IT-TP", "Free Municipal Consortium"),
        ("Trentino-South Tyrol", "IT-32", "Autonomous Region"),
        ("Treviso", "IT-TV", "Province"),
        ("Trieste", "IT-TS", "Decentralized Regional Entity"),
        ("Tuscany", "IT-52", "Region"),
        ("Udine", "IT-UD", "Decentralized Regional Entity"),
        ("Umbria", "IT-55", "Region"),
        ("Varese", "IT VA", "Province"),
        ("Veneto", "IT-34", "Region"),
        ("Verbano-Cusio-Ossola", "IT-VB", "Province"),
        ("Vercelli", "IT-VC", "Province"),
        ("Verona", "IT-VR", "Province"),
        ("Vibo Valentia", "IT-VV", "Province"),
        ("Vicenza", "IT-VI", "Province"),
        ("Viterbo", "IT-VT", "Province")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForItaly()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        AssertCorrectInformation(
            country,
            ExpectedId,
            ITALY_COUNTRY_NAME,
            ITALY_OFFICIAL_NAME,
            ITALY_NATIVE_NAME,
            ITALY_CAPITAL,
            ITALY_NUMERIC_CODE,
            ITALY_ISO2_CODE,
            ITALY_ISO3_CODE,
            ITALY_CALLING_CODE,
            ExpectedStates
        );
    }
}
