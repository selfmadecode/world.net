namespace World.Net.Countries;

internal sealed class Spain : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Spain;

    //<inheritdoc/>
    public string Name { get; } = "Spain";

    //<inheritdoc/>
    public string OfficialName { get; } = "Kingdom of Spain";

    //<inheritdoc/>
    public string NativeName => "España";

    //<inheritdoc/>
    public string Capital { get; } = "Madrid";

    //<inheritdoc/>
    public int NumericCode { get; } = 724;

    //<inheritdoc/>
    public string ISO2Code { get; } = "ES";

    //<inheritdoc/>
    public string ISO3Code { get; } = "ESP";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+34"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Andalusia", "ES-AN", "Autonomous Community"),
        new State("Aragon", "ES-AR", "Autonomous Community"),
        new State("Asturias", "ES-AS", "Autonomous Community"),
        new State("Balearic Islands", "ES-IB", "Autonomous Community"),
        new State("Basque Country", "ES-PV", "Autonomous Community"),
        new State("Canary Islands", "ES-CN", "Autonomous Community"),
        new State("Cantabria", "ES-CB", "Autonomous Community"),
        new State("Castile and León", "ES-CL", "Autonomous Community"),
        new State("Castile-La Mancha", "ES-CM", "Autonomous Community"),
        new State("Catalonia", "ES-CT", "Autonomous Community"),
        new State("Extremadura", "ES-EX", "Autonomous Community"),
        new State("Galicia", "ES-GA", "Autonomous Community"),
        new State("La Rioja", "ES-RI", "Autonomous Community"),
        new State("Community of Madrid", "ES-MD", "Autonomous Community"),
        new State("Region of Murcia", "ES-MC", "Autonomous Community"),
        new State("Navarre", "ES-NC", "Autonomous Community"),
        new State("Valencian Community", "ES-VC", "Autonomous Community"),

        new State("Ceuta", "ES-CE", "Autonomous City"),
        new State("Melilla", "ES-ML", "Autonomous City")
    };
}

