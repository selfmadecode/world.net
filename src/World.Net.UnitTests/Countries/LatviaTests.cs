namespace World.Net.UnitTests.Countries
{
    public class LatviaTests : AssertCountryTestBase
    {
        private const CountryIdentifier ExpectedId = CountryIdentifier.Latvia;
        private const string ExpectedName = "Latvia";
        private const string ExpectedOfficialName = "Republic of Latvia";
        private const string ExpectedNativeName = "Latvijas Republika";
        private const string ExpectedCapital = "Riga";
        private const int ExpectedNumericCode = 428;
        private const string ExpectedISO2Code = "LV";
        private const string ExpectedISO3Code = "LVA";
        private static readonly string[] ExpectedCallingCode = ["+371"];
        private static readonly (string Name, string IsoCode, string Type)[] ExpectedStates =
        [
            ("Aizkraukle", "LV-AI", "Municipality"),
            ("Alūksne", "LV-AL", "Municipality"),
            ("Balvi", "LV-BL", "Municipality"),
            ("Bauska", "LV-BU", "Municipality"),
            ("Cēsis", "LV-CE", "Municipality"),
            ("Dobele", "LV-DO", "Municipality"),
            ("Gulbene", "LV-GU", "Municipality"),
            ("Jelgava", "LV-JL", "Municipality"),
            ("Jēkabpils", "LV-JK", "Municipality"),
            ("Krāslava", "LV-KR", "Municipality"),
            ("Kuldīga", "LV-KU", "Municipality"),
            ("Limbaži", "LV-LM", "Municipality"),
            ("Līvāni", "LV-LV", "Municipality"),
            ("Ludza", "LV-LU", "Municipality"),
            ("Madona", "LV-MA", "Municipality"),
            ("Ogre", "LV-OG", "Municipality"),
            ("Preiļi", "LV-PR", "Municipality"),
            ("Rēzekne", "LV-RE", "Municipality"),
            ("Riga", "LV-RI", "Municipality"),
            ("Saldus", "LV-SA", "Municipality"),
            ("Sigulda", "LV-SI", "Municipality"),
            ("Smiltene", "LV-SM", "Municipality"),
            ("Talsi", "LV-TA", "Municipality"),
            ("Tukums", "LV-TU", "Municipality"),
            ("Valka", "LV-VA", "Municipality"),
            ("Valmiera", "LV-VM", "Municipality"),
            ("Ventspils", "LV-VE", "Municipality"),
            ("Augšdaugava", "LV-AD", "Municipality"),
            ("Dienvidkurzeme", "LV-DK", "Municipality"),
            ("Rēzekne City", "LV-RC", "Republic City"),
            ("Daugavpils City", "LV-DC", "Republic City"),
            ("Jelgava City", "LV-JC", "Republic City"),
            ("Jūrmala City", "LV-JU", "Republic City"),
            ("Liepāja City", "LV-LP", "Republic City"),
            ("Riga City", "LV-RG", "Republic City"),
            ("Ventspils City", "LV-VC", "Republic City")
            ];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForLaos()
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
