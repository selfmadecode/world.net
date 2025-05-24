namespace World.Net.Countries
{
    internal sealed class Ethiopia : ICountry
    {
        public CountryIdentifier Id => CountryIdentifier.Ethiopia;

        public string Name => nameof(Ethiopia);

        public string OfficialName => "Federal Democratic Republic of Ethiopia";

        public string NativeName => "ኢትዮጵያ";

        public string Capital => "Addis Ababa";

        public int NumericCode => 231;

        public string ISO2Code => "ET";

        public string ISO3Code => "ETH";

        public string[] CallingCode => ["251"];

        public IEnumerable<State> States =>
        [
            new("Addis Ababa", "AA", "Administration"),
            new("Afar", "AF", "Region"),
            new("Amhara", "AM", "Region"),
            new("Benishangul-Gumuz", "BE", "Region"),
            new("Dire Dawa", "DD", "Administration"),
            new("Gambela", "GA", "Region"),
            new("Harari", "HA", "Region"),
            new("Oromia", "OR", "Region"),
            new("Sidama", "SI", "Region"),
            new("Somali", "SO", "Region"),
            new("Southern Nations, Nationalities, and Peoples' Region", "SN", "Region"),
            new("Tigray", "TI", "Region")
        ];
    }
}
