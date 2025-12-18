namespace World.Net.Countries;

internal sealed class Portugal : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Portugal;

    //<inheritdoc/>
    public string Name { get; } = "Portugal";

    //<inheritdoc/>
    public string OfficialName { get; } = "Portuguese Republic";

    //<inheritdoc/>
    public string NativeName => "República Portuguesa";

    //<inheritdoc/>
    public string Capital { get; } = "Lisbon";

    //<inheritdoc/>
    public int NumericCode { get; } = 620;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PT";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PRT";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+351"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Aveiro", "PT-01", "District"),
        new("Beja", "PT-02", "District"),
        new("Braga", "PT-03", "District"),
        new("Bragança", "PT-04", "District"),
        new("Castelo Branco", "PT-05", "District"),
        new("Coimbra", "PT-06", "District"),
        new("Évora", "PT-07", "District"),
        new("Faro", "PT-08", "District"),
        new("Guarda", "PT-09", "District"),
        new("Leiria", "PT-10", "District"),
        new("Lisbon", "PT-11", "District"),
        new("Portalegre", "PT-12", "District"),
        new("Porto", "PT-13", "District"),
        new("Santarém", "PT-14", "District"),
        new("Setúbal", "PT-15", "District"),
        new("Viana do Castelo", "PT-16", "District"),
        new("Vila Real", "PT-17", "District"),
        new("Viseu", "PT-18", "District"),
        new("Azores", "PT-20", "Autonomous Region"),
        new("Madeira", "PT-30", "Autonomous Region")
    ];
}
