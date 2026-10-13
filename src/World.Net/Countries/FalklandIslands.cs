namespace World.Net.Countries
{
    internal sealed class FalklandIslands : ICountry
    {
        public CountryIdentifier Id => CountryIdentifier.FalklandIslands;

        public string Name => nameof(FalklandIslands);

        public string OfficialName => "Falkland Islands";

        public string NativeName => "Falkland Islands";

        public string Capital => "Stanley";

        public int NumericCode => 238;

        public string ISO2Code => "FK";

        public string ISO3Code => "FLK";

        public string[] CallingCode => ["500"];
        public IReadOnlyCollection<string> TimeZones { get; } = ["Atlantic/Stanley", "UTC-3"];

        public IEnumerable<State> States =>
        [
            new("Falkland Islands", "FK", "Overseas Territory")
        ];
    }

}
