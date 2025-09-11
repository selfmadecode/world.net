using World.Net;
using World.Net.Countries;
using World.Net.Helpers;
using Xunit;

namespace World.Net.UnitTests.Countries
{
    public class KosovoTest
    {
        private const CountryIdentifier ExpectedId = CountryIdentifier.Kosovo;
        private const string ExpectedName = "Kosovo";
        private const string ExpectedOfficialName = "Republic of Kosovo";
        private const string ExpectedNativeName = "Republika e Kosovës";
        private const string ExpectedCapital = "Pristina";
        private const int ExpectedNumericCode = 383;
        private const string ExpectedISO2Code = "XK";
        private const string ExpectedISO3Code = "XKX";
        private static readonly string[] ExpectedCallingCode = ["+383"];
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        [
            ("Ferizaj", "XK-05", "District"),
            ("Gjakovë", "XK-06", "District"),
            ("Gjilan", "XK-07", "District"),
            ("Mitrovicë", "XK-03", "District"),
            ("Pejë", "XK-02", "District"),
            ("Prishtinë", "XK-01", "District"),
            ("Prizren", "XK-04", "District")
        ];

        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForKosovo()
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
