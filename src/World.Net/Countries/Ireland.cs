namespace World.Net.Countries;
internal sealed class Ireland : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Ireland;

    //<inheritdoc/>
    public string Name { get; } = "Ireland";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Ireland";

    //<inheritdoc/>
    public string NativeName => "Éire";

    //<inheritdoc/>
    public string Capital { get; } = "Dublin";

    //<inheritdoc/>
    public int NumericCode { get; } = 372;

    //<inheritdoc/>
    public string ISO2Code { get; } = "IE";

    //<inheritdoc/>
    public string ISO3Code { get; } = "IRL";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+353"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Carlow", "IE-CW", "County"),
        new("Cavan", "IE-CN", "County"),
        new("Clare", "IE-CE", "County"),
        new("Connacht", "IE-C", "Province"),
        new("Cork", "IE-CO", "County"),
        new("Donegal", "IE-DL", "County"),
        new("Dublin", "IE-D", "County"),
        new("Galway", "IE-G", "County"),
        new("Kerry", "IE-KY", "County"),
        new("Kildare", "IE-KE", "County"),
        new("Kilkenny", "IE-KK", "County"),
        new("Laois", "IE-LS", "County"),
        new("Leinster", "IE-L", "Province"),
        new("Leitrim", "IE-LM", "County"),
        new("Limerick", "IE-LK", "County"),
        new("Longford", "IE-LD", "County"),
        new("Louth", "IE-LH", "County"),
        new("Mayo", "IE-MO", "County"),
        new("Meath", "IE-MH", "County"),
        new("Monaghan", "IE-MN", "County"),
        new("Munster", "IE-M", "Province"),
        new("Offaly", "IE-OY", "County"),
        new("Roscommon", "IE-RN", "County"),
        new("Sligo", "IE-SO", "County"),
        new("Tipperary", "IE-TA", "County"),
        new("Ulster", "IE-U", "Province"),
        new("Waterford", "IE-WD", "County"),
        new("Westmeath", "IE-WH", "County"),
        new("Wexford", "IE-WX", "County"),
        new("Wicklow", "IE-WW", "County")
    ];

}
