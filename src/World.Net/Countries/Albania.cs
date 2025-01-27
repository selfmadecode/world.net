namespace World.Net.Countries;

internal sealed class Albania : ICountry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.Albania;

    ///<inheritdoc/>
    public string Name => nameof(Albania);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Republic of Albania";

    ///<inheritdoc/>
    public string NativeName { get; } = "Republika e Shqipërisë";

    ///<inheritdoc/>
    public string Capital { get; } = "Tirana";

    ///<inheritdoc/>
    public int NumericCode { get; } = 008;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AL";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "ALB";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+355";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Berat", "AL-BR", "District"),
        new("Berat", "AL-01", "County"),
        new("Bulqizë", "AL-BU", "District"),
        new("Delvinë", "AL-DL", "District"),
        new("Devoll", "AL-DV", "District"),
        new("Dibër", "AL-09", "County"),
        new("Dibër", "AL-DI", "District"),
        new("Durrës", "AL-DR", "District"),
        new("Durrës", "AL-02", "County"),
        new("Elbasan", "AL-03", "County"),
        new("Fier", "AL-FR", "District"),
        new("Fier", "AL-04", "County"),
        new("Gjirokastër", "AL-GJ", "District"),
        new("Gjirokastër", "AL-05", "County"),
        new("Gramsh", "AL-GR", "District"),
        new("Has", "AL-HA", "District"),
        new("Kavajë", "AL-KA", "District"),
        new("Kolonjë", "AL-ER", "District"),
        new("Korçë", "AL-06", "County"),
        new("Korçë", "AL-KO", "District"),
        new("Krujë", "AL-KR", "District"),
        new("Kuçovë", "AL-KC", "District"),
        new("Kukës", "AL-KU", "District"),
        new("Kukës", "AL-07", "County"),
        new("Kurbin", "AL-KB", "District"),
        new("Lezhë", "AL-08", "County"),
        new("Lezhë", "AL-LE", "District"),
        new("Librazhd", "AL-LB", "District"),
        new("Lushnjë", "AL-LU", "District"),
        new("Malësi e Madhe", "AL-MM", "District"),
        new("Mallakastër", "AL-MK", "District"),
        new("Mat", "AL-MT", "District"),
        new("Mirditë", "AL-MR", "District"),
        new("Peqin", "AL-PQ", "District"),
        new("Përmet", "AL-PR", "District"),
        new("Pogradec", "AL-PG", "District"),
        new("Pukë", "AL-PU", "District"),
        new("Sarandë", "AL-SR", "District"),
        new("Shkodër", "AL-10", "County"),
        new("Shkodër", "AL-SH", "District"),
        new("Skrapar", "AL-SK", "District"),
        new("Tepelenë", "AL-TE", "District"),
        new("Tirana", "AL-TR", "District"),
        new("Tirana", "AL-11", "County"),
        new("Tropojë", "AL-TP", "District"),
        new("Vlorë", "AL-12", "County"),
        new("Vlorë", "AL-VL", "District"),
    ];
}
