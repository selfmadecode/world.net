namespace World.Net.UnitTests.Countries;
public sealed class IrelandTest : AssertCountryTestBase
{
    private const string IRELAND_COUNTRY_NAME = "Ireland";
    private const string IRELAND_NATIVE_NAME = "Éire";
    private const string IRELAND_CAPITAL = "Dublin";
    private const string IRELAND_OFFICIAL_NAME = "Republic of Ireland";
    private const string IRELAND_ISO2_CODE = "IE";
    private const string IRELAND_ISO3_CODE = "IRL";
    private const int IRELAND_NUMERIC_CODE = 372;
    private readonly string[] IRELAND_CALLING_CODE = ["+353"];
    private const CountryIdentifier ExpectedId = CountryIdentifier.Ireland;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Carlow", "IE-CW", "County"),
        ("Cavan", "IE-CN", "County"),
        ("Clare", "IE-CE", "County"),
        ("Connacht", "IE-C", "Province"),
        ("Cork", "IE-CO", "County"),
        ("Donegal", "IE-DL", "County"),
        ("Dublin", "IE-D", "County"),
        ("Galway", "IE-G", "County"),
        ("Kerry", "IE-KY", "County"),
        ("Kildare", "IE-KE", "County"),
        ("Kilkenny", "IE-KK", "County"),
        ("Laois", "IE-LS", "County"),
        ("Leinster", "IE-L", "Province"),
        ("Leitrim", "IE-LM", "County"),
        ("Limerick", "IE-LK", "County"),
        ("Longford", "IE-LD", "County"),
        ("Louth", "IE-LH", "County"),
        ("Mayo", "IE-MO", "County"),
        ("Meath", "IE-MH", "County"),
        ("Monaghan", "IE-MN", "County"),
        ("Munster", "IE-M", "Province"),
        ("Offaly", "IE-OY", "County"),
        ("Roscommon", "IE-RN", "County"),
        ("Sligo", "IE-SO", "County"),
        ("Tipperary", "IE-TA", "County"),
        ("Ulster", "IE-U", "Province"),
        ("Waterford", "IE-WD", "County"),
        ("Westmeath", "IE-WH", "County"),
        ("Wexford", "IE-WX", "County"),
        ("Wicklow", "IE-WW", "County")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForIreland()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        // Assert
        AssertCorrectInformation(
            country,
            ExpectedId,
            IRELAND_COUNTRY_NAME,
            IRELAND_OFFICIAL_NAME,
            IRELAND_NATIVE_NAME,
            IRELAND_CAPITAL,
            IRELAND_NUMERIC_CODE,
            IRELAND_ISO2_CODE,
            IRELAND_ISO3_CODE,
            IRELAND_CALLING_CODE,
            ExpectedStates
        );
    }
}
