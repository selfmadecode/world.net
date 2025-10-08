namespace World.Net.Countries
{
    internal sealed class Laos : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Laos;

        ///<inheritdoc/>
        public string Name { get; } = "Laos";

        ///<inheritdoc/>
        public string OfficialName { get; } = "Lao People's Democratic Republic";

        ///<inheritdoc/>
        public string NativeName { get; } = "ສາທາລະນະລັດ ປະຊາຊົນລາວ";

        ///<inheritdoc/>
        public string Capital { get; } = "Vientiane";

        ///<inheritdoc/>
        public int NumericCode { get; } = 418;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "LA";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "LAO";

        ///<inheritdoc/>
        public string[] CallingCode { get; } = ["+856"];

        public IEnumerable<State> States { get; } =
        [
            new("Attapeu", "LA-AT"),
            new("Bokeo", "LA-BK"),
            new("Bolikhamxai", "LA-BL"),
            new("Champasak", "LA-CH"),
            new("Houaphan", "LA-HO"),
            new("Khammouan", "LA-KH"),
            new("Luang Namtha", "LA-LM"),
            new("Luang Prabang", "LA-LP"),
            new("Oudomxai", "LA-OU"),
            new("Phongsaly", "LA-PH"),
            new("Salavan", "LA-SL"),
            new("Savannakhét", "LA-SV"),
            new("Sekong", "LA-XE"),
            new("Vientiane Province", "LA-VI"),
            new("Vientiane Prefecture", "LA-VT", "Prefecture"),
            new("Xaignabouli", "LA-XA"),
            new("Xaisomboun", "LA-XN"),
            new("Xiangkhouang", "LA-XI")
        ];
    }

}
