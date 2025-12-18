using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries;

public sealed class PanamaTest : AssertCountryTestBase
{
    private const string PANAMA_COUNTRY_NAME = "Panama";
    private const string PANAMA_NATIVE_NAME = "República de Panamá";
    private const string PANAMA_CAPITAL = "Panama City";
    private const string PANAMA_OFFICIAL_NAME = "Republic of Panama";
    private const string PANAMA_ISO2_CODE = "PA";
    private const string PANAMA_ISO3_CODE = "PAN";
    private const int PANAMA_NUMERIC_CODE = 591;
    private readonly string[] PANAMA_CALLING_CODE = ["+507"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Panama;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Bocas del Toro", "PA-1", "Province"),
    new("Chiriquí", "PA-4", "Province"),
    new("Coclé", "PA-2", "Province"),
    new("Colón", "PA-3", "Province"),
    new("Darién", "PA-5", "Province"),
    new("Herrera", "PA-6", "Province"),
    new("Los Santos", "PA-7", "Province"),
    new("Panamá", "PA-8", "Province"),
    new("Veraguas", "PA-9", "Province"),
    new("Panamá Oeste", "PA-10", "Province"),
    new("Kuna Yala", "PA-KY", "Indigenous Region"),
    new("Ngäbe-Buglé", "PA-NB", "Indigenous Region"),
    new("Emberá-Wounaan", "PA-EM", "Indigenous Region")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForPanama()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            PANAMA_COUNTRY_NAME,
            PANAMA_OFFICIAL_NAME,
            PANAMA_NATIVE_NAME,
            PANAMA_CAPITAL,
            PANAMA_NUMERIC_CODE,
            PANAMA_ISO2_CODE,
            PANAMA_ISO3_CODE,
            PANAMA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
