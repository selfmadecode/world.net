namespace World.Net.Countries
{
    internal sealed class EquatorialGuinea : ICountry
    {
        public CountryIdentifier Id => CountryIdentifier.EquatorialGuinea;

        public string Name => nameof(EquatorialGuinea);

        public string OfficialName => "Republic of Equatorial Guinea";

        public string NativeName => "República de Guinea Ecuatorial";

        public string Capital => "Malabo";

        public int NumericCode => 226;

        public string ISO2Code => "GQ";

        public string ISO3Code => "GNQ";

        public string[] CallingCode => new[] { "240" };

        public IEnumerable<State> States =>
        [
            new("Annobón", "AN", "Province"),
            new("Bioko Norte", "BN", "Province"),
            new("Bioko Sur", "BS", "Province"),
            new("Centro Sur", "CS", "Province"),
            new("Djibloho", "DJ", "Province"),
            new("Kié-Ntem", "KN", "Province"),
            new("Litoral", "LI", "Province"),
            new("Wele-Nzas", "WN", "Province")
        ];
    }

}
