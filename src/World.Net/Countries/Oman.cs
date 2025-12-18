namespace World.Net.Countries;

internal sealed class Oman : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Oman;

    //<inheritdoc/>
    public string Name { get; } = "Oman";

    //<inheritdoc/>
    public string OfficialName { get; } = "Sultanate of Oman";

    //<inheritdoc/>
    public string NativeName => "عُمان";

    //<inheritdoc/>
    public string Capital { get; } = "Muscat";

    //<inheritdoc/>
    public int NumericCode { get; } = 512;

    //<inheritdoc/>
    public string ISO2Code { get; } = "OM";

    //<inheritdoc/>
    public string ISO3Code { get; } = "OMN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+968"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Ad Dakhiliyah", "OM-DA", "Governorate"),
        new("Ad Dhahirah", "OM-ZA", "Governorate"),
        new("Al Batinah North", "OM-BN", "Governorate"),
        new("Al Batinah South", "OM-BS", "Governorate"),
        new("Al Wusta", "OM-WU", "Governorate"),
        new("Ash Sharqiyah North", "OM-SH", "Governorate"),
        new("Ash Sharqiyah South", "OM-SS", "Governorate"),
        new("Dhofar", "OM-ZU", "Governorate"),
        new("Muscat", "OM-MU", "Governorate"),
        new("Musandam", "OM-MN", "Governorate"),
        new("Al Buraimi", "OM-BR", "Governorate")
    ];
}
