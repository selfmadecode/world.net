using System;
using System.Collections.Generic;
using System.Text;

namespace World.Net.Countries;

internal sealed class Chile : ICountry
{
    public CountryIdentifier Id => CountryIdentifier.Chile;

    public string Name => "Chile";

    public string OfficialName => "Republic of Chile";

    public string NativeName => "República de Chile";

    public string Capital => "Santiago";

    public int NumericCode => 152;

    public string ISO2Code => "CL";

    public string ISO3Code => "CHL";

    public string CallingCode => "+56";

    public IEnumerable<State> States =>
    [
        new("Arica y Parinacota", "AP", "Region"),
        new("Antofagasta", "AN", "Region"),
        new("Atacama", "AT", "Region"),
        new("Aysén del General Carlos Ibáñez del Campo", "AI", "Region"),
        new("Biobío", "BI", "Region"),
        new("Coquimbo", "CO", "Region"),
        new("La Araucanía", "AR", "Region"),
        new("Los Lagos", "LL", "Region"),
        new("Los Ríos", "LR", "Region"),
        new("Magallanes y de la Antártica Chilena", "MA", "Region"),
        new("Libertador General Bernardo O''Higgins", "LI", "Region"),
        new("Maule", "-ML", "Region"),
        new("Ñuble", "NB", "Region"),
        new("Metropolitana de Santiago", "RM", "Region"),
        new("Tarapacá", "TA", "Region"),
        new("Valparaíso", "VS", "Region")
    ];
}
