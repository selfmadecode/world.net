namespace World.Net.Countries;

internal sealed class Finland : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Finland;

    //<inheritdoc/>
    public string Name { get; } = "Finland";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Finland";

    //<inheritdoc/>
    public string NativeName => "Suomen tasavalta / Republiken Finland";

    //<inheritdoc/>
    public string Capital { get; } = "Helsinki";

    //<inheritdoc/>
    public int NumericCode { get; } = 246;

    //<inheritdoc/>
    public string ISO2Code { get; } = "FI";

    //<inheritdoc/>
    public string ISO3Code { get; } = "FIN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+358"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Åland", "FI-01", "Region"),
        new("Central Finland", "FI-08", "Region"),
        new("Central Ostrobothnia", "FI-07", "Region"),
        new("Etelä-Karjala", "FI-02", "Region"),
        new("Etelä-Pohjanmaa", "FI-03", "Region"),
        new("Etelä-Savo", "FI-04", "Region"),
        new("Kainuu", "FI-05", "Region"),
        new("Kanta-Häme", "FI-06", "Region"),
        new("Keski-Pohjanmaa", "FI-09", "Region"),
        new("Keski-Suomi", "FI-10", "Region"),
        new("Kymenlaakso", "FI-11", "Region"),
        new("Lappi", "FI-12", "Region"),
        new("Pirkanmaa", "FI-13", "Region"),
        new("Pohjanmaa", "FI-14", "Region"),
        new("Pohjois-Karjala", "FI-15", "Region"),
        new("Pohjois-Pohjanmaa", "FI-16", "Region"),
        new("Pohjois-Savo", "FI-17", "Region"),
        new("Päijät-Häme", "FI-18", "Region"),
        new("Satakunta", "FI-19", "Region"),
        new("Uusimaa", "FI-20", "Region"),
        new("Varsinais-Suomi", "FI-21", "Region")
    ];
}
