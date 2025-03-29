namespace World.Net.Countries;

internal sealed class TimorLeste : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.TimorLeste;

    //<inheritdoc/>
    public string Name { get; } = "Timor-Leste";

    //<inheritdoc/>
    public string OfficialName { get; } = "Democratic Republic of Timor-Leste";

    //<inheritdoc/>
    public string NativeName => "Repúblika Demokrátika Timór-Leste";

    //<inheritdoc/>
    public string Capital { get; } = "Dili";

    //<inheritdoc/>
    public int NumericCode { get; } = 626;

    //<inheritdoc/>
    public string ISO2Code { get; } = "TL";

    //<inheritdoc/>
    public string ISO3Code { get; } = "TLS";

    //<inheritdoc/>
    public string CallingCode { get; } = "+670";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Aileu", "TL-AL", "Municipality"),
        new("Ainaro", "TL-AN", "Municipality"),
        new("Baucau", "TL-BA", "Municipality"),
        new("Bobonaro", "TL-BO", "Municipality"),
        new("Cova Lima", "TL-CO", "Municipality"),
        new("Dili", "TL-DI", "Municipality"),
        new("Ermera", "TL-ER", "Municipality"),
        new("Lautém", "TL-LA", "Municipality"),
        new("Liquiça", "TL-LI", "Municipality"),
        new("Manatuto", "TL-MT", "Municipality"),
        new("Manufahi", "TL-MF", "Municipality"),
        new("Viqueque", "TL-VI", "Municipality"),
        new("Oecusse", "TL-OE", "Special Administrative Region")
    ];
}
