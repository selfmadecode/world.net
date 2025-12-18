namespace World.Net.Countries;

internal sealed class Peru : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Peru;

    //<inheritdoc/>
    public string Name { get; } = "Peru";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Peru";

    //<inheritdoc/>
    public string NativeName => "República del Perú";

    //<inheritdoc/>
    public string Capital { get; } = "Lima";

    //<inheritdoc/>
    public int NumericCode { get; } = 604;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PE";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PER";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+51"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Amazonas", "PE-AMA", "Region"),
        new("Áncash", "PE-ANC", "Region"),
        new("Apurímac", "PE-APU", "Region"),
        new("Arequipa", "PE-ARE", "Region"),
        new("Ayacucho", "PE-AYA", "Region"),
        new("Cajamarca", "PE-CAJ", "Region"),
        new("Callao", "PE-CAL", "Constitutional Province"),
        new("Cusco", "PE-CUS", "Region"),
        new("Huancavelica", "PE-HUV", "Region"),
        new("Huánuco", "PE-HUC", "Region"),
        new("Ica", "PE-ICA", "Region"),
        new("Junín", "PE-JUN", "Region"),
        new("La Libertad", "PE-LAL", "Region"),
        new("Lambayeque", "PE-LAM", "Region"),
        new("Lima", "PE-LIM", "Region"),
        new("Loreto", "PE-LOR", "Region"),
        new("Madre de Dios", "PE-MDD", "Region"),
        new("Moquegua", "PE-MOQ", "Region"),
        new("Pasco", "PE-PAS", "Region"),
        new("Piura", "PE-PIU", "Region"),
        new("Puno", "PE-PUN", "Region"),
        new("San Martín", "PE-SAM", "Region"),
        new("Tacna", "PE-TAC", "Region"),
        new("Tumbes", "PE-TUM", "Region"),
        new("Ucayali", "PE-UCA", "Region")
    ];
}

