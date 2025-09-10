namespace World.Net.Countries;
internal sealed class Iraq : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Iraq;

    //<inheritdoc/>
    public string Name { get; } = "Iraq";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Iraq";

    //<inheritdoc/>
    public string NativeName => "العراق";

    //<inheritdoc/>
    public string Capital { get; } = "Baghdad";

    //<inheritdoc/>
    public int NumericCode { get; } = 368;

    //<inheritdoc/>
    public string ISO2Code { get; } = "IQ";

    //<inheritdoc/>
    public string ISO3Code { get; } = "IRQ";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+964"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Al Anbar", "IQ-AN", "Governorate"),
        new("Al Muthanna", "IQ-MU", "Governorate"),
        new("Al-Qādisiyyah", "IQ-QA", "Governorate"),
        new("Babylon", "IQ-BB", "Governorate"),
        new("Baghdad", "IQ-BG", "Governorate"),
        new("Basra", "IQ-BA", "Governorate"),
        new("Dhi Qar", "IQ-DQ", "Governorate"),
        new("Diyala", "IQ-DI", "Governorate"),
        new("Dohuk", "IQ-DA", "Governorate"),
        new("Erbil", "IQ-AR", "Governorate"),
        new("Karbala", "IQ-KA", "Governorate"),
        new("Kirkuk", "IQ-KI", "Governorate"),
        new("Maysan", "IQ-MA", "Governorate"),
        new("Najaf", "IQ-NA", "Governorate"),
        new("Nineveh", "IQ-NI", "Governorate"),
        new("Saladin", "IQ-SD", "Governorate"),
        new("Sulaymaniyah", "IQ-SU", "Governorate"),
        new("Wasit", "IQ-WA", "Governorate")
    ];
}
