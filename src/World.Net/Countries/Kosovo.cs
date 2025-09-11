namespace World.Net.Countries
{
    internal sealed class Kosovo : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Kosovo;

        ///<inheritdoc/>
        public string Name => "Kosovo";

        ///<inheritdoc/>
        public string OfficialName { get; } = "Republic of Kosovo";

        ///<inheritdoc/>
        public string NativeName { get; } = "Republika e Kosovës";

        ///<inheritdoc/>
        public string Capital { get; } = "Pristina";

        ///<inheritdoc/>
        public int NumericCode { get; } = 383;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "XK";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "XKX";

        ///<inheritdoc/>
        public string[] CallingCode { get; } = ["+383"];

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new State("Ferizaj", "XK-05", "District"),
            new State("Gjakovë", "XK-06", "District"),
            new State("Gjilan", "XK-07", "District"),
            new State("Mitrovicë", "XK-03", "District"),
            new State("Pejë", "XK-02", "District"),
            new State("Prishtinë", "XK-01", "District"),
            new State("Prizren", "XK-04", "District")
        ];
    }
}
