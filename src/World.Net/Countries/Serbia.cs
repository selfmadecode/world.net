namespace World.Net.Countries;

internal sealed class Serbia : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Serbia;

    //<inheritdoc/>
    public string Name { get; } = "Serbia";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Serbia";

    //<inheritdoc/>
    public string NativeName => "Srbija";

    //<inheritdoc/>
    public string Capital { get; } = "Belgrade";

    //<inheritdoc/>
    public int NumericCode { get; } = 688;

    //<inheritdoc/>
    public string ISO2Code { get; } = "RS";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SRB";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+381"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Belgrade", "RS-00", "District"),
        new("Bor", "RS-14", "District"),
        new("Braničevo", "RS-11", "District"),
        new("Central Banat", "RS-02", "District"),
        new("Jablanica", "RS-23", "District"),
        new("Kolubara", "RS-09", "District"),
        new("Mačva", "RS-08", "District"),
        new("Moravica", "RS-17", "District"),
        new("Nišava", "RS-20", "District"),
        new("North Bačka", "RS-01", "District"),
        new("North Banat", "RS-03", "District"),
        new("Pčinja", "RS-24", "District"),
        new("Pirot", "RS-22", "District"),
        new("Pomoravlje", "RS-13", "District"),
        new("Rasina", "RS-19", "District"),
        new("Raška", "RS-18", "District"),
        new("South Bačka", "RS-06", "District"),
        new("South Banat", "RS-04", "District"),
        new("Srem", "RS-07", "District"),
        new("Šumadija", "RS-12", "District"),
        new("Toplica", "RS-21", "District"),
        new("West Bačka", "RS-05", "District"),
        new("Zaječar", "RS-15", "District"),
        new("Zlatibor", "RS-16", "District")
    ];
}

