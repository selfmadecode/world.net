namespace World.Net.Countries
{
    internal sealed class Eritrea : ICountry
    {
        public CountryIdentifier Id => CountryIdentifier.Eritrea;

        public string Name => nameof(Eritrea);

        public string OfficialName => "State of Eritrea";

        public string NativeName => "ሃገረ ኤርትራ"; // Tigrinya: Hagere Ertra

        public string Capital => "Asmara";

        public int NumericCode => 232;

        public string ISO2Code => "ER";

        public string ISO3Code => "ERI";

        public string[] CallingCode => ["291"];

        public IEnumerable<State> States =>
        [
            new("Anseba", "AN", "Region"),
            new("Debub", "DU", "Region"),
            new("Debubawi Keyih Bahri", "DK", "Region"),
            new("Gash-Barka", "GB", "Region"),
            new("Maekel", "MA", "Region"),
            new("Semenawi Keyih Bahri", "SK", "Region")
        ];
    }

}
