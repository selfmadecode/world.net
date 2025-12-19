namespace World.Net.Countries;

internal sealed class Turkey : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Turkey;

    public string Name { get; } = "Turkey";

    public string OfficialName { get; } = "Republic of Turkey";

    public string NativeName => "Türkiye";

    public string Capital { get; } = "Ankara";

    public int NumericCode { get; } = 792;

    public string ISO2Code { get; } = "TR";

    public string ISO3Code { get; } = "TUR";

    public string[] CallingCode { get; } = ["+90"];

    public IEnumerable<State> States => new[]
    {
        new State("Adana", "TR-01", "Province"),
        new State("Adıyaman", "TR-02", "Province"),
        new State("Afyonkarahisar", "TR-03", "Province"),
        new State("Ağrı", "TR-04", "Province"),
        new State("Amasya", "TR-05", "Province"),
        new State("Ankara", "TR-06", "Province"),
        new State("Antalya", "TR-07", "Province"),
        new State("Artvin", "TR-08", "Province"),
        new State("Aydın", "TR-09", "Province"),
        new State("Balıkesir", "TR-10", "Province"),
        new State("Bilecik", "TR-11", "Province"),
        new State("Bingöl", "TR-12", "Province"),
        new State("Bitlis", "TR-13", "Province"),
        new State("Bolu", "TR-14", "Province"),
        new State("Burdur", "TR-15", "Province"),
        new State("Bursa", "TR-16", "Province"),
        new State("Çanakkale", "TR-17", "Province"),
        new State("Çankırı", "TR-18", "Province"),
        new State("Çorum", "TR-19", "Province"),
        new State("Denizli", "TR-20", "Province"),
        new State("Diyarbakır", "TR-21", "Province"),
        new State("Edirne", "TR-22", "Province"),
        new State("Elazığ", "TR-23", "Province"),
        new State("Erzincan", "TR-24", "Province"),
        new State("Erzurum", "TR-25", "Province"),
        new State("Eskişehir", "TR-26", "Province"),
        new State("Gaziantep", "TR-27", "Province"),
        new State("Giresun", "TR-28", "Province"),
        new State("Gümüşhane", "TR-29", "Province"),
        new State("Hakkari", "TR-30", "Province"),
        new State("Hatay", "TR-31", "Province"),
        new State("Isparta", "TR-32", "Province"),
        new State("Mersin", "TR-33", "Province"),
        new State("İstanbul", "TR-34", "Province"),
        new State("İzmir", "TR-35", "Province"),
        new State("Kars", "TR-36", "Province"),
        new State("Kastamonu", "TR-37", "Province"),
        new State("Kayseri", "TR-38", "Province"),
        new State("Kırklareli", "TR-39", "Province"),
        new State("Kırşehir", "TR-40", "Province"),
        new State("Kocaeli", "TR-41", "Province"),
        new State("Konya", "TR-42", "Province"),
        new State("Kütahya", "TR-43", "Province"),
        new State("Malatya", "TR-44", "Province"),
        new State("Manisa", "TR-45", "Province"),
        new State("Kahramanmaraş", "TR-46", "Province"),
        new State("Mardin", "TR-47", "Province"),
        new State("Muğla", "TR-48", "Province"),
        new State("Muş", "TR-49", "Province"),
        new State("Nevşehir", "TR-50", "Province"),
        new State("Niğde", "TR-51", "Province"),
        new State("Ordu", "TR-52", "Province"),
        new State("Rize", "TR-53", "Province"),
        new State("Sakarya", "TR-54", "Province"),
        new State("Samsun", "TR-55", "Province"),
        new State("Siirt", "TR-56", "Province"),
        new State("Sinop", "TR-57", "Province"),
        new State("Sivas", "TR-58", "Province"),
        new State("Tekirdağ", "TR-59", "Province"),
        new State("Tokat", "TR-60", "Province"),
        new State("Trabzon", "TR-61", "Province"),
        new State("Tunceli", "TR-62", "Province"),
        new State("Şanlıurfa", "TR-63", "Province"),
        new State("Uşak", "TR-64", "Province"),
        new State("Van", "TR-65", "Province"),
        new State("Yozgat", "TR-66", "Province"),
        new State("Zonguldak", "TR-67", "Province"),
        new State("Aksaray", "TR-68", "Province"),
        new State("Bayburt", "TR-69", "Province"),
        new State("Karaman", "TR-70", "Province"),
        new State("Kırıkkale", "TR-71", "Province"),
        new State("Batman", "TR-72", "Province"),
        new State("Şırnak", "TR-73", "Province"),
        new State("Bartın", "TR-74", "Province"),
        new State("Ardahan", "TR-75", "Province"),
        new State("Iğdır", "TR-76", "Province"),
        new State("Yalova", "TR-77", "Province"),
        new State("Karabük", "TR-78", "Province"),
        new State("Kilis", "TR-79", "Province"),
        new State("Osmaniye", "TR-80", "Province"),
        new State("Düzce", "TR-81", "Province")
    };
}

