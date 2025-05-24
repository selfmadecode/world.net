
namespace World.Net.Countries
{
    internal class Estonia : ICountry
    {
        public CountryIdentifier Id => CountryIdentifier.Estonia;

        public string Name => nameof(Estonia);

        public string OfficialName => "Republic of Estonia";

        public string NativeName => "Eesti";

        public string Capital => "Tallinn";

        public int NumericCode => 233;

        public string ISO2Code => "EE";

        public string ISO3Code => "EST";

        public string[] CallingCode => ["372"];

        public IEnumerable<State> States =>
        [
            new("Harju", "37", "County"),
            new("Hiiu", "39", "County"),
            new("Ida-Viru", "44", "County"),
            new("Jõgeva", "49", "County"),
            new("Järva", "51", "County"),
            new("Lääne", "57", "County"),
            new("Lääne-Viru", "59", "County"),
            new("Põlva", "65", "County"),
            new("Pärnu", "67", "County"),
            new("Rapla", "70", "County"),
            new("Saare", "74", "County"),
            new("Tartu", "78", "County"),
            new("Valga", "82", "County"),
            new("Viljandi", "84", "County"),
            new("Võru", "86", "County")
        ];
    }
}
