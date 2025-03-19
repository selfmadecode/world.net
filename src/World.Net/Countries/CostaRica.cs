namespace World.Net.Countries
{
    internal sealed class CostaRica : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.CostaRica;

        ///<inheritdoc/>
        public string Name => "Costa Rica";

        ///<inheritdoc/>
        public string OfficialName { get; } = "Republic of Costa Rica";

        ///<inheritdoc/>
        public string NativeName { get; } = "Costa Rica";

        ///<inheritdoc/>
        public string Capital { get; } = "San Jose";

        ///<inheritdoc/>
        public int NumericCode { get; } = 188;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "CR";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "CRI";

        ///<inheritdoc/>
        public string CallingCode { get; } = "+506";

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Alajuela", "CR-A", "Province"),
            new("Cartago", "CR-C", "Province"),
            new("Guanacaste", "CR-G", "Province"),
            new("Heredia", "CR-H", "Province"),
            new("Limón", "CR-L", "Province"),
            new("Puntarenas", "CR-P", "Province"),
            new("San José", "CR-SJ", "Province"),
        ];
    }
}
