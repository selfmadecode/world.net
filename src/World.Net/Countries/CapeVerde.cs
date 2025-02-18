namespace World.Net.Countries;

internal sealed class CapeVerde : ICountry
{
    //<inheritdoc/>
    public int Id => CountryIdentifier.CapeVerde;

    //<inheritdoc/>
    public string Name { get; } = "Cape Verde";

    //<inheritdoc/>
    public string OfficialName { get; } = "Republic of Cabo Verde";

    //<inheritdoc/>
    public string NativeName => "Cabo Verde";

    //<inheritdoc/>
    public string Capital { get; } = "Praia";

    //<inheritdoc/>
    public int NumericCode { get; } = 132;

    //<inheritdoc/>
    public string ISO2Code { get; } = "CV";

    //<inheritdoc/>
    public string ISO3Code { get; } = "CPV";

    //<inheritdoc/>
    public string CallingCode { get; } = "+238";

    //<inheritdoc/>
    public IEnumerable<State> States =>
    [
        new("Boa Vista", "BV", "Municipality"),
        new("Brava", "BR", "Municipality"),
        new("Calheta de São Miguel", "CS", "Municipality"),
        new("Maio", "MA", "Municipality"),
        new("Mosteiros", "MO", "Municipality"),
        new("Paul", "PA", "Municipality"),
        new("Porto Novo", "PN", "Municipality"),
        new("Praia", "PR", "Municipality"),
        new("Ribeira Brava", "RB", "Municipality"),
        new("Ribeira Grande", "RG", "Municipality"),
        new("Ribeira Grande de Santiago", "RS", "Municipality"),
        new("Sal", "SA", "Municipality"),
        new("Santa Catarina", "SC", "Municipality"),
        new("Santa Catarina do Fogo", "SF", "Municipality"),
        new("Santa Cruz", "SZ", "Municipality"),
        new("São Domingos", "SD", "Municipality"),
        new("São Filipe", "SF", "Municipality"),
        new("São Lourenço dos Órgãos", "SL", "Municipality"),
        new("São Salvador do Mundo", "SM", "Municipality"),
        new("São Vicente", "SV", "Municipality"),
        new("Tarrafal", "TA", "Municipality"),
        new("Tarrafal de São Nicolau", "TS", "Municipality")
    ];
}
