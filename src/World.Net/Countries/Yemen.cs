namespace World.Net.Countries;

internal sealed class Yemen : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Yemen;

    public string Name { get; } = "Yemen";

    public string OfficialName { get; } = "Republic of Yemen";

    public string NativeName => "الجمهورية اليمنية";

    public string Capital { get; } = "Sana’a";

    public int NumericCode { get; } = 887;

    public string ISO2Code { get; } = "YE";

    public string ISO3Code { get; } = "YEM";

    public string[] CallingCode { get; } = ["+967"];

    public IEnumerable<State> States => new[]
    {
        new State("Abyan", "YE-AB", "Governorate"),
        new State("Aden", "YE-AD", "Governorate"),
        new State("Al Bayda", "YE-BD", "Governorate"),
        new State("Al Hudaydah", "YE-HD", "Governorate"),
        new State("Al Jawf", "YE-JW", "Governorate"),
        new State("Al Mahrah", "YE-MR", "Governorate"),
        new State("Al Mahwit", "YE-MW", "Governorate"),
        new State("Amran", "YE-AM", "Governorate"),
        new State("Dhamar", "YE-DH", "Governorate"),
        new State("Hadhramaut", "YE-HU", "Governorate"),
        new State("Hajjah", "YE-HJ", "Governorate"),
        new State("Ibb", "YE-IB", "Governorate"),
        new State("Lahij", "YE-LH", "Governorate"),
        new State("Ma’rib", "YE-MA", "Governorate"),
        new State("Raymah", "YE-RH", "Governorate"),
        new State("Sa’dah", "YE-SD", "Governorate"),
        new State("Sana’a", "YE-SN", "Governorate"),
        new State("Shabwah", "YE-SH", "Governorate"),
        new State("Socotra", "YE-SS", "Governorate"),
        new State("Ta’izz", "YE-TA", "Governorate")
    };
}

