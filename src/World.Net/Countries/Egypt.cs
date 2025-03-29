namespace World.Net.Countries;

internal sealed class Egypt : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Egypt;

    //<inheritdoc/>
    public string Name { get; } = "Egypt";

    //<inheritdoc/>
    public string OfficialName { get; } = "Arab Republic of Egypt";

    //<inheritdoc/>
    public string NativeName => "جمهورية مصر العربية";

    //<inheritdoc/>
    public string Capital { get; } = "Cairo";

    //<inheritdoc/>
    public int NumericCode { get; } = 818;

    //<inheritdoc/>
    public string ISO2Code { get; } = "EG";

    //<inheritdoc/>
    public string ISO3Code { get; } = "EGY";

    //<inheritdoc/>
    public string CallingCode { get; } = "+20";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Alexandria", "EG-ALX", "Governorate"),
        new("Aswan", "EG-ASN", "Governorate"),
        new("Asyut", "EG-AST", "Governorate"),
        new("Beheira", "EG-BH", "Governorate"),
        new("Beni Suef", "EG-BNS", "Governorate"),
        new("Cairo", "EG-C", "Governorate"),
        new("Dakahlia", "EG-DK", "Governorate"),
        new("Damietta", "EG-DT", "Governorate"),
        new("Faiyum", "EG-FYM", "Governorate"),
        new("Gharbia", "EG-GH", "Governorate"),
        new("Giza", "EG-GZ", "Governorate"),
        new("Ismailia", "EG-IS", "Governorate"),
        new("Kafr El Sheikh", "EG-KFS", "Governorate"),
        new("Luxor", "EG-LX", "Governorate"),
        new("Matrouh", "EG-MT", "Governorate"),
        new("Minya", "EG-MN", "Governorate"),
        new("Monufia", "EG-MNF", "Governorate"),
        new("New Valley", "EG-WAD", "Governorate"),
        new("North Sinai", "EG-SIN", "Governorate"),
        new("Port Said", "EG-PTS", "Governorate"),
        new("Qalyubia", "EG-KB", "Governorate"),
        new("Qena", "EG-QN", "Governorate"),
        new("Red Sea", "EG-BA", "Governorate"),
        new("Sharqia", "EG-SHR", "Governorate"),
        new("Sohag", "EG-SHG", "Governorate"),
        new("South Sinai", "EG-JS", "Governorate"),
        new("Suez", "EG-SUZ", "Governorate")
    ];
}
