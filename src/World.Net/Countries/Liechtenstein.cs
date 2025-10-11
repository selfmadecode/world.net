using System;
using System.Collections.Generic;
using System.Text;

namespace World.Net.Countries
{
    internal sealed class Liechtenstein : ICountry
    {
        //<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Liechtenstein;

        //<inheritdoc/>
        public string Name { get; } = "Liechtenstein";

        //<inheritdoc/>
        public string OfficialName { get; } = "Principality of Liechtenstein";

        //<inheritdoc/>
        public string NativeName { get; } = "Fürstentum Liechtenstein";

        //<inheritdoc/>
        public string Capital { get; } = "Vaduz";

        //<inheritdoc/>
        public int NumericCode { get; } = 438;

        //<inheritdoc/>
        public string ISO2Code { get; } = "LI";

        //<inheritdoc/>
        public string ISO3Code { get; } = "LIE";

        //<inheritdoc/>
        public string[] CallingCode { get; } = ["+423"];

        //<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Balzers", "LI-01", "Municipality"),
            new("Eschen", "LI-02", "Municipality"),
            new("Gamprin", "LI-03", "Municipality"),
            new("Mauren", "LI-04", "Municipality"),
            new("Planken", "LI-05", "Municipality"),
            new("Ruggell", "LI-06", "Municipality"),
            new("Schaan", "LI-07", "Municipality"),
            new("Schellenberg", "LI-08", "Municipality"),
            new("Triesen", "LI-09", "Municipality"),
            new("Triesenberg", "LI-10", "Municipality"),
            new("Vaduz", "LI-11", "Municipality")
        ];
    }

}
