namespace World.Net.Countries;
internal sealed class Jordan : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Jordan;

    //<inheritdoc/>
    public string Name { get; } = "Jordan";

    //<inheritdoc/>
    public string OfficialName { get; } = "Hashemite Kingdom of Jordan";

    //<inheritdoc/>
    public string NativeName => "الأردن";

    //<inheritdoc/>
    public string Capital { get; } = "Amman";

    //<inheritdoc/>
    public int NumericCode { get; } = 400;

    //<inheritdoc/>
    public string ISO2Code { get; } = "JO";

    //<inheritdoc/>
    public string ISO3Code { get; } = "JOR";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+962"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Ajloun", "JO-AJ", "governorate"),
        new("Amman", "JO-AM", "governorate"),
        new("Aqaba", "JO-AQ", "governorate"),
        new("Balqa", "JO-BA", "governorate"),
        new("Irbid", "JO-IR", "governorate"),
        new("Jerash", "JO-JA", "governorate"),
        new("Karak", "JO-KA", "governorate"),
        new("Ma'an", "JO-MN", "governorate"),
        new("Madaba", "JO-MD", "governorate"),
        new("Mafraq", "JO-MA", "governorate"),
        new("Tafilah", "JO-AT", "governorate"),
        new("Zarqa", "JO-AZ", "governorate"),
    ];
}
