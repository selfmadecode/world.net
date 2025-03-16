namespace World.Net.Countries
{
    internal sealed class Chad : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Chad;

        ///<inheritdoc/>
        public string Name => nameof(Chad);

        ///<inheritdoc/>
        public string OfficialName { get; } = "Republic of Chad";

        ///<inheritdoc/>
        public string NativeName { get; } = "Tchad";

        ///<inheritdoc/>
        public string Capital { get; } = "N'Djamena";

        ///<inheritdoc/>
        public int NumericCode { get; } = 148;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "TD";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "TCD";

        ///<inheritdoc/>
        public string CallingCode { get; } = "+235";

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Bahr el Gazel", "TD-BG", "Province"),
            new("Batha", "TD-BA", "Province"),
            new("Borkou", "TD-BO", "Province"),
            new("Chari-Baguirmi", "TD-CB", "Province"),
            new("Ennedi-Est", "TD-EE", "Province"),
            new("Ennedi-Ouest", "TD-EO", "Province"),
            new("Guéra", "TD-GR", "Province"),
            new("Hadjer-Lamis", "TD-HL", "Province"),
            new("Kanem", "TD-KA", "Province"),
            new("Lac", "TD-LC", "Province"),
            new("Logone Occidental", "TD-LO", "Province"),
            new("Logone Oriental", "TD-LR", "Province"),
            new("Mandoul", "TD-MA", "Province"),
            new("Mayo-Kebbi Est", "TD-ME", "Province"),
            new("Mayo-Kebbi Ouest", "TD-MO", "Province"),
            new("Moyen-Chari", "TD-MC", "Province"),
            new("N'Djamena", "TD-ND", "Province"),
            new("Ouaddaï", "TD-OD", "Province"),
            new("Salamat", "TD-SA", "Province"),
            new("Sila", "TD-SI", "Province"),
            new("Tandjilé", "TD-TA", "Province"),
            new("Tibesti", "TD-TI", "Province"),
            new("Wadi Fira", "TD-WF", "Province"),
        ];
    }
}
