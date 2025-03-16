namespace World.Net.Countries
{
    internal sealed class CentralAfricanRepublic : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.CentralAfricanRepublic;

        ///<inheritdoc/>
        public string Name => "Central African Republic";

        ///<inheritdoc/>
        public string OfficialName { get; } = "Central African Republic";

        ///<inheritdoc/>
        public string NativeName { get; } = "Ködörösêse tî Bêafrîka";

        ///<inheritdoc/>
        public string Capital { get; } = "Bangui";

        ///<inheritdoc/>
        public int NumericCode { get; } = 140;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "CF";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "CAF";

        ///<inheritdoc/>
        public string CallingCode { get; } = "+236";

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Bamingui-Bangoran", "CF-BB", "Prefecture"),
            new("Bangui", "CF-BGF", "Commune"),
            new("Basse-Kotto", "CF-BK", "Prefecture"),
            new("Haut-Mbomou", "CF-HM", "Prefecture"),
            new("Haute-Kotto", "CF-HK", "Prefecture"),
            new("Kémo", "CF-KG", "Prefecture"),
            new("Lobaye", "CF-LB", "Prefecture"),
            new("Mambéré-Kadéï", "CF-HS", "Prefecture"),
            new("Mbomou", "CF-MB", "Prefecture"),
            new("Nana-Grébizi", "CF-KB", "Economic Prefecture"),
            new("Nana-Mambéré", "CF-NM", "Prefecture"),
            new("Ombella-M'Poko", "CF-MP", "Prefecture"),
            new("Ouaka", "CF-UK", "Prefecture"),
            new("Ouham", "CF-AC", "Prefecture"),
            new("Ouham-Pendé", "CF-OP", "Prefecture"),
            new("Sangha-Mbaéré", "CF-SE", "Prefecture"),
            new("Vakaga", "CF-VK", "Prefecture"),
        ];
    }
}
