using World.Net;
using World.Net.Countries;
using World.Net.Helpers;
using Xunit;

namespace World.Net.UnitTests.Countries
{
    public class KyrgyzstanTest
    {
        private const CountryIdentifier ExpectedId = CountryIdentifier.Kyrgyzstan;
        private const string ExpectedName = "Kyrgyzstan";
        private const string ExpectedOfficialName = "Kyrgyz Republic";
        private const string ExpectedNativeName = "?????? ????????????";
        private const string ExpectedCapital = "Bishkek";
        private const int ExpectedNumericCode = 417;
        private const string ExpectedISO2Code = "KG";
        private const string ExpectedISO3Code = "KGZ";
        private static readonly string[] ExpectedCallingCode = ["+996"];
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        [
            ("Batken", "KG-B", "Region"),
            ("Chuy", "KG-C", "Region"),
            ("Jalal-Abad", "KG-J", "Region"),
            ("Naryn", "KG-N", "Region"),
            ("Osh", "KG-O", "Region"),
            ("Talas", "KG-T", "Region"),
            ("Ysyk-Kol", "KG-Y", "Region"),
            ("Bishkek", "KG-GB", "City"),
            ("Osh City", "KG-GO", "City")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForKyrgyzstan()
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
