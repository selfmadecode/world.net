namespace World.Net.UnitTests
{
    public abstract class AssertCountryTestBase
    {
        protected static void AssertCorrectInformation(
            ICountry country,
            CountryIdentifier expectedId,
            string expectedName,
            string expectedOfficialName,
            string expectedNativeName,
            string expectedCapital,
            int expectedNumericCode,
            string expectedISO2Code,
            string expectedISO3Code,
            string[] expectedCallingCode,
            (string Name, string IsoCode, string Type)[] expectedStates)
        {
            Assert.Equal(expectedId, country.Id);
            Assert.Equal(expectedName, country.Name);
            Assert.Equal(expectedOfficialName, country.OfficialName);
            Assert.Equal(expectedNativeName, country.NativeName);
            Assert.Equal(expectedCapital, country.Capital);
            Assert.Equal(expectedNumericCode, country.NumericCode);
            Assert.Equal(expectedISO2Code, country.ISO2Code);
            Assert.Equal(expectedISO3Code, country.ISO3Code);
            Assert.Equal(expectedCallingCode, country.CallingCode);

            var states = country.States.ToArray();
            Assert.Equal(expectedStates.Length, states.Length);

            for (int i = 0; i < states.Length; i++)
            {
                Assert.Equal(expectedStates[i].Name, states[i].Name);
                Assert.Equal(expectedStates[i].IsoCode, states[i].IsoCode);
                Assert.Equal(expectedStates[i].Type, states[i].Type);
            }
        }
    }
}
