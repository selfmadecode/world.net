using World.Net;
using World.Net.Helpers;

namespace World.Net.UnitTests.Countries;

public sealed class KiribatiTest : AssertCountryTestBase
{
    private const string KIRIBATI_COUNTRY_NAME = "Kiribati";
    private const string KIRIBATI_NATIVE_NAME = "Kiribati";
    private const string KIRIBATI_CAPITAL = "South Tarawa";
    private const string KIRIBATI_OFFICIAL_NAME = "Republic of Kiribati";
    private const string KIRIBATI_ISO2_CODE = "KI";
    private const string KIRIBATI_ISO3_CODE = "KIR";
    private const int KIRIBATI_NUMERIC_CODE = 296;
    private readonly string[] KIRIBATI_CALLING_CODE = ["+686"];
    private static readonly string[] VALID_STATE_TYPES = { "Group" };
    private const CountryIdentifier ExpectedId = CountryIdentifier.Kiribati;

    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
    [
        ("Gilbert Islands", "KI-G", "Group"),
        ("Line Islands", "KI-L", "Group"),
        ("Phoenix Islands", "KI-P", "Group")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForKiribati()
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
            KIRIBATI_COUNTRY_NAME,
            KIRIBATI_OFFICIAL_NAME,
            KIRIBATI_NATIVE_NAME,
            KIRIBATI_CAPITAL,
            KIRIBATI_NUMERIC_CODE,
            KIRIBATI_ISO2_CODE,
            KIRIBATI_ISO3_CODE,
            KIRIBATI_CALLING_CODE,
            ExpectedStates
        );
    }
}
