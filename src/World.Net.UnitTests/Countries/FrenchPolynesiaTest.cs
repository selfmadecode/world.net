namespace World.Net.UnitTests.Countries;
public sealed class FrenchPolynesiaTest : AssertCountryTestBase
{
    private const string FRENCH_POLYNESIA_NAME = "French Polynesia";
    private const string FRENCH_POLYNESIA_OFFICIAL_NAME = "Polynésie française";
    private const string FRENCH_POLYNESIA_NATIVE_NAME = "Polynésie française";
    private const string FRENCH_POLYNESIA_CAPITAL = "Papeete";
    private const int FRENCH_POLYNESIA_NUMERIC_CODE = 258;
    private const string FRENCH_POLYNESIA_ISO2_CODE = "PF";
    private const string FRENCH_POLYNESIA_ISO3_CODE = "PYF";
    private readonly string[] FRENCH_POLYNESIA_CALLING_CODE = ["+689"];
    private const CountryIdentifier ExpectedId = CountryIdentifier.FrenchPolynesia;
    private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates = [
        ("N'Austral Islands", "PF-01", "division"),
        ("Leeward Islands", "PF-02", "division"),
        ("Marquesas Islands", "PF-03", "division"),
        ("Tuamotu-Gambier", "PF-04", "division"),
        ("Windward Islands", "PF-05", "division"),
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForFrench_Polynesia()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(ExpectedId);

        //Assert

        AssertCorrectInformation(
            country,
            ExpectedId,
            FRENCH_POLYNESIA_NAME,
            FRENCH_POLYNESIA_OFFICIAL_NAME,
            FRENCH_POLYNESIA_NATIVE_NAME,
            FRENCH_POLYNESIA_CAPITAL,
            FRENCH_POLYNESIA_NUMERIC_CODE,
            FRENCH_POLYNESIA_ISO2_CODE,
            FRENCH_POLYNESIA_ISO3_CODE,
            FRENCH_POLYNESIA_CALLING_CODE,
            ExpectedStates
        );
    }
}
