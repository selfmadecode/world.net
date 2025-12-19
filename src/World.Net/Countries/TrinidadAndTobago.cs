namespace World.Net.Countries;

internal sealed class TrinidadAndTobago : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.TrinidadAndTobago;

    public string Name { get; } = "Trinidad and Tobago";

    public string OfficialName { get; } = "Republic of Trinidad and Tobago";

    public string NativeName => "Trinidad and Tobago";

    public string Capital { get; } = "Port of Spain";

    public int NumericCode { get; } = 780;

    public string ISO2Code { get; } = "TT";

    public string ISO3Code { get; } = "TTO";

    public string[] CallingCode { get; } = ["+1-868"];

    public IEnumerable<State> States => new[]
    {
        new State("Arima", "TT-ARI", "City"),
        new State("Chaguanas", "TT-CHA", "City"),
        new State("Couva-Tabaquite-Talparo", "TT-CTT", "Region"),
        new State("Diego Martin", "TT-DMN", "Region"),
        new State("Mayaro-Rio Claro", "TT-MRC", "Region"),
        new State("Penal-Debe", "TT-PDE", "Region"),
        new State("Point Fortin", "TT-PFT", "Region"),
        new State("Port of Spain", "TT-POS", "City"),
        new State("San Fernando", "TT-SFO", "City"),
        new State("San Juan-Laventille", "TT-SJL", "Region"),
        new State("Sangre Grande", "TT-SGE", "Region"),
        new State("Siparia", "TT-SIP", "Region"),
        new State("Tunapuna-Piarco", "TT-TUP", "Region"),
        new State("Tobago", "TT-TOB", "Region")
    };
}
