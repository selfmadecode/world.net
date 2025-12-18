namespace World.Net.Countries;

internal sealed class Qatar : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Qatar;

    //<inheritdoc/>
    public string Name { get; } = "Qatar";

    //<inheritdoc/>
    public string OfficialName { get; } = "State of Qatar";

    //<inheritdoc/>
    public string NativeName => "دولة قطر";

    //<inheritdoc/>
    public string Capital { get; } = "Doha";

    //<inheritdoc/>
    public int NumericCode { get; } = 634;

    //<inheritdoc/>
    public string ISO2Code { get; } = "QA";

    //<inheritdoc/>
    public string ISO3Code { get; } = "QAT";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+974"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Ad Dawhah", "QA-DA", "Municipality"),
        new("Al Khor", "QA-KH", "Municipality"),
        new("Al Rayyan", "QA-RA", "Municipality"),
        new("Al Shamal", "QA-SH", "Municipality"),
        new("Al Wakrah", "QA-WA", "Municipality"),
        new("Al Shahaniya", "QA-SN", "Municipality"),
        new("Umm Salal", "QA-US", "Municipality"),
        new("Al Daayen", "QA-DAA", "Municipality")
    ];
}

