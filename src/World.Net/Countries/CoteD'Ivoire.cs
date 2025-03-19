namespace World.Net.Countries
{
    internal sealed class CoteDIvoire : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.CoteDIvoire;

        ///<inheritdoc/>
        public string Name => "Ivory Coast";

        ///<inheritdoc/>
        public string OfficialName { get; } = "Republic of Côte d'Ivoire";

        ///<inheritdoc/>
        public string NativeName { get; } = "Côte d'Ivoire";

        ///<inheritdoc/>
        public string Capital { get; } = "Yamoussoukro";

        ///<inheritdoc/>
        public int NumericCode { get; } = 384;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "CI";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "CIV";

        ///<inheritdoc/>
        public string CallingCode { get; } = "+225";

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Abidjan", "CI-AB", "Autonomous District"),
            new("Agnéby", "CI-16", "Region"),
            new("Bafing", "CI-17", "Region"),
            new("Bas-Sassandra", "CI-BS", "District"),
            new("Bas-Sassandra", "CI-09", "Region"),
            new("Comoé", "CI-CM", "District"),
            new("Denguélé", "CI-DN", "District"),
            new("Denguélé", "CI-10", "Region"),
            new("Dix-Huit Montagnes", "CI-06", "Region"),
            new("Fromager", "CI-18", "Region"),
            new("Gôh-Djiboua", "CI-GD", "District"),
            new("Haut-Sassandra", "CI-02", "Region"),
            new("Lacs", "CI-07", "Region"),
            new("Lacs", "CI-LC", "District"),
            new("Lagunes", "CI-01", "Region"),
            new("Lagunes", "CI-LG", "District"),
            new("Marahoué", "CI-12", "Region"),
            new("Montagnes", "CI-MG", "District"),
            new("Moyen-Cavally", "CI-19", "Region"),
            new("Moyen-Comoé", "CI-05", "Region"),
            new("N'zi-Comoé", "CI-11", "Region"),
            new("Sassandra-Marahoué", "CI-SM", "District"),
            new("Savanes", "CI-03", "Region"),
            new("Sud-Bandama", "CI-15", "Region"),
            new("Sud-Comoé", "CI-13", "Region"),
            new("Vallée du Bandama", "CI-04", "Region"),
            new("Vallée du Bandama", "CI-VB", "District"),
            new("Woroba", "CI-WR", "District"),
            new("Worodougou", "CI-14", "Region"),
            new("Yamoussoukro", "CI-YM", "District"),
            new("Zanzan", "CI-ZZ", "District"),
        ];
    }
}
