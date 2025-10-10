namespace World.Net.UnitTests.Countries
{
    public class LiberiaTest : AssertCountryTestBase
    {
        public static CountryIdentifier Id => CountryIdentifier.Liberia;
        public string Name { get; } = "Liberia";
        public string OfficialName { get; } = "Republic of Liberia";
        public string NativeName { get; } = "Republic of Liberia";
        public string Capital { get; } = "Monrovia";
        public int NumericCode { get; } = 430;
        public string ISO2Code { get; } = "LR";
        public string ISO3Code { get; } = "LBR";
        public string[] CallingCode { get; } = ["+231"];
        private static readonly (string Name, string IsoCode, string Type)[] States =
        [
            new("Bomi", "LR-BM", "County"),
            new("Bong", "LR-BG", "County"),
            new("Gbarpolu", "LR-GP", "County"),
            new("Grand Bassa", "LR-GB", "County"),
            new("Grand Cape Mount", "LR-CM", "County"),
            new("Grand Gedeh", "LR-GG", "County"),
            new("Grand Kru", "LR-GK", "County"),
            new("Lofa", "LR-LO", "County"),
            new("Margibi", "LR-MG", "County"),
            new("Maryland", "LR-MY", "County"),
            new("Montserrado", "LR-MO", "County"),
            new("Nimba", "LR-NI", "County"),
            new("River Cess", "LR-RI", "County"),
            new("River Gee", "LR-RG", "County"),
            new("Sinoe", "LR-SI", "County")
        ];


        [Fact]
        public void GetCountry_ReturnsCorrectInformation_ForLebanon()
        {
            var country = CountryProvider.GetCountry(Id);

            AssertCorrectInformation(
                country,
                Id,
                Name,
                OfficialName,
                NativeName,
                Capital,
                NumericCode,
                ISO2Code,
                ISO3Code,
                CallingCode,
                States
            );
        }
    }
}
