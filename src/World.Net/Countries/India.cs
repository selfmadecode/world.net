namespace World.Net.Countries;

internal sealed class India : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.India;

    //<inheritdoc/>
    public string Name { get; } = "India";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of India";

    //<inheritdoc/>
    public string NativeName => "भारत";

    //<inheritdoc/>
    public string Capital { get; } = "New Delhi";

    //<inheritdoc/>
    public int NumericCode { get; } = 356;

    //<inheritdoc/>
    public string ISO2Code { get; } = "IN";

    //<inheritdoc/>
    public string ISO3Code { get; } = "IND";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+91"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Andhra Pradesh", "IN-AP", "State"),
        new("Arunachal Pradesh", "IN-AR", "State"),
        new("Assam", "IN-AS", "State"),
        new("Bihar", "IN-BR", "State"),
        new("Chhattisgarh", "IN-CT", "State"),
        new("Goa", "IN-GA", "State"),
        new("Gujarat", "IN-GJ", "State"),
        new("Haryana", "IN-HR", "State"),
        new("Himachal Pradesh", "IN-HP", "State"),
        new("Jharkhand", "IN-JH", "State"),
        new("Karnataka", "IN-KA", "State"),
        new("Kerala", "IN-KL", "State"),
        new("Madhya Pradesh", "IN-MP", "State"),
        new("Maharashtra", "IN-MH", "State"),
        new("Manipur", "IN-MN", "State"),
        new("Meghalaya", "IN-ML", "State"),
        new("Mizoram", "IN-MZ", "State"),
        new("Nagaland", "IN-NL", "State"),
        new("Odisha", "IN-OR", "State"),
        new("Punjab", "IN-PB", "State"),
        new("Rajasthan", "IN-RJ", "State"),
        new("Sikkim", "IN-SK", "State"),
        new("Tamil Nadu", "IN-TN", "State"),
        new("Telangana", "IN-TG", "State"),
        new("Tripura", "IN-TR", "State"),
        new("Uttar Pradesh", "IN-UP", "State"),
        new("Uttarakhand", "IN-UT", "State"),
        new("West Bengal", "IN-WB", "State"),
        new("Andaman and Nicobar Islands", "IN-AN", "Union Territory"),
        new("Chandigarh", "IN-CH", "Union Territory"),
        new("Dadra and Nagar Haveli and Daman and Diu", "IN-DN", "Union Territory"),
        new("Delhi", "IN-DL", "Union Territory"),
        new("Jammu and Kashmir", "IN-JK", "Union Territory"),
        new("Ladakh", "IN-LA", "Union Territory"),
        new("Lakshadweep", "IN-LD", "Union Territory"),
        new("Puducherry", "IN-PY", "Union Territory")
    ];
}
