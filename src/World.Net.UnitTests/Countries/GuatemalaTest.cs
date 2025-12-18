namespace World.Net.UnitTests.Countries;

public sealed class GuatemalaTest : AssertCountryTestBase
{
    private const string GUATEMALA_COUNTRY_NAME = "Guatemala";
    private const string GUATEMALA_NATIVE_NAME = "Guatemala";
    private const string GUATEMALA_CAPITAL = "Guatemala City";
    private const string GUATEMALA_OFFICIAL_NAME = "Republic of Guatemala";
    private const string GUATEMALA_ISO2_CODE = "GT";
    private const string GUATEMALA_ISO3_CODE = "GTM";
    private const int GUATEMALA_NUMERIC_CODE = 320;
    private readonly string[] GUATEMALA_CALLING_CODE = ["+502"];
    private const CountryIdentifier EXPECTEDID = CountryIdentifier.Guatemala;

    private static readonly (string Name, string IsoCode, string Type)[] EXPECTED_STATES =
    [
        new("Alta Verapaz", "GT-AV", "Department"),
        new("Baja Verapaz", "GT-BV", "Department"),
        new("Chimaltenango", "GT-CM", "Department"),
        new("Chiquimula", "GT-CQ", "Department"),
        new("El Progreso", "GT-PR", "Department"),
        new("Escuintla", "GT-ES", "Department"),
        new("Guatemala", "GT-GU", "Department"),
        new("Huehuetenango", "GT-HU", "Department"),
        new("Izabal", "GT-IZ", "Department"),
        new("Jalapa", "GT-JA", "Department"),
        new("Jutiapa", "GT-JU", "Department"),
        new("Petén", "GT-PE", "Department"),
        new("Quetzaltenango", "GT-QZ", "Department"),
        new("Quiché", "GT-QC", "Department"),
        new("Retalhuleu", "GT-RE", "Department"),
        new("Sacatepéquez", "GT-SA", "Department"),
        new("San Marcos", "GT-SM", "Department"),
        new("Santa Rosa", "GT-SR", "Department"),
        new("Sololá", "GT-SO", "Department"),
        new("Suchitepéquez", "GT-SU", "Department"),
        new("Totonicapán", "GT-TO", "Department"),
        new("Zacapa", "GT-ZA", "Department")
    ];

    [Fact]
    public void GetCountry_ReturnsCorrectInformation_ForGuatemala()
    {
        // Arrange
        // Act
        var country = CountryProvider.GetCountry(EXPECTEDID);

        // Assert
        AssertCorrectInformation(
            country,
            EXPECTEDID,
            GUATEMALA_COUNTRY_NAME,
            GUATEMALA_OFFICIAL_NAME,
            GUATEMALA_NATIVE_NAME,
            GUATEMALA_CAPITAL,
            GUATEMALA_NUMERIC_CODE,
            GUATEMALA_ISO2_CODE,
            GUATEMALA_ISO3_CODE,
            GUATEMALA_CALLING_CODE,
            EXPECTED_STATES
        );
    }
}
