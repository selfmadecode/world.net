namespace World.Net.Countries;

internal sealed class Paraguay : ICountry
{
    //<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Paraguay;

    //<inheritdoc/>
    public string Name { get; } = "Paraguay";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Paraguay";

    //<inheritdoc/>
    public string NativeName => "República del Paraguay";

    //<inheritdoc/>
    public string Capital { get; } = "Asunción";

    //<inheritdoc/>
    public int NumericCode { get; } = 600;

    //<inheritdoc/>
    public string ISO2Code { get; } = "PY";

    //<inheritdoc/>
    public string ISO3Code { get; } = "PRY";

    //<inheritdoc/>
    public string[] CallingCode { get; } = ["+595"];

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Alto Paraguay", "PY-16", "Department"),
        new("Alto Paraná", "PY-10", "Department"),
        new("Amambay", "PY-13", "Department"),
        new("Asunción", "PY-ASU", "Capital District"),
        new("Boquerón", "PY-19", "Department"),
        new("Caaguazú", "PY-5", "Department"),
        new("Caazapá", "PY-6", "Department"),
        new("Canindeyú", "PY-11", "Department"),
        new("Central", "PY-15", "Department"),
        new("Concepción", "PY-1", "Department"),
        new("Cordillera", "PY-3", "Department"),
        new("Guairá", "PY-4", "Department"),
        new("Itapúa", "PY-7", "Department"),
        new("Misiones", "PY-8", "Department"),
        new("Ñeembucú", "PY-12", "Department"),
        new("Paraguarí", "PY-9", "Department"),
        new("Presidente Hayes", "PY-17", "Department"),
        new("San Pedro", "PY-2", "Department")
    ];
}

