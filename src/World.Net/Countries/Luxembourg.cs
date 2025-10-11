using System;
using System.Collections.Generic;
using System.Text;

namespace World.Net.Countries
{
    internal sealed class Luxembourg : ICountry
    {
        //<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Luxembourg;

        //<inheritdoc/>
        public string Name { get; } = "Luxembourg";

        //<inheritdoc/>
        public string OfficialName { get; } = "Grand Duchy of Luxembourg";

        //<inheritdoc/>
        public string NativeName { get; } = "Groussherzogtum Lëtzebuerg";

        //<inheritdoc/>
        public string Capital { get; } = "Luxembourg City";

        //<inheritdoc/>
        public int NumericCode { get; } = 442;

        //<inheritdoc/>
        public string ISO2Code { get; } = "LU";

        //<inheritdoc/>
        public string ISO3Code { get; } = "LUX";

        //<inheritdoc/>
        public string[] CallingCode { get; } = ["+352"];

        //<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Capellen", "LU-CA", "Canton"),
            new("Clervaux", "LU-CL", "Canton"),
            new("Diekirch", "LU-DI", "Canton"),
            new("Echternach", "LU-EC", "Canton"),
            new("Esch-sur-Alzette", "LU-ES", "Canton"),
            new("Grevenmacher", "LU-GR", "Canton"),
            new("Luxembourg", "LU-LU", "Canton"),
            new("Mersch", "LU-ME", "Canton"),
            new("Redange", "LU-RD", "Canton"),
            new("Remich", "LU-RM", "Canton"),
            new("Vianden", "LU-VD", "Canton"),
            new("Wiltz", "LU-WI", "Canton")
        ];
    }
}
