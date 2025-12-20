namespace World.Net.UnitTests.Countries;
public sealed class JamaicaTest : AssertCountryTestBase
{
    private const string JAMAICA_COUNTRY_NAME = "Jamaica";
    private const string JAMAICA_NATIVE_NAME = "Jamaica";
    private const string JAMAICA_CAPITAL = "Kingston";
    private const string JAMAICA_OFFICIAL_NAME = "Jamaica";
    private const string JAMAICA_ISO2_CODE = "JM";
    private const string JAMAICA_ISO3_CODE = "JAM";
    private const int JAMAICA_NUMERIC_CODE = 388;
    private readonly string[] JAMAICA_CALLING_CODE = ["+1-876"];
    private const CountryIdentifier ExpectedId = CountryIdentifier.Jamaica;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Clarendon", "JM-13", "Parish"),
        ("Hanover", "JM-09", "Parish"),
        ("Kingston", "JM-01", "Parish"),
        ("Manchester", "JM-12", "Parish"),
        ("Portland", "JM-04", "Parish"),
        ("Saint Andrew", "JM-02", "Parish"),
        ("Saint Ann", "JM-06", "Parish"),
        ("Saint Catherine", "JM-14", "Parish"),
        ("Saint Elizabeth", "JM-11", "Parish"),
        ("Saint James", "JM-08", "Parish"),
        ("Saint Mary", "JM-05", "Parish"),
        ("Saint Thomas", "JM-03", "Parish"),
        ("Trelawny", "JM-07", "Parish"),
        ("Westmoreland", "JM-10", "Parish"),
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForJamaica()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        AssertCorrectInformation(
            country,
            ExpectedId,
            JAMAICA_COUNTRY_NAME,
            JAMAICA_OFFICIAL_NAME,
            JAMAICA_NATIVE_NAME,
            JAMAICA_CAPITAL,
            JAMAICA_NUMERIC_CODE,
            JAMAICA_ISO2_CODE,
            JAMAICA_ISO3_CODE,
            JAMAICA_CALLING_CODE,
            ExpectedStates
        );
    }
}
