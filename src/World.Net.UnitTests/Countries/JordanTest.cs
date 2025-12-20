namespace World.Net.UnitTests.Countries;
public sealed class JordanTest : AssertCountryTestBase
{
    private const string JORDAN_COUNTRY_NAME = "Jordan";
    private const string JORDAN_NATIVE_NAME = "الأردن";
    private const string JORDAN_CAPITAL = "Amman";
    private const string JORDAN_OFFICIAL_NAME = "Hashemite Kingdom of Jordan";
    private const string JORDAN_ISO2_CODE = "JO";
    private const string JORDAN_ISO3_CODE = "JOR";
    private const int JORDAN_NUMERIC_CODE = 400;
    private readonly string[] JORDAN_CALLING_CODE = ["+962"];
    private static readonly string[] VALID_STATE_TYPES = { "governorate" };
    private const CountryIdentifier ExpectedId = CountryIdentifier.Jordan;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Ajloun", "JO-AJ", "governorate"),
        ("Amman", "JO-AM", "governorate"),
        ("Aqaba", "JO-AQ", "governorate"),
        ("Balqa", "JO-BA", "governorate"),
        ("Irbid", "JO-IR", "governorate"),
        ("Jerash", "JO-JA", "governorate"),
        ("Karak", "JO-KA", "governorate"),
        ("Ma'an", "JO-MN", "governorate"),
        ("Madaba", "JO-MD", "governorate"),
        ("Mafraq", "JO-MA", "governorate"),
        ("Tafilah", "JO-AT", "governorate"),
        ("Zarqa", "JO-AZ", "governorate"),
    ];


    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForJordan()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        Assert.NotNull(country);
        Assert.All(country.States, state => Assert.Contains(state.Type, VALID_STATE_TYPES));

        AssertCorrectInformation(
            country,
            ExpectedId,
            JORDAN_COUNTRY_NAME,
            JORDAN_OFFICIAL_NAME,
            JORDAN_NATIVE_NAME,
            JORDAN_CAPITAL,
            JORDAN_NUMERIC_CODE,
            JORDAN_ISO2_CODE,
            JORDAN_ISO3_CODE,
            JORDAN_CALLING_CODE,
            ExpectedStates
        );
    }
}
