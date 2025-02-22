namespace World.Net.Countries
{
    internal sealed class Brazil : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Brazil;

        ///<inheritdoc/>
        public string Name => nameof(Brazil);

        ///<inheritdoc/>
        public string OfficialName { get; } = "Federative Republic of Brazil";

        ///<inheritdoc/>
        public string NativeName { get; } = "Brasil";

        ///<inheritdoc/>
        public string Capital { get; } = "Brasilia";

        ///<inheritdoc/>
        public int NumericCode { get; } = 076;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "BR";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "BRA";

        ///<inheritdoc/>
        public string CallingCode { get; } = "+55";

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Acre", "AC", "State"),
            new("Alagoas", "AL", "State"),
            new("Amapá", "AP", "State"),
            new("Amazonas", "AM", "State"),
            new("Bahia", "BA", "State"),
            new("Ceará", "CE", "State"),
            new("Distrito Federal", "DF", "Federal District"),
            new("Espírito Santo", "ES", "State"),
            new("Goiás", "GO", "State"),
            new("Maranhão", "MA", "State"),
            new("Mato Grosso", "MT", "State"),
            new("Mato Grosso do Sul", "MS", "State"),
            new("Minas Gerais", "MG", "State"),
            new("Pará", "PA", "State"),
            new("Paraíba", "PB", "State"),
            new("Paraná", "PR", "State"),
            new("Pernambuco", "PE", "State"),
            new("Piauí", "PI", "State"),
            new("Rio de Janeiro", "RJ", "State"),
            new("Rio Grande do Norte", "RN", "State"),
            new("Rio Grande do Sul", "RS", "State"),
            new("Rondônia", "RO", "State"),
            new("Roraima", "RR", "State"),
            new("Santa Catarina", "SC", "State"),
            new("São Paulo", "SP", "State"),
            new("Sergipe", "SE", "State"),
            new("Tocantins", "TO", "State"),
        ];
    }
}
