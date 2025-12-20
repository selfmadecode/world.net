namespace World.Net.UnitTests.Countries
{
    public sealed class ElSalvadorTest : AssertCountryTestBase
    {
        private const string ELSALVADOR_NAME = "ElSalvador";
        private const string ELSALVADOR_OFFICIAL_NAME = "Republic of El Salvador";
        private const string ELSALVADOR_NATIVE_NAME = "República de El Salvador";
        private const string ELSALVADOR_CAPITAL = "San Salvador";
        private const int ELSALVADOR_NUMERIC_CODE = 222;
        private const string ELSALVADOR_ISO2_CODE = "SV";
        private const string ELSALVADOR_ISO3_CODE = "SLV";
        private readonly string[] ELSALVADOR_CALLING_CODE = ["503"];
        private static CountryIdentifier ExpectedId => CountryIdentifier.ElSalvador;
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        {
            new("Ahuachapán", "AH", "Department"),
            new("Cabañas", "CA", "Department"),
            new("Chalatenango", "CH", "Department"),
            new("Cuscatlán", "CU", "Department"),
            new("La Libertad", "LI", "Department"),
            new("La Paz", "PA", "Department"),
            new("La Unión", "UN", "Department"),
            new("Morazán", "MO", "Department"),
            new("San Miguel", "SM", "Department"),
            new("San Salvador", "SS", "Department"),
            new("San Vicente", "SV", "Department"),
            new("Santa Ana", "SA", "Department"),
            new("Sonsonate", "SO", "Department"),
            new("Usulután", "US", "Department")
        };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForElSalvador()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(ExpectedId);

            // Assert

            AssertCorrectInformation(
                country,
                ExpectedId,
                ELSALVADOR_NAME,
                ELSALVADOR_OFFICIAL_NAME,
                ELSALVADOR_NATIVE_NAME,
                ELSALVADOR_CAPITAL,
                ELSALVADOR_NUMERIC_CODE,
                ELSALVADOR_ISO2_CODE,
                ELSALVADOR_ISO3_CODE,
                ELSALVADOR_CALLING_CODE,
                ExpectedStates
            );
        }
    }
}
