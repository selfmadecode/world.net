namespace World.Net.Countries;

internal sealed class Switzerland : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Switzerland;

    //<inheritdoc/>
    public string Name { get; } = "Switzerland";

    //<inheritdoc/>
    public string OfficialName { get; } = "Swiss Confederation";

    //<inheritdoc/>
    public string NativeName => "Schweiz / Suisse / Svizzera / Svizra";

    //<inheritdoc/>
    public string Capital { get; } = "Bern";

    //<inheritdoc/>
    public int NumericCode { get; } = 756;

    //<inheritdoc/>
    public string ISO2Code { get; } = "CH";

    //<inheritdoc/>
    public string ISO3Code { get; } = "CHE";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+41"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Aargau", "CH-AG", "Canton"),
        new State("Appenzell Ausserrhoden", "CH-AR", "Canton"),
        new State("Appenzell Innerrhoden", "CH-AI", "Canton"),
        new State("Basel-Landschaft", "CH-BL", "Canton"),
        new State("Basel-Stadt", "CH-BS", "Canton"),
        new State("Bern", "CH-BE", "Canton"),
        new State("Fribourg", "CH-FR", "Canton"),
        new State("Geneva", "CH-GE", "Canton"),
        new State("Glarus", "CH-GL", "Canton"),
        new State("Graubünden", "CH-GR", "Canton"),
        new State("Jura", "CH-JU", "Canton"),
        new State("Lucerne", "CH-LU", "Canton"),
        new State("Neuchâtel", "CH-NE", "Canton"),
        new State("Nidwalden", "CH-NW", "Canton"),
        new State("Obwalden", "CH-OW", "Canton"),
        new State("St. Gallen", "CH-SG", "Canton"),
        new State("Schaffhausen", "CH-SH", "Canton"),
        new State("Solothurn", "CH-SO", "Canton"),
        new State("Schwyz", "CH-SZ", "Canton"),
        new State("Thurgau", "CH-TG", "Canton"),
        new State("Ticino", "CH-TI", "Canton"),
        new State("Uri", "CH-UR", "Canton"),
        new State("Valais", "CH-VS", "Canton"),
        new State("Vaud", "CH-VD", "Canton"),
        new State("Zug", "CH-ZG", "Canton"),
        new State("Zurich", "CH-ZH", "Canton")
    };
}
