namespace World.Net.Countries;

internal sealed class Mexico : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Mexico;

    public string Name { get; } = "Mexico";

    public string OfficialName { get; } = "United Mexican States";

    public string NativeName => "México";

    public string Capital { get; } = "Mexico City";

    public int NumericCode { get; } = 484;

    public string ISO2Code { get; } = "MX";

    public string ISO3Code { get; } = "MEX";

    public string[] CallingCode { get; } = ["+52"];

    public IEnumerable<State> States => new[]
    {
        new State("Aguascalientes", "MX-AGU", "State"),
        new State("Baja California", "MX-BCN", "State"),
        new State("Baja California Sur", "MX-BCS", "State"),
        new State("Campeche", "MX-CAM", "State"),
        new State("Chiapas", "MX-CHP", "State"),
        new State("Chihuahua", "MX-CHH", "State"),
        new State("Coahuila", "MX-COA", "State"),
        new State("Colima", "MX-COL", "State"),
        new State("Durango", "MX-DUR", "State"),
        new State("Guanajuato", "MX-GUA", "State"),
        new State("Guerrero", "MX-GRO", "State"),
        new State("Hidalgo", "MX-HID", "State"),
        new State("Jalisco", "MX-JAL", "State"),
        new State("Mexico City", "MX-CMX", "Federal District"),
        new State("México", "MX-MEX", "State"),
        new State("Michoacán", "MX-MIC", "State"),
        new State("Morelos", "MX-MOR", "State"),
        new State("Nayarit", "MX-NAY", "State"),
        new State("Nuevo León", "MX-NLE", "State"),
        new State("Oaxaca", "MX-OAX", "State"),
        new State("Puebla", "MX-PUE", "State"),
        new State("Querétaro", "MX-QUE", "State"),
        new State("Quintana Roo", "MX-ROO", "State"),
        new State("San Luis Potosí", "MX-SLP", "State"),
        new State("Sinaloa", "MX-SIN", "State"),
        new State("Sonora", "MX-SON", "State"),
        new State("Tabasco", "MX-TAB", "State"),
        new State("Tamaulipas", "MX-TAM", "State"),
        new State("Tlaxcala", "MX-TLA", "State"),
        new State("Veracruz", "MX-VER", "State"),
        new State("Yucatán", "MX-YUC", "State"),
        new State("Zacatecas", "MX-ZAC", "State")
    };
}

