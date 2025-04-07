// Copyright (c) Raphael Anyanwu. All rights reserved.
// Licensed under the MIT License.
namespace World.Net.Countries;

internal sealed class Andorra : ICountry
{
    ///<inheritdoc/>
    public CountryIdentifier Id => CountryIdentifier.Andorra;

    ///<inheritdoc/>
    public string Name => nameof(Andorra);

    ///<inheritdoc/>
    public string OfficialName { get; } = "Principality of Andorra";

    ///<inheritdoc/>
    public string NativeName { get; } = "Andorra";

    ///<inheritdoc/>
    public string Capital { get; } = "Andorra la Vella";

    ///<inheritdoc/>
    public int NumericCode { get; } = 020;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AD";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "AND";

    ///<inheritdoc/>
    public string[] CallingCode { get; } = ["+376"];

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
        new("Canillo", "AD-02", "Parish"),
        new("Encamp", "AD-03", "Parish"),
        new("Ordino", "AD-04", "Parish"),
        new("La Massana", "AD-05", "Parish"),
        new("Andorra la Vella", "AD-07", "Parish"),
        new("Sant Julià de Lòria", "AD-06", "Parish"),
        new("Escaldes-Engordany", "AD-08", "Parish"),
    ];
}
