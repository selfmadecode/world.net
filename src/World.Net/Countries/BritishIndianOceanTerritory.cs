namespace World.Net.Countries
{
    internal sealed class BritishIndianOceanTerritory : ICountry
    {
        ///<inheritdoc/>
        public int Id => CountryIdentifier.BritishIndianOceanTerritory;

        ///<inheritdoc/>
        public string Name => "British Indian Ocean Territory";

        ///<inheritdoc/>
        public string OfficialName { get; } = "British Indian Ocean Territory";

        ///<inheritdoc/>
        public string NativeName { get; } = "British Indian Ocean Territory";

        ///<inheritdoc/>
        public string Capital { get; } = "Diego Garcia";

        ///<inheritdoc/>
        public int NumericCode { get; } = 086;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "IO";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "IOT";

        ///<inheritdoc/>
        public string CallingCode { get; } = "+246";

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [

        ];
    }
}
