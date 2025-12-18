namespace World.Net.UnitTests.Countries;

public sealed class GreenlandTest : AssertCountryTestBase
{
    private const string GREENLAND_COUNTRY_NAME = "Greenland";
    private const string GREENLAND_NATIVE_NAME = "Kalaallit Nunaat";
    private const string GREENLAND_CAPITAL = "Nuuk";
    private const string GREENLAND_OFFICIAL_NAME = "Greenland";
    private const string GREENLAND_ISO2_CODE = "GL";
    private const string GREENLAND_ISO3_CODE = "GRL";
    private const int GREENLAND_NUMERIC_CODE = 304;
    private readonly string[] GREENLAND_CALLING_CODE = ["+299"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Greenland;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Avannaata", "GL-AV", "Municipality"),
        new("Kujalleq", "GL-KU", "Municipality"),
        new("Qeqertalik", "GL-QT", "Municipality"),
        new("Qeqqata", "GL-QE", "Municipality"),
        new("Sermersooq", "GL-SM", "Municipality")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGreenland()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GREENLAND_COUNTRY_NAME,
            GREENLAND_OFFICIAL_NAME,
            GREENLAND_NATIVE_NAME,
            GREENLAND_CAPITAL,
            GREENLAND_NUMERIC_CODE,
            GREENLAND_ISO2_CODE,
            GREENLAND_ISO3_CODE,
            GREENLAND_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
