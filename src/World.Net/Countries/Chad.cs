namespace World.Net.Countries;

internal sealed class Chad : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Chad;

    public string Name => "Chad";

    public string OfficialName => "Republic of Chad";

    public string NativeName => "Tchad";

    public string Capital => "N'Djamena";

    public int NumericCode => 148;

    public string ISO2Code => "TD";

    public string ISO3Code => "TCD";

    public string[] CallingCode => ["+235"];

    public IEnumerable<State> States =>
    [
        new State("Bahr el Gazel", "BG", "Region"),
        new State("Batha", "BA", "Region"),
        new State("Borkou", "BO", "Region"),
        new State("Chari-Baguirmi", "TD-CH", "Region"),
        new State("Ennedi-Est", "EE", "Region"),
        new State("Ennedi-Ouest", "EO", "Region"),
        new State("Guéra", "GE", "Region"),
        new State("Hadjer-Lamis", "HL", "Region"),
        new State("Kanem", "KA", "Region"),
        new State("Lac", "LC", "Region"),
        new State("Logone Occidental", "LO", "Region"),
        new State("Logone Oriental", "LO", "Region"),
        new State("Mandoul", "MD", "Region"),
        new State("Mayo-Kebbi Est", "MK", "Region"),
        new State("Mayo-Kebbi Ouest", "MO", "Region"),
        new State("Moyen-Chari", "MC", "Region"),
        new State("N'Djamena'", "ND", "Region"),
        new State("Ouaddaï", "OD", "Region"),
        new State("Salamat", "SA", "Region"),
        new State("Sila", "SI", "Region"),
        new State("Tandjilé", "TA", "Region"),
        new State("Tibesti", "TI", "Region"),
        new State("Wadi Fira", "WF", "Region")
    ];
}