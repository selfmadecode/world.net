namespace World.Net.UnitTests.Countries;

public sealed class TimorLesteTest : AssertCountryTestBase
{
    private const string TIMORLESTE_COUNTRY_NAME = "Timor-Leste";
    private const string TIMORLESTE_NATIVE_NAME = "Repúblika Demokrátika Timór-Leste";
    private const string TIMORLESTE_CAPITAL = "Dili";
    private const string TIMORLESTE_OFFICIAL_NAME = "Democratic Republic of Timor-Leste";
    private const string TIMORLESTE_ISO2_CODE = "TL";
    private const string TIMORLESTE_ISO3_CODE = "TLS";
    private const int TIMORLESTE_NUMERIC_CODE = 626;
    private readonly string[] TIMORLESTE_CALLING_CODE = ["+670"];
    private const int TIMORLESTE_STATE_COUNT = 13; // 12 municipalities + 1 special administrative region
    private static readonly string[] VALID_STATE_TYPES = { "Municipality", "Special Administrative Region" };
    private const CountryIdentifier ExpectedId = CountryIdentifier.TimorLeste;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Aileu", "TL-AL", "Municipality"),
        ("Ainaro", "TL-AN", "Municipality"),
        ("Baucau", "TL-BA", "Municipality"),
        ("Bobonaro", "TL-BO", "Municipality"),
        ("Cova Lima", "TL-CO", "Municipality"),
        ("Dili", "TL-DI", "Municipality"),
        ("Ermera", "TL-ER", "Municipality"),
        ("Lautém", "TL-LA", "Municipality"),
        ("Liquiça", "TL-LI", "Municipality"),
        ("Manatuto", "TL-MT", "Municipality"),
        ("Manufahi", "TL-MF", "Municipality"),
        ("Viqueque", "TL-VI", "Municipality"),
        ("Oecusse", "TL-OE", "Special Administrative Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForTimorLeste()
    {
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        Assert.Equal(TIMORLESTE_STATE_COUNT, country.States.Count());
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));

        AssertCorrectInformation(
            country,
            ExpectedId,
            TIMORLESTE_COUNTRY_NAME,
            TIMORLESTE_OFFICIAL_NAME,
            TIMORLESTE_NATIVE_NAME,
            TIMORLESTE_CAPITAL,
            TIMORLESTE_NUMERIC_CODE,
            TIMORLESTE_ISO2_CODE,
            TIMORLESTE_ISO3_CODE,
            TIMORLESTE_CALLING_CODE,
            ExpectedStates
        );
    }
}
