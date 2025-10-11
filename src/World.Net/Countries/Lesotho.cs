namespace World.Net.Countries
{
    internal sealed class Lesotho : ICountry
    {
        //<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Lesotho;

        //<inheritdoc/>
        public string Name { get; } = "Lesotho";

        //<inheritdoc/>
        public string OfficialName { get; } = "Kingdom of Lesotho";

        //<inheritdoc/>
        public string NativeName { get; } = "Muso oa Lesotho";

        //<inheritdoc/>
        public string Capital { get; } = "Maseru";

        //<inheritdoc/>
        public int NumericCode { get; } = 426;

        //<inheritdoc/>
        public string ISO2Code { get; } = "LS";

        //<inheritdoc/>
        public string ISO3Code { get; } = "LSO";

        //<inheritdoc/>
        public string[] CallingCode { get; } = ["+266"];

        //<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Berea", "LS-D", "District"),
            new("Butha-Buthe", "LS-B", "District"),
            new("Leribe", "LS-C", "District"),
            new("Mafeteng", "LS-E", "District"),
            new("Maseru", "LS-A", "District"),
            new("Mohale's Hoek", "LS-F", "District"),
            new("Mokhotlong", "LS-J", "District"),
            new("Qacha's Nek", "LS-H", "District"),
            new("Quthing", "LS-G", "District"),
            new("Thaba-Tseka", "LS-K", "District")
        ];
    }
}
