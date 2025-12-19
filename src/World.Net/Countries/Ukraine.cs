namespace World.Net.Countries;

internal sealed class Ukraine : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Ukraine;

    public string Name { get; } = "Ukraine";

    public string OfficialName { get; } = "Ukraine";

    public string NativeName => "Україна";

    public string Capital { get; } = "Kyiv";

    public int NumericCode { get; } = 804;

    public string ISO2Code { get; } = "UA";

    public string ISO3Code { get; } = "UKR";

    public string[] CallingCode { get; } = ["+380"];

    public IEnumerable<State> States => new[]
    {
        new State("Cherkasy", "UA-CK", "Oblast"),
        new State("Chernihiv", "UA-CH", "Oblast"),
        new State("Chernivtsi", "UA-CV", "Oblast"),
        new State("Dnipropetrovsk", "UA-DP", "Oblast"),
        new State("Donetsk", "UA-DO", "Oblast"),
        new State("Ivano-Frankivsk", "UA-IF", "Oblast"),
        new State("Kharkiv", "UA-KH", "Oblast"),
        new State("Kherson", "UA-KH", "Oblast"),
        new State("Khmelnytskyi", "UA-KM", "Oblast"),
        new State("Kirovohrad", "UA-KR", "Oblast"),
        new State("Kyiv", "UA-KY", "City"),
        new State("Kyiv Oblast", "UA-KY", "Oblast"),
        new State("Luhansk", "UA-LU", "Oblast"),
        new State("Lviv", "UA-LV", "Oblast"),
        new State("Mykolaiv", "UA-MK", "Oblast"),
        new State("Odessa", "UA-OD", "Oblast"),
        new State("Poltava", "UA-PL", "Oblast"),
        new State("Rivne", "UA-RV", "Oblast"),
        new State("Sevastopol", "UA-SE", "City"),
        new State("Sumy", "UA-SU", "Oblast"),
        new State("Ternopil", "UA-TE", "Oblast"),
        new State("Vinnytsia", "UA-VI", "Oblast"),
        new State("Volyn", "UA-VO", "Oblast"),
        new State("Zakarpattia", "UA-ZA", "Oblast"),
        new State("Zaporizhzhia", "UA-ZP", "Oblast"),
        new State("Zhytomyr", "UA-ZH", "Oblast"),
        new State("Autonomous Republic of Crimea", "UA-CR", "Autonomous Republic")
    };
}

