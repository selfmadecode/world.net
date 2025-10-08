namespace World.Net.UnitTests.Countries
{
    public class LaosTest
    {
        private const CountryIdentifier ExpectedId = CountryIdentifier.Laos;
        private const string ExpectedName = "Laos";
        private const string ExpectedOfficialName = "Lao People's Democratic Republic";
        private const string ExpectedNativeName = "ສາທາລະນະລັດ ປະຊາຊົນລາວ";
        private const string ExpectedCapital = "Vientiane";
        private const int ExpectedNumericCode = 418;
        private const string ExpectedISO2Code = "LA";
        private const string ExpectedISO3Code = "LAO";
        private static readonly string[] ExpectedCallingCode = ["+856"];
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        [
            ("Attapeu", "LA-AT", "Province"),
            ("Bokeo", "LA-BK", "Province"),
            ("Bolikhamxai", "LA-BL", "Province"),
            ("Champasak", "LA-CH", "Province"),
            ("Houaphan", "LA-HO", "Province"),
            ("Khammouan", "LA-KH", "Province"),
            ("Luang Namtha", "LA-LM", "Province"),
            ("Luang Prabang", "LA-LP", "Province"),
            ("Oudomxai", "LA-OU", "Province"),
            ("Phongsaly", "LA-PH", "Province"),
            ("Salavan", "LA-SL", "Province"),
            ("Savannakhét", "LA-SV", "Province"),
            ("Sekong", "LA-XE", "Province"),
            ("Vientiane Province", "LA-VI", "Province"),
            ("Vientiane Prefecture", "LA-VT", "Prefecture"),
            ("Xaignabouli", "LA-XA", "Province"),
            ("Xaisomboun", "LA-XN", "Province"),
            ("Xiangkhouang", "LA-XI", "Province")
        ];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForLaos()
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
