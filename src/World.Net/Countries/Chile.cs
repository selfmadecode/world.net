namespace World.Net.Countries
{
    internal sealed class Chile : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Chile;

        ///<inheritdoc/>
        public string Name => nameof(Chile);

        ///<inheritdoc/>
        public string OfficialName { get; } = "Republic of Chile";

        ///<inheritdoc/>
        public string NativeName { get; } = "Chile";

        ///<inheritdoc/>
        public string Capital { get; } = "Santiago";

        ///<inheritdoc/>
        public int NumericCode { get; } = 152;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "CL";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "CHL";

        ///<inheritdoc/>
        public string CallingCode { get; } = "+56";

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Aisén del General Carlos Ibañez del Campo", "CL-AI", "Region"),
            new("Antofagasta", "CL-AN", "Region"),
            new("Arica y Parinacota", "CL-AP", "Region"),
            new("Atacama", "CL-AT", "Region"),
            new("Biobío", "CL-BI", "Region"),
            new("Coquimbo", "CL-CO", "Region"),
            new("La Araucanía", "CL-AR", "Region"),
            new("Libertador General Bernardo O'Higgins", "CL-LI", "Region"),
            new("Los Lagos", "CL-LL", "Region"),
            new("Los Ríos", "CL-LR", "Region"),
            new("Magallanes y de la Antártica Chilena", "CL-MA", "Region"),
            new("Maule", "CL-ML", "Region"),
            new("Ñuble", "CL-NB", "Region"),
            new("Región Metropolitana de Santiago", "CL-RM", "Region"),
            new("Tarapacá", "CL-TA", "Region"),
            new("Valparaíso", "CL-VS", "Region"),
        ];
    }
}
