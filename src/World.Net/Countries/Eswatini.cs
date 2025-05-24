namespace World.Net.Countries
{
    internal sealed class Eswatini : ICountry
    {
        public CountryIdentifier Id => CountryIdentifier.Eswatini;

        public string Name => nameof(Eswatini);

        public string OfficialName => "Kingdom of Eswatini";

        public string NativeName => "eSwatini";

        public string Capital => "Mbabane";

        public int NumericCode => 748;

        public string ISO2Code => "SZ";

        public string ISO3Code => "SWZ";

        public string[] CallingCode => ["268"];

        public IEnumerable<State> States =>
        [
            new State("Hhohho", "HH", "Region"),
            new State("Lubombo", "LU", "Region"),
            new State("Manzini", "MA", "Region"),
            new State("Shiselweni", "SH", "Region")
        ];
    }

}
