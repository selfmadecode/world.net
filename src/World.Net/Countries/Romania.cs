namespace World.Net.Countries;

internal sealed class Romania : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Romania;

    //<inheritdoc/>
    public string Name { get; } = "Romania";

    //<inheritdoc/>
    public string OfficialName { get; } = "Romania";

    //<inheritdoc/>
    public string NativeName => "România";

    //<inheritdoc/>
    public string Capital { get; } = "Bucharest";

    //<inheritdoc/>
    public int NumericCode { get; } = 642;

    //<inheritdoc/>
    public string ISO2Code { get; } = "RO";

    //<inheritdoc/>
    public string ISO3Code { get; } = "ROU";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+40"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Alba", "RO-AB", "County"),
        new("Arad", "RO-AR", "County"),
        new("Argeș", "RO-AG", "County"),
        new("Bacău", "RO-BC", "County"),
        new("Bihor", "RO-BH", "County"),
        new("Bistrița-Năsăud", "RO-BN", "County"),
        new("Botoșani", "RO-BT", "County"),
        new("Brașov", "RO-BV", "County"),
        new("Brăila", "RO-BR", "County"),
        new("Buzău", "RO-BZ", "County"),
        new("Caraș-Severin", "RO-CS", "County"),
        new("Călărași", "RO-CL", "County"),
        new("Cluj", "RO-CJ", "County"),
        new("Constanța", "RO-CT", "County"),
        new("Covasna", "RO-CV", "County"),
        new("Dâmbovița", "RO-DB", "County"),
        new("Dolj", "RO-DJ", "County"),
        new("Galați", "RO-GL", "County"),
        new("Giurgiu", "RO-GR", "County"),
        new("Gorj", "RO-GJ", "County"),
        new("Harghita", "RO-HR", "County"),
        new("Hunedoara", "RO-HD", "County"),
        new("Ialomița", "RO-IL", "County"),
        new("Iași", "RO-IS", "County"),
        new("Ilfov", "RO-IF", "County"),
        new("Maramureș", "RO-MM", "County"),
        new("Mehedinți", "RO-MH", "County"),
        new("Mureș", "RO-MS", "County"),
        new("Neamț", "RO-NT", "County"),
        new("Olt", "RO-OT", "County"),
        new("Prahova", "RO-PH", "County"),
        new("Satu Mare", "RO-SM", "County"),
        new("Sălaj", "RO-SJ", "County"),
        new("Sibiu", "RO-SB", "County"),
        new("Suceava", "RO-SV", "County"),
        new("Teleorman", "RO-TR", "County"),
        new("Timiș", "RO-TM", "County"),
        new("Tulcea", "RO-TL", "County"),
        new("Vaslui", "RO-VS", "County"),
        new("Vâlcea", "RO-VL", "County"),
        new("Vrancea", "RO-VN", "County"),
        new("Bucharest", "RO-B", "Municipality")
    ];
}

