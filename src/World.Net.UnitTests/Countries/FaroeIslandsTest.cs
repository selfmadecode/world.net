using System.Reflection.Metadata;
using System.Xml.Linq;

namespace World.Net.UnitTests.Countries;

public sealed class FaroeIslandsTest : AssertCountryTestBase
{
    private static CountryIdentifier Id => CountryIdentifier.FaroeIslands;
    private const string FAROEISLANDS_COUNTRY_NAME = "Faroe Islands";
    private const string FAROEISLANDS_NATIVE_NAME = "Føroyar";
    private const string FAROEISLANDS_CAPITAL = "Tórshavn";
    private const string FAROEISLANDS_OFFICIAL_NAME = "Faroe Islands";
    private const string FAROEISLANDS_ISO2_CODE = "FO";
    private const string FAROEISLANDS_ISO3_CODE = "FRO";
    private const int FAROEISLANDS_NUMERIC_CODE = 234;
    private readonly string[] FAROEISLANDS_CALLING_CODE = ["+298"];
    private static readonly (string Name, string IsoCode, string Type)[] States =
    [
        new("Eysturoy", "FO-01", "Region"),
        new("Norðoyar", "FO-02", "Region"),
        new("Sandoy", "FO-03", "Region"),
        new("Streymoy", "FO-04", "Region"),
        new("Suðuroy", "FO-05", "Region"),
        new("Vágar", "FO-06", "Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForFaroeIslands()
    {
        // Arrange
        // Act

        // Assert
        var country = CountryProvider.GetCountry(Id);

        AssertCorrectInformation(
            country,
            Id,
            FAROEISLANDS_COUNTRY_NAME,
            FAROEISLANDS_OFFICIAL_NAME,
            FAROEISLANDS_NATIVE_NAME,
            FAROEISLANDS_CAPITAL,
            FAROEISLANDS_NUMERIC_CODE,
            FAROEISLANDS_ISO2_CODE,
            FAROEISLANDS_ISO3_CODE,
            FAROEISLANDS_CALLING_CODE,
            States
        );
    }
}


