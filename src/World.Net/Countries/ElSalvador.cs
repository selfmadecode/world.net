namespace World.Net.Countries
{
    internal class ElSalvador : ICountry
    {
        public CountryIdentifier Id => CountryIdentifier.ElSalvador;

        public string Name => nameof(ElSalvador);

        public string OfficialName => "Republic of El Salvador";

        public string NativeName => "República de El Salvador";

        public string Capital => "San Salvador";

        public int NumericCode => 222;

        public string ISO2Code => "SV";

        public string ISO3Code => "SLV";

        public string[] CallingCode => ["503"];

        public IEnumerable<State> States =>
        [
            new("Ahuachapán", "AH", "Department"),
            new("Cabañas", "CA", "Department"),
            new("Chalatenango", "CH", "Department"),
            new("Cuscatlán", "CU", "Department"),
            new("La Libertad", "LI", "Department"),
            new("La Paz", "PA", "Department"),
            new("La Unión", "UN", "Department"),
            new("Morazán", "MO", "Department"),
            new("San Miguel", "SM", "Department"),
            new("San Salvador", "SS", "Department"),
            new("San Vicente", "SV", "Department"),
            new("Santa Ana", "SA", "Department"),
            new("Sonsonate", "SO", "Department"),
            new("Usulután", "US", "Department")
        ];
    }
}
