namespace World.Net.UnitTests.Countries
{
    public class EswatiniTest : AssertCountryTestBase
    {
        private static CountryIdentifier ExpectedId => CountryIdentifier.Eswatini;
        private const string ESWATINI_NAME = "Eswatini";
        private const int ESWATINI_STATE_COUNT = 4;
        private const string ESWATINI_OFFICIAL_NAME = "Kingdom of Eswatini";
        private const string ESWATINI_NATIVE_NAME = "eSwatini";
        private const string ESWATINI_CAPITAL = "Mbabane";
        private const int ESWATINI_NUMERIC_CODE = 748;
        private const string ESWATINI_ISO2_CODE = "SZ";
        private const string ESWATINI_ISO3_CODE = "SWZ";
        private readonly string[] ESWATINI_CALLING_CODE = ["268"];
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        {
            new("Hhohho", "HH", "Region"),
            new("Lubombo", "LU", "Region"),
            new("Manzini", "MA", "Region"),
            new("Shiselweni", "SH", "Region")
        };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForEswatini()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(ExpectedId);

            // Assert
            AssertCorrectInformation(
                country,
                ExpectedId,
                ESWATINI_NAME,
                ESWATINI_OFFICIAL_NAME,
                ESWATINI_NATIVE_NAME,
                ESWATINI_CAPITAL,
                ESWATINI_NUMERIC_CODE,
                ESWATINI_ISO2_CODE,
                ESWATINI_ISO3_CODE,
                ESWATINI_CALLING_CODE,
                ExpectedStates
            );
        }
    }
}
