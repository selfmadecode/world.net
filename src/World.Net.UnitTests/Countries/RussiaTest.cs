namespace World.Net.UnitTests.Countries;

public sealed class RussiaTest : AssertCountryTestBase
{
    private const string RUSSIA_COUNTRY_NAME = "Russia";
    private const string RUSSIA_NATIVE_NAME = "Россия";
    private const string RUSSIA_CAPITAL = "Moscow";
    private const string RUSSIA_OFFICIAL_NAME = "Russian Federation";
    private const string RUSSIA_ISO2_CODE = "RU";
    private const string RUSSIA_ISO3_CODE = "RUS";
    private const int RUSSIA_NUMERIC_CODE = 643;
    private readonly string[] RUSSIA_CALLING_CODE = ["+7"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Russia;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Adygea", "RU-AD", "Federal Subject"),
    new("Altai Republic", "RU-AL", "Federal Subject"),
    new("Altai Krai", "RU-ALT", "Federal Subject"),
    new("Amur Oblast", "RU-AMU", "Federal Subject"),
    new("Arkhangelsk Oblast", "RU-ARK", "Federal Subject"),
    new("Astrakhan Oblast", "RU-AST", "Federal Subject"),
    new("Bashkortostan", "RU-BA", "Federal Subject"),
    new("Belgorod Oblast", "RU-BEL", "Federal Subject"),
    new("Bryansk Oblast", "RU-BRY", "Federal Subject"),
    new("Buryatia", "RU-BU", "Federal Subject"),
    new("Chechnya", "RU-CE", "Federal Subject"),
    new("Chelyabinsk Oblast", "RU-CHE", "Federal Subject"),
    new("Chukotka", "RU-CHU", "Federal Subject"),
    new("Chuvashia", "RU-CU", "Federal Subject"),
    new("Dagestan", "RU-DA", "Federal Subject"),
    new("Ingushetia", "RU-IN", "Federal Subject"),
    new("Irkutsk Oblast", "RU-IRK", "Federal Subject"),
    new("Ivanovo Oblast", "RU-IVA", "Federal Subject"),
    new("Jewish Autonomous Oblast", "RU-YEV", "Federal Subject"),
    new("Kabardino-Balkaria", "RU-KB", "Federal Subject"),
    new("Kaliningrad Oblast", "RU-KGD", "Federal Subject"),
    new("Kalmykia", "RU-KL", "Federal Subject"),
    new("Kaluga Oblast", "RU-KLU", "Federal Subject"),
    new("Kamchatka Krai", "RU-KAM", "Federal Subject"),
    new("Karachay-Cherkessia", "RU-KC", "Federal Subject"),
    new("Karelia", "RU-KR", "Federal Subject"),
    new("Kemerovo Oblast", "RU-KEM", "Federal Subject"),
    new("Khabarovsk Krai", "RU-KHA", "Federal Subject"),
    new("Khakassia", "RU-KK", "Federal Subject"),
    new("Khanty-Mansi Autonomous Okrug", "RU-KHM", "Federal Subject"),
    new("Kirov Oblast", "RU-KIR", "Federal Subject"),
    new("Komi", "RU-KO", "Federal Subject"),
    new("Kostroma Oblast", "RU-KOS", "Federal Subject"),
    new("Krasnodar Krai", "RU-KDA", "Federal Subject"),
    new("Krasnoyarsk Krai", "RU-KYA", "Federal Subject"),
    new("Kurgan Oblast", "RU-KUR", "Federal Subject"),
    new("Kursk Oblast", "RU-KRS", "Federal Subject"),
    new("Leningrad Oblast", "RU-LEN", "Federal Subject"),
    new("Lipetsk Oblast", "RU-LIP", "Federal Subject"),
    new("Magadan Oblast", "RU-MAG", "Federal Subject"),
    new("Mari El", "RU-ME", "Federal Subject"),
    new("Mordovia", "RU-MO", "Federal Subject"),
    new("Moscow", "RU-MOS", "Federal Subject"),
    new("Moscow Oblast", "RU-MOW", "Federal Subject"),
    new("Murmansk Oblast", "RU-MUR", "Federal Subject"),
    new("Nenets Autonomous Okrug", "RU-NEN", "Federal Subject"),
    new("Nizhny Novgorod Oblast", "RU-NIZ", "Federal Subject"),
    new("North Ossetia–Alania", "RU-SE", "Federal Subject"),
    new("Novgorod Oblast", "RU-NGR", "Federal Subject"),
    new("Novosibirsk Oblast", "RU-NVS", "Federal Subject"),
    new("Omsk Oblast", "RU-OMS", "Federal Subject"),
    new("Orenburg Oblast", "RU-ORE", "Federal Subject"),
    new("Oryol Oblast", "RU-ORL", "Federal Subject"),
    new("Penza Oblast", "RU-PNZ", "Federal Subject"),
    new("Perm Krai", "RU-PER", "Federal Subject"),
    new("Primorsky Krai", "RU-PRI", "Federal Subject"),
    new("Pskov Oblast", "RU-PSK", "Federal Subject"),
    new("Rostov Oblast", "RU-ROS", "Federal Subject"),
    new("Ryazan Oblast", "RU-RYA", "Federal Subject"),
    new("Saint Petersburg", "RU-SPE", "Federal Subject"),
    new("Sakha Republic (Yakutia)", "RU-SAK", "Federal Subject"),
    new("Sakhalin Oblast", "RU-SAKH", "Federal Subject"),
    new("Samara Oblast", "RU-SAM", "Federal Subject"),
    new("Saratov Oblast", "RU-SAR", "Federal Subject"),
    new("Smolensk Oblast", "RU-SMO", "Federal Subject"),
    new("Stavropol Krai", "RU-STA", "Federal Subject"),
    new("Sverdlovsk Oblast", "RU-SVE", "Federal Subject"),
    new("Tambov Oblast", "RU-TAM", "Federal Subject"),
    new("Tatarstan", "RU-TA", "Federal Subject"),
    new("Tomsk Oblast", "RU-TOM", "Federal Subject"),
    new("Tula Oblast", "RU-TUL", "Federal Subject"),
    new("Tuva", "RU-TY", "Federal Subject"),
    new("Tver Oblast", "RU-TVE", "Federal Subject"),
    new("Tyumen Oblast", "RU-TYU", "Federal Subject"),
    new("Udmurtia", "RU-UD", "Federal Subject"),
    new("Ulyanovsk Oblast", "RU-ULY", "Federal Subject"),
    new("Vladimir Oblast", "RU-VLA", "Federal Subject"),
    new("Volgograd Oblast", "RU-VGG", "Federal Subject"),
    new("Vologda Oblast", "RU-VLG", "Federal Subject"),
    new("Voronezh Oblast", "RU-VOR", "Federal Subject"),
    new("Yamalo-Nenets Autonomous Okrug", "RU-YAN", "Federal Subject"),
    new("Yaroslavl Oblast", "RU-YAR", "Federal Subject"),
    new("Zabaykalsky Krai", "RU-ZAB", "Federal Subject")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForRussia()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            RUSSIA_COUNTRY_NAME,
            RUSSIA_OFFICIAL_NAME,
            RUSSIA_NATIVE_NAME,
            RUSSIA_CAPITAL,
            RUSSIA_NUMERIC_CODE,
            RUSSIA_ISO2_CODE,
            RUSSIA_ISO3_CODE,
            RUSSIA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
