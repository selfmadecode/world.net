namespace World.Net.Countries
{
    internal sealed class Bulgaria : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Bulgaria;

        ///<inheritdoc/>
        public string Name => nameof(Bulgaria);

        ///<inheritdoc/>
        public string OfficialName { get; } = "Republic of Bulgaria";

        ///<inheritdoc/>
        public string NativeName { get; } = "България";

        ///<inheritdoc/>
        public string Capital { get; } = "Sofia";

        ///<inheritdoc/>
        public int NumericCode { get; } = 100;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "BG";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "BGR";

        ///<inheritdoc/>
        public string CallingCode { get; } = "+359";

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Blagoevgrad", "BG-01", "District"),
            new("Burgas", "BG-02", "District"),
            new("Varna", "BG-03", "District"),
            new("Veliko Tarnovo", "BG-04", "District"),
            new("Vidin", "BG-05", "District"),
            new("Vratsa", "BG-06", "District"),
            new("Gabrovo", "BG-07", "District"),
            new("Dobrich", "BG-08", "District"),
            new("Kardzhali", "BG-09", "District"),
            new("Kyustendil", "BG-10", "District"),
            new("Lovech", "BG-11", "District"),
            new("Montana", "BG-12", "District"),
            new("Pazardzhik", "BG-13", "District"),
            new("Pernik", "BG-14", "District"),
            new("Pleven", "BG-15", "District"),
            new("Plovdiv", "BG-16", "District"),
            new("Razgrad", "BG-17", "District"),
            new("Ruse", "BG-18", "District"),
            new("Silistra", "BG-19", "District"),
            new("Sliven", "BG-20", "District"),
            new("Smolyan", "BG-21", "District"),
            new("Sofia City", "BG-22", "District"),
            new("Sofia", "BG-23", "District"),
            new("Stara Zagora", "BG-24", "District"),
            new("Targovishte", "BG-25", "District"),
            new("Haskovo", "BG-26", "District"),
            new("Shumen", "BG-27", "District"),
            new("Yambol", "BG-28", "District"),
        ];
    }
}
