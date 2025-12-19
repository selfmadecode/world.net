namespace World.Net.Countries;

internal sealed class Sudan : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Sudan;

    //<inheritdoc/>
    public string Name { get; } = "Sudan";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of the Sudan";

    //<inheritdoc/>
    public string NativeName => "السودان";

    //<inheritdoc/>
    public string Capital { get; } = "Khartoum";

    //<inheritdoc/>
    public int NumericCode { get; } = 729;

    //<inheritdoc/>
    public string ISO2Code { get; } = "SD";

    //<inheritdoc/>
    public string ISO3Code { get; } = "SDN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+249"];

    //<inheritdoc/>
    public IEnumerable<State> States => new[]
    {
        new State("Khartoum", "SD-KH", "State"),
        new State("North Kordofan", "SD-NK", "State"),
        new State("South Kordofan", "SD-SK", "State"),
        new State("White Nile", "SD-WN", "State"),
        new State("Blue Nile", "SD-BN", "State"),
        new State("North Darfur", "SD-ND", "State"),
        new State("South Darfur", "SD-SD", "State"),
        new State("West Darfur", "SD-WR", "State"),
        new State("East Darfur", "SD-ED", "State"),
        new State("Central Darfur", "SD-CD", "State"),
        new State("Northern", "SD-NO", "State"),
        new State("Red Sea", "SD-RS", "State"),
        new State("River Nile", "SD-RN", "State"),
        new State("Al Jazirah", "SD-GZ", "State"),
        new State("Sennar", "SD-SI", "State"),
        new State("Gezira", "SD-GZ", "State"),
        new State("Kassala", "SD-KA", "State"),
        new State("Al Qadarif", "SD-GQ", "State")
    };
}

