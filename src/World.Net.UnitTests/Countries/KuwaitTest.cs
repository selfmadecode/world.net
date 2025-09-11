using World.Net;
using World.Net.Countries;
using World.Net.Helpers;
using Xunit;

namespace World.Net.UnitTests.Countries
{
    public class KuwaitTest
    {
        private const CountryIdentifier ExpectedId = CountryIdentifier.Kuwait;
        private const string ExpectedName = "Kuwait";
        private const string ExpectedOfficialName = "State of Kuwait";
        private const string ExpectedNativeName = "???? ??????";
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
            Assert.Equal(ExpectedId, country.Id);
            Assert.Equal(ExpectedName, country.Name);
            Assert.Equal(ExpectedOfficialName, country.OfficialName);
            Assert.Equal(ExpectedNativeName, country.NativeName);
            Assert.Equal(ExpectedCapital, country.Capital);
            Assert.Equal(ExpectedNumericCode, country.NumericCode);
            Assert.Equal(ExpectedISO2Code, country.ISO2Code);
            Assert.Equal(ExpectedISO3Code, country.ISO3Code);
            Assert.Equal(ExpectedCallingCode, country.CallingCode);

            var states = country.States.ToArray();
            Assert.Equal(ExpectedStates.Length, states.Length);
            for (int i = 0; i < states.Length; i++)
            {
                Assert.Equal(ExpectedStates[i].Name, states[i].Name);
                Assert.Equal(ExpectedStates[i].IsoCode, states[i].IsoCode);
                Assert.Equal(ExpectedStates[i].Type, states[i].Type);
            }
        }
    }
}
