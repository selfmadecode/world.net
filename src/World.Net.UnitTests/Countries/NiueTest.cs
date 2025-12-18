namespace World.Net.UnitTests.Countries;

public sealed class NiueTest : AssertCountryTestBase
{
    private const string NIUE_COUNTRY_NAME = "Niue";
    private const string NIUE_NATIVE_NAME = "Niuē";
    private const string NIUE_CAPITAL = "Alofi";
    private const string NIUE_OFFICIAL_NAME = "Niue";
    private const string NIUE_ISO2_CODE = "NU";
    private const string NIUE_ISO3_CODE = "NIU";
    private const int NIUE_NUMERIC_CODE = 570;
    private readonly string[] NIUE_CALLING_CODE = ["+683"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Niue;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Alofi North", "NU-01", "Village"),
        new("Alofi South", "NU-02", "Village"),
        new("Avatele", "NU-03", "Village"),
        new("Hakupu", "NU-04", "Village"),
        new("Hikutavake", "NU-05", "Village"),
        new("Lakepa", "NU-06", "Village"),
        new("Liku", "NU-07", "Village"),
        new("Makefu", "NU-08", "Village"),
        new("Mutalau", "NU-09", "Village"),
        new("Namukulu", "NU-10", "Village"),
        new("Talava", "NU-11", "Village"),
        new("Toi", "NU-12", "Village"),
        new("Tufukia", "NU-13", "Village"),
        new("Vaiea", "NU-14", "Village")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForNiue()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            NIUE_COUNTRY_NAME,
            NIUE_OFFICIAL_NAME,
            NIUE_NATIVE_NAME,
            NIUE_CAPITAL,
            NIUE_NUMERIC_CODE,
            NIUE_ISO2_CODE,
            NIUE_ISO3_CODE,
            NIUE_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}

