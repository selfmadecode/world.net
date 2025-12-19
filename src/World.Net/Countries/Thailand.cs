namespace World.Net.Countries;

internal sealed class Thailand : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Thailand;

    public string Name { get; } = "Thailand";

    public string OfficialName { get; } = "Kingdom of Thailand";

    public string NativeName => "ประเทศไทย";

    public string Capital { get; } = "Bangkok";

    public int NumericCode { get; } = 764;

    public string ISO2Code { get; } = "TH";

    public string ISO3Code { get; } = "THA";

    public string[] CallingCode { get; } = ["+66"];

    public IEnumerable<State> States => new[]
    {
        new State("Amnat Charoen", "TH-37", "Province"),
        new State("Ang Thong", "TH-15", "Province"),
        new State("Bangkok", "TH-10", "Province"),
        new State("Bueng Kan", "TH-38", "Province"),
        new State("Buri Ram", "TH-31", "Province"),
        new State("Chachoengsao", "TH-24", "Province"),
        new State("Chai Nat", "TH-18", "Province"),
        new State("Chaiyaphum", "TH-36", "Province"),
        new State("Chanthaburi", "TH-22", "Province"),
        new State("Chiang Mai", "TH-50", "Province"),
        new State("Chiang Rai", "TH-57", "Province"),
        new State("Chonburi", "TH-20", "Province"),
        new State("Chumphon", "TH-86", "Province"),
        new State("Kalasin", "TH-46", "Province"),
        new State("Kamphaeng Phet", "TH-62", "Province"),
        new State("Kanchanaburi", "TH-71", "Province"),
        new State("Khon Kaen", "TH-40", "Province"),
        new State("Krabi", "TH-81", "Province"),
        new State("Lampang", "TH-52", "Province"),
        new State("Lamphun", "TH-51", "Province"),
        new State("Loei", "TH-42", "Province"),
        new State("Lopburi", "TH-16", "Province"),
        new State("Mae Hong Son", "TH-58", "Province"),
        new State("Maha Sarakham", "TH-44", "Province"),
        new State("Mukdahan", "TH-49", "Province"),
        new State("Nakhon Nayok", "TH-26", "Province"),
        new State("Nakhon Pathom", "TH-73", "Province"),
        new State("Nakhon Phanom", "TH-48", "Province"),
        new State("Nakhon Ratchasima", "TH-30", "Province"),
        new State("Nakhon Sawan", "TH-60", "Province"),
        new State("Nakhon Si Thammarat", "TH-80", "Province"),
        new State("Nan", "TH-55", "Province"),
        new State("Narathiwat", "TH-96", "Province"),
        new State("Nong Bua Lamphu", "TH-39", "Province"),
        new State("Nong Khai", "TH-43", "Province"),
        new State("Nonthaburi", "TH-12", "Province"),
        new State("Pathum Thani", "TH-13", "Province"),
        new State("Pattani", "TH-94", "Province"),
        new State("Phang Nga", "TH-82", "Province"),
        new State("Phatthalung", "TH-93", "Province"),
        new State("Phayao", "TH-56", "Province"),
        new State("Phetchabun", "TH-67", "Province"),
        new State("Phetchaburi", "TH-76", "Province"),
        new State("Phichit", "TH-66", "Province"),
        new State("Phitsanulok", "TH-65", "Province"),
        new State("Phra Nakhon Si Ayutthaya", "TH-14", "Province"),
        new State("Phrae", "TH-54", "Province"),
        new State("Phuket", "TH-83", "Province"),
        new State("Prachinburi", "TH-25", "Province"),
        new State("Prachuap Khiri Khan", "TH-77", "Province"),
        new State("Ranong", "TH-85", "Province"),
        new State("Ratchaburi", "TH-70", "Province"),
        new State("Rayong", "TH-21", "Province"),
        new State("Roi Et", "TH-45", "Province"),
        new State("Sa Kaeo", "TH-27", "Province"),
        new State("Sakon Nakhon", "TH-47", "Province"),
        new State("Samut Prakan", "TH-11", "Province"),
        new State("Samut Sakhon", "TH-74", "Province"),
        new State("Samut Songkhram", "TH-75", "Province"),
        new State("Saraburi", "TH-19", "Province"),
        new State("Satun", "TH-91", "Province"),
        new State("Sing Buri", "TH-17", "Province"),
        new State("Si Sa Ket", "TH-33", "Province"),
        new State("Songkhla", "TH-90", "Province"),
        new State("Sukhothai", "TH-64", "Province"),
        new State("Suphan Buri", "TH-72", "Province"),
        new State("Surat Thani", "TH-84", "Province"),
        new State("Tak", "TH-63", "Province"),
        new State("Trang", "TH-92", "Province"),
        new State("Trat", "TH-23", "Province"),
        new State("Ubon Ratchathani", "TH-34", "Province"),
        new State("Udon Thani", "TH-41", "Province"),
        new State("Uthai Thani", "TH-61", "Province"),
        new State("Uttaradit", "TH-53", "Province"),
        new State("Yala", "TH-95", "Province"),
        new State("Yasothon", "TH-35", "Province")
    };
}

