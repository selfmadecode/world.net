namespace World.Net.Countries;

internal sealed class Uruguay : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Uruguay;

    public string Name { get; } = "Uruguay";

    public string OfficialName { get; } = "Oriental Republic of Uruguay";

    public string NativeName => "República Oriental del Uruguay";

    public string Capital { get; } = "Montevideo";

    public int NumericCode { get; } = 858;

    public string ISO2Code { get; } = "UY";

    public string ISO3Code { get; } = "URY";

    public string[] CallingCode { get; } = ["+598"];

    public IEnumerable<State> States => new[]
    {
        new State("Artigas", "UY-AR", "Department"),
        new State("Canelones", "UY-CA", "Department"),
        new State("Cerro Largo", "UY-CL", "Department"),
        new State("Colonia", "UY-CO", "Department"),
        new State("Durazno", "UY-DU", "Department"),
        new State("Flores", "UY-FS", "Department"),
        new State("Florida", "UY-FD", "Department"),
        new State("Lavalleja", "UY-LA", "Department"),
        new State("Maldonado", "UY-MA", "Department"),
        new State("Montevideo", "UY-MO", "Department"),
        new State("Paysandú", "UY-PA", "Department"),
        new State("Río Negro", "UY-RN", "Department"),
        new State("Rivera", "UY-RV", "Department"),
        new State("Rocha", "UY-RO", "Department"),
        new State("Salto", "UY-SA", "Department"),
        new State("San José", "UY-SJ", "Department"),
        new State("Soriano", "UY-SO", "Department"),
        new State("Tacuarembó", "UY-TA", "Department"),
        new State("Treinta y Tres", "UY-TT", "Department")
    };
}

