namespace World.Net.Countries;
internal sealed class Japan : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Japan;

    //<inheritdoc/>
    public string Name { get; } = "Japan";

    //<inheritdoc/>
    public string OfficialName { get; } = "Japan";

    //<inheritdoc/>
    public string NativeName => "日本";

    //<inheritdoc/>
    public string Capital { get; } = "Tokyo";

    //<inheritdoc/>
    public int NumericCode { get; } = 392;

    //<inheritdoc/>
    public string ISO2Code { get; } = "JP";

    //<inheritdoc/>
    public string ISO3Code { get; } = "JPN";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+81"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Aichi", "JP-23", "Prefecture"),
        new("Akita", "JP-05", "Prefecture"),
        new("Aomori", "JP-02", "Prefecture"),
        new("Chiba", "JP-12", "Prefecture"),
        new("Ehime", "JP-38", "Prefecture"),
        new("Fukui", "JP-18", "Prefecture"),
        new("Fukuoka", "JP-40", "Prefecture"),
        new("Fukushima", "JP-07", "Prefecture"),
        new("Gifu", "JP-21", "Prefecture"),
        new("Gunma", "JP-10", "Prefecture"),
        new("Hiroshima", "JP-34", "Prefecture"),
        new("Hokkaidō", "JP-01", "Prefecture"),
        new("Hyōgo", "JP-28", "Prefecture"),
        new("Ibaraki", "JP-08", "Prefecture"),
        new("Ishikawa", "JP-17", "Prefecture"),
        new("Iwate", "JP-03", "Prefecture"),
        new("Kagawa", "JP-37", "Prefecture"),
        new("Kagoshima", "JP-46", "Prefecture"),
        new("Kanagawa", "JP-14", "Prefecture"),
        new("Kōchi", "JP-39", "Prefecture"),
        new("Kumamoto", "JP-43", "Prefecture"),
        new("Kyōto", "JP-26", "Prefecture"),
        new("Mie", "JP-24", "Prefecture"),
        new("Miyagi", "JP-04", "Prefecture"),
        new("Miyazaki", "JP-45", "Prefecture"),
        new("Nagano", "JP-20", "Prefecture"),
        new("Nagasaki", "JP-42", "Prefecture"),
        new("Nara", "JP-29", "Prefecture"),
        new("Niigata", "JP-15", "Prefecture"),
        new("Ōita", "JP-44", "Prefecture"),
        new("Okayama", "JP-33", "Prefecture"),
        new("Okinawa", "JP-47", "Prefecture"),
        new("Ōsaka", "JP-27", "Prefecture"),
        new("Saga", "JP-41", "Prefecture"),
        new("Saitama", "JP-11", "Prefecture"),
        new("Shiga", "JP-25", "Prefecture"),
        new("Shimane", "JP-32", "Prefecture"),
        new("Shizuoka", "JP-22", "Prefecture"),
        new("Tochigi", "JP-09", "Prefecture"),
        new("Tokushima", "JP-36", "Prefecture"),
        new("Tokyo", "JP-13", "Prefecture"),
        new("Tottori", "JP-31", "Prefecture"),
        new("Toyama", "JP-16", "Prefecture"),
        new("Wakayama", "JP-30", "Prefecture"),
        new("Yamagata", "JP-06", "Prefecture"),
        new("Yamaguchi", "JP-35", "Prefecture"),
        new("Yamanashi", "JP-19", "Prefecture"),

    ];
}
