namespace World.Net.Countries
{
    internal sealed class Lebanon : ICountry
    {
        //<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Lebanon;

        //<inheritdoc/>
        public string Name { get; } = "Lebanon";

        //<inheritdoc/>
        public string OfficialName { get; } = "Lebanese Republic";

        //<inheritdoc/>
        public string NativeName { get; } = "الجمهورية اللبنانية";

        //<inheritdoc/>
        public string Capital { get; } = "Beirut";

        //<inheritdoc/>
        public int NumericCode { get; } = 422;

        //<inheritdoc/>
        public string ISO2Code { get; } = "LB";

        //<inheritdoc/>
        public string ISO3Code { get; } = "LBN";

        //<inheritdoc/>
        public string[] CallingCode { get; } = ["+961"];

        //<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Akkar", "LB-AK", "Governorate"),
            new("Baalbek-Hermel", "LB-BH", "Governorate"),
            new("Beirut", "LB-BA", "Governorate"),
            new("Beqaa", "LB-BI", "Governorate"),
            new("Mount Lebanon", "LB-JL", "Governorate"),
            new("Nabatieh", "LB-NA", "Governorate"),
            new("North Lebanon", "LB-AS", "Governorate"),
            new("South Lebanon", "LB-JA", "Governorate")
        ];
    }

}
