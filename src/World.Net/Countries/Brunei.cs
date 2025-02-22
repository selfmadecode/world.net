namespace World.Net.Countries
{
    internal sealed class Brunei : ICountry
    {
        ///<inheritdoc/>
        public int Id => CountryIdentifier.Brunei;

        ///<inheritdoc/>
        public string Name => nameof(Brunei);

        ///<inheritdoc/>
        public string OfficialName { get; } = "Nation of Brunei, the Abode of Peace";

        ///<inheritdoc/>
        public string NativeName { get; } = "Negara Brunei Darussalam";

        ///<inheritdoc/>
        public string Capital { get; } = "Bandar Seri Begawan";

        ///<inheritdoc/>
        public int NumericCode { get; } = 096;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "BN";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "BRN";

        ///<inheritdoc/>
        public string CallingCode { get; } = "+673";

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Belait", "BE", "District"),
            new("Brunei-Muara", "BM", "District"),
            new("Temburong", "TE", "District"),
            new("Tutong", "TU", "District"),
        ];
    }
}
