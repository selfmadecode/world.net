namespace World.Net.UnitTests.Countries;

public sealed class NorwayTest : AssertCountryTestBase
{
    private const string NORWAY_COUNTRY_NAME = "Norway";
    private const string NORWAY_NATIVE_NAME = "Norge";
    private const string NORWAY_CAPITAL = "Oslo";
    private const string NORWAY_OFFICIAL_NAME = "Kingdom of Norway";
    private const string NORWAY_ISO2_CODE = "NO";
    private const string NORWAY_ISO3_CODE = "NOR";
    private const int NORWAY_NUMERIC_CODE = 578;
    private readonly string[] NORWAY_CALLING_CODE = ["+47"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Norway;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Agder", "NO-42", "County"),
    new("Innlandet", "NO-34", "County"),
    new("Møre og Romsdal", "NO-15", "County"),
    new("Nordland", "NO-18", "County"),
    new("Oslo", "NO-03", "County"),
    new("Rogaland", "NO-11", "County"),
    new("Troms og Finnmark", "NO-54", "County"),
    new("Trøndelag", "NO-50", "County"),
    new("Vestfold og Telemark", "NO-38", "County"),
    new("Vestland", "NO-46", "County"),
    new("Viken", "NO-30", "County")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNorway()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            NORWAY_COUNTRY_NAME,
            NORWAY_OFFICIAL_NAME,
            NORWAY_NATIVE_NAME,
            NORWAY_CAPITAL,
            NORWAY_NUMERIC_CODE,
            NORWAY_ISO2_CODE,
            NORWAY_ISO3_CODE,
            NORWAY_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
