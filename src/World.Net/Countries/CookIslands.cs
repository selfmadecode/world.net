namespace World.Net.Countries
{
    internal sealed class CookIslands : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.CookIslands;

        ///<inheritdoc/>
        public string Name => "Cook Islands";

        ///<inheritdoc/>
        public string OfficialName { get; } = "Cook Islands";

        ///<inheritdoc/>
        public string NativeName { get; } = "Cook Islands";

        ///<inheritdoc/>
        public string Capital { get; } = "Avarua";

        ///<inheritdoc/>
        public int NumericCode { get; } = 184;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "CK";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "COK";

        ///<inheritdoc/>
        public string[] CallingCode { get; } = ["+682"];

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } = [];
    }
}
