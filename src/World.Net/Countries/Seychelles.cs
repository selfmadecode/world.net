namespace World.Net.Countries;

internal sealed class Seychelles : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Seychelles;

    //<inheritdoc/>
    public string Name { get; } = "Seychelles";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Seychelles";

    //<inheritdoc/>
    public string NativeName => "Sesel";

    //<inheritdoc/>
    public string Capital { get; } = "Victoria";

    //<inheritdoc/>
    public int NumericCode { get; } = 690;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SC";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SYC";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+248"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Anse aux Pins", "SC-01", "District"),
        new("Anse Boileau", "SC-02", "District"),
        new("Anse Etoile", "SC-03", "District"),
        new("Anse Royale", "SC-05", "District"),
        new("Au Cap", "SC-04", "District"),
        new("Baie Lazare", "SC-06", "District"),
        new("Baie Sainte Anne", "SC-07", "District"),
        new("Beau Vallon", "SC-08", "District"),
        new("Bel Air", "SC-09", "District"),
        new("Bel Ombre", "SC-10", "District"),
        new("Cascade", "SC-11", "District"),
        new("Glacis", "SC-12", "District"),
        new("Grand'Anse Mahé", "SC-13", "District"),
        new("Grand'Anse Praslin", "SC-14", "District"),
        new("La Digue", "SC-15", "District"),
        new("La Rivière Anglaise", "SC-16", "District"),
        new("Les Mamelles", "SC-24", "District"),
        new("Mont Buxton", "SC-17", "District"),
        new("Mont Fleuri", "SC-18", "District"),
        new("Plaisance", "SC-19", "District"),
        new("Pointe La Rue", "SC-20", "District"),
        new("Port Glaud", "SC-21", "District"),
        new("Roche Caiman", "SC-25", "District"),
        new("Saint Louis", "SC-22", "District"),
        new("Takamaka", "SC-23", "District")
    ];
}

