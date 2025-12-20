namespace World.Net.UnitTests.Countries
{
    public class KuwaitTest : AssertCountryTestBase
    {
        private const CountryIdentifier ExpectedId = CountryIdentifier.Kuwait;
        private const string ExpectedName = "Kuwait";
        private const string ExpectedOfficialName = "State of Kuwait";
        private const string ExpectedNativeName = "دولة الكويت";
        private const string ExpectedCapital = "Kuwait City";
        private const int ExpectedNumericCode = 414;
        private const string ExpectedISO2Code = "KW";
        private const string ExpectedISO3Code = "KWT";
        private static readonly string[] ExpectedCallingCode = ["+965"];
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        [
            ("Al Ahmadi", "KW-AH", "Governorate"),
            ("Al Farwaniyah", "KW-FA", "Governorate"),
            ("Al Asimah", "KW-KU", "Governorate"),
            ("Al Jahra", "KW-JA", "Governorate"),
            ("Hawalli", "KW-HA", "Governorate"),
            ("Mubarak Al-Kabeer", "KW-MU", "Governorate")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForKuwait()
        {
            var country = CountryProvider.GetCountry(ExpectedId);
            
            AssertCorrectInformation(
                country,
                ExpectedId,
                ExpectedName,
                ExpectedOfficialName,
                ExpectedNativeName,
                ExpectedCapital,
                ExpectedNumericCode,
                ExpectedISO2Code,
                ExpectedISO3Code,
                ExpectedCallingCode,
                ExpectedStates
            );
        }
    }
}
