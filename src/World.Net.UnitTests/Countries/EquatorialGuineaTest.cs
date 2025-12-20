namespace World.Net.UnitTests.Countries
{
    public class EquatorialGuineaTest : AssertCountryTestBase
    {
        private const string EQUATORIALGUINEA_NAME = "EquatorialGuinea";
        private const string EQUATORIALGUINEA_OFFICIAL_NAME = "Republic of Equatorial Guinea";
        private const string EQUATORIALGUINEA_NATIVE_NAME = "República de Guinea Ecuatorial";
        private const string EQUATORIALGUINEA_CAPITAL = "Malabo";
        private const int EQUATORIALGUINEA_NUMERIC_CODE = 226;
        private const string EQUATORIALGUINEA_ISO2_CODE = "GQ";
        private const string EQUATORIALGUINEA_ISO3_CODE = "GNQ";
        private readonly string[] EQUATORIALGUINEA_CALLING_CODE = ["240"];
        private static CountryIdentifier ExpectedId => CountryIdentifier.EquatorialGuinea;
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        {
            new("Annobón", "AN", "Province"),
            new("Bioko Norte", "BN", "Province"),
            new("Bioko Sur", "BS", "Province"),
            new("Centro Sur", "CS", "Province"),
            new("Djibloho", "DJ", "Province"),
            new("Kié-Ntem", "KN", "Province"),
            new("Litoral", "LI", "Province"),
            new("Wele-Nzas", "WN", "Province")
        };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForEquatorialGuinea()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(ExpectedId);

            // Assert
            AssertCorrectInformation(
                country,
                ExpectedId,
                EQUATORIALGUINEA_NAME,
                EQUATORIALGUINEA_OFFICIAL_NAME,
                EQUATORIALGUINEA_NATIVE_NAME,
                EQUATORIALGUINEA_CAPITAL,
                EQUATORIALGUINEA_NUMERIC_CODE,
                EQUATORIALGUINEA_ISO2_CODE,
                EQUATORIALGUINEA_ISO3_CODE,
                EQUATORIALGUINEA_CALLING_CODE,
                ExpectedStates
            );
        }

    }
}
