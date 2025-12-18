namespace World.Net.Countries;

internal sealed class Hungary : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Hungary;

    //<inheritdoc/>
    public string Name { get; } = "Hungary";

    //<inheritdoc/>
    public string OfficialName { get; } = "Hungary";

    //<inheritdoc/>
    public string NativeName => "Magyarország";

    //<inheritdoc/>
    public string Capital { get; } = "Budapest";

    //<inheritdoc/>
    public int NumericCode { get; } = 348;

    //<inheritdoc/>
    public string ISO2Code { get; } = "HU";

    //<inheritdoc/>
    public string ISO3Code { get; } = "HUN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+36"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Budapest", "HU-BU", "Capital City"),
        new("Bács-Kiskun", "HU-BK", "County"),
        new("Baranya", "HU-BA", "County"),
        new("Békés", "HU-BE", "County"),
        new("Borsod-Abaúj-Zemplén", "HU-BO", "County"),
        new("Csongrád-Csanád", "HU-CS", "County"),
        new("Fejér", "HU-FE", "County"),
        new("Győr-Moson-Sopron", "HU-GS", "County"),
        new("Hajdú-Bihar", "HU-HB", "County"),
        new("Heves", "HU-HE", "County"),
        new("Jász-Nagykun-Szolnok", "HU-JN", "County"),
        new("Komárom-Esztergom", "HU-KM", "County"),
        new("Nógrád", "HU-NO", "County"),
        new("Pest", "HU-PE", "County"),
        new("Somogy", "HU-SO", "County"),
        new("Szabolcs-Szatmár-Bereg", "HU-SZ", "County"),
        new("Tolna", "HU-TO", "County"),
        new("Vas", "HU-VA", "County"),
        new("Veszprém", "HU-VE", "County"),
        new("Zala", "HU-ZA", "County")
    ];
}
