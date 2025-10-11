namespace World.Net.Countries
{
    internal sealed class Libya : ICountry
    {

        //<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Libya;

        //<inheritdoc/>
        public string Name { get; } = "Libya";

        //<inheritdoc/>
        public string OfficialName { get; } = "State of Libya";

        //<inheritdoc/>
        public string NativeName { get; } = "دولة ليبيا";

        //<inheritdoc/>
        public string Capital { get; } = "Tripoli";

        //<inheritdoc/>
        public int NumericCode { get; } = 434;

        //<inheritdoc/>
        public string ISO2Code { get; } = "LY";

        //<inheritdoc/>
        public string ISO3Code { get; } = "LBY";

        //<inheritdoc/>
        public string[] CallingCode { get; } = ["+218"];

        //<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Al Butnan", "LY-BU", "District"),
            new("Al Jabal al Akhdar", "LY-JA", "District"),
            new("Al Jabal al Gharbi", "LY-JG", "District"),
            new("Al Jafara", "LY-JI", "District"),
            new("Al Jufra", "LY-JU", "District"),
            new("Al Kufra", "LY-KF", "District"),
            new("Al Marj", "LY-MJ", "District"),
            new("Al Marqab", "LY-MB", "District"),
            new("Al Wahat", "LY-WA", "District"),
            new("Nalut", "LY-NL", "District"),
            new("Misrata", "LY-MI", "District"),
            new("Murzuq", "LY-MQ", "District"),
            new("Sabha", "LY-SB", "District"),
            new("Sirt", "LY-SR", "District"),
            new("Tripoli", "LY-TB", "District"),
            new("Wadi al Hayat", "LY-WD", "District"),
            new("Wadi ash Shati'", "LY-WS", "District"),
            new("Zawiya", "LY-ZA", "District")
        ];
    }

}
