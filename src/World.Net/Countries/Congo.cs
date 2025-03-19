namespace World.Net.Countries
{
    internal sealed class Congo : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Congo;

        ///<inheritdoc/>
        public string Name => nameof(Congo);

        ///<inheritdoc/>
        public string OfficialName { get; } = "Democratic Republic of the Congo";

        ///<inheritdoc/>
        public string NativeName { get; } = "République du Congo";

        ///<inheritdoc/>
        public string Capital { get; } = "Brazzaville";

        ///<inheritdoc/>
        public int NumericCode { get; } = 178;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "CG";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "COG";

        ///<inheritdoc/>
        public string CallingCode { get; } = "+242";

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Bouenza", "CG-11", "Department"),
            new("Brazzaville", "CG-BZV", "Department"),
            new("Cuvette", "CG-8", "Department"),
            new("Cuvette-Ouest", "CG-15", "Department"),
            new("Kouilou", "CG-5", "Department"),
            new("Lékoumou", "CG-2", "Department"),
            new("Likouala", "CG-7", "Department"),
            new("Niari", "CG-9", "Department"),
            new("Plateaux", "CG-14", "Department"),
            new("Pointe-Noire", "CG-16", "Department"),
            new("Pool", "CG-12", "Department"),
            new("Sangha", "CG-13", "Department"),
        ];
    }
}
