using System;
using System.Collections.Generic;
using System.Text;

namespace World.Net.Countries
{
    internal sealed class Lithuania : ICountry
    {
        //<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Lithuania;

        //<inheritdoc/>
        public string Name { get; } = "Lithuania";

        //<inheritdoc/>
        public string OfficialName { get; } = "Republic of Lithuania";

        //<inheritdoc/>
        public string NativeName { get; } = "Lietuvos Respublika";

        //<inheritdoc/>
        public string Capital { get; } = "Vilnius";

        //<inheritdoc/>
        public int NumericCode { get; } = 440;

        //<inheritdoc/>
        public string ISO2Code { get; } = "LT";

        //<inheritdoc/>
        public string ISO3Code { get; } = "LTU";

        //<inheritdoc/>
        public string[] CallingCode { get; } = ["+370"];

        //<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Alytus County", "LT-AL", "County"),
            new("Kaunas County", "LT-KU", "County"),
            new("Klaipėda County", "LT-KL", "County"),
            new("Marijampolė County", "LT-MR", "County"),
            new("Panevėžys County", "LT-PN", "County"),
            new("Šiauliai County", "LT-SA", "County"),
            new("Tauragė County", "LT-TA", "County"),
            new("Telšiai County", "LT-TE", "County"),
            new("Utena County", "LT-UT", "County"),
            new("Vilnius County", "LT-VL", "County")
        ];
    }
}
