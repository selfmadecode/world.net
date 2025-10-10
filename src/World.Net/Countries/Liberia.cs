using System;
using System.Collections.Generic;
using System.Text;

namespace World.Net.Countries
{
    internal sealed class Liberia : ICountry
    {

        //<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Liberia;

        //<inheritdoc/>
        public string Name { get; } = "Liberia";

        //<inheritdoc/>
        public string OfficialName { get; } = "Republic of Liberia";

        //<inheritdoc/>
        public string NativeName { get; } = "Republic of Liberia";

        //<inheritdoc/>
        public string Capital { get; } = "Monrovia";

        //<inheritdoc/>
        public int NumericCode { get; } = 430;

        //<inheritdoc/>
        public string ISO2Code { get; } = "LR";

        //<inheritdoc/>
        public string ISO3Code { get; } = "LBR";

        //<inheritdoc/>
        public string[] CallingCode { get; } = ["+231"];

        //<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Bomi", "LR-BM", "County"),
            new("Bong", "LR-BG", "County"),
            new("Gbarpolu", "LR-GP", "County"),
            new("Grand Bassa", "LR-GB", "County"),
            new("Grand Cape Mount", "LR-CM", "County"),
            new("Grand Gedeh", "LR-GG", "County"),
            new("Grand Kru", "LR-GK", "County"),
            new("Lofa", "LR-LO", "County"),
            new("Margibi", "LR-MG", "County"),
            new("Maryland", "LR-MY", "County"),
            new("Montserrado", "LR-MO", "County"),
            new("Nimba", "LR-NI", "County"),
            new("River Cess", "LR-RI", "County"),
            new("River Gee", "LR-RG", "County"),
            new("Sinoe", "LR-SI", "County")
        ];
    }

}
