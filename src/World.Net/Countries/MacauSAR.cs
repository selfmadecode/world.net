using System;
using System.Collections.Generic;
using System.Text;

namespace World.Net.Countries
{
    internal sealed class MacauSAR : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.MacauSAR;

        ///<inheritdoc/>
        public string Name { get; } = "Macau S.A.R.";

        ///<inheritdoc/>
        public string OfficialName { get; } = "Macao Special Administrative Region of the People's Republic of China";

        ///<inheritdoc/>
        public string NativeName { get; } = "中華人民共和國澳門特別行政區";

        ///<inheritdoc/>
        public string Capital { get; } = "Macau";

        ///<inheritdoc/>
        public int NumericCode { get; } = 446;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "MO";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "MAC";

        ///<inheritdoc/>
        public string[] CallingCode { get; } = ["+853"];

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Macau Peninsula", "MO-PN", "Region"),
            new("Taipa", "MO-TA", "Region"),
            new("Coloane", "MO-CO", "Region"),
            new("Cotai", "MO-CT", "Region")
        ];
    }

}
