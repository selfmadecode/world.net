using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World.Net.UnitTests.Countries
{
    public class EritreaTest : AssertCountryTestBase
    {
        private const string ERITREA_NAME = "Eritrea";
        private const int ERITREA_STATE_COUNT = 6;
        private const string ERITREA_OFFICIAL_NAME = "State of Eritrea";
        private const string ERITREA_NATIVE_NAME = "ሃገረ ኤርትራ";
        private const string ERITREA_CAPITAL = "Asmara";
        private const int ERITREA_NUMERIC_CODE = 232;
        private const string ERITREA_ISO2_CODE = "ER";
        private const string ERITREA_ISO3_CODE = "ERI";
        private readonly string[] ERITREA_CALLING_CODE = ["291"];
        private static readonly string[] VALID_STATE_TYPES = { "Region" };
        private static CountryIdentifier ExpectedId => CountryIdentifier.Eritrea;
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        {
            new("Anseba", "AN", "Region"),
            new("Debub", "DU", "Region"),
            new("Debubawi Keyih Bahri", "DK", "Region"),
            new("Gash-Barka", "GB", "Region"),
            new("Maekel", "MA", "Region"),
            new("Semenawi Keyih Bahri", "SK", "Region")
        };

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForEritrea()
        {
            // Arrange
            // Act
            var country = CountryProvider.GetCountry(ExpectedId);

            // Assert
            AssertCorrectInformation(
                country,
                ExpectedId,
                ERITREA_NAME,
                ERITREA_OFFICIAL_NAME,
                ERITREA_NATIVE_NAME,
                ERITREA_CAPITAL,
                ERITREA_NUMERIC_CODE,
                ERITREA_ISO2_CODE,
                ERITREA_ISO3_CODE,
                ERITREA_CALLING_CODE,
                ExpectedStates
            );
        }
    }
}
