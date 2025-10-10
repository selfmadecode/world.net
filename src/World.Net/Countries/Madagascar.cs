using System;
using System.Collections.Generic;
using System.Text;

namespace World.Net.Countries
{
    internal sealed class Madagascar : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.Madagascar;

        ///<inheritdoc/>
        public string Name { get; } = "Madagascar";

        ///<inheritdoc/>
        public string OfficialName { get; } = "Republic of Madagascar";

        ///<inheritdoc/>
        public string NativeName { get; } = "Repoblikan’i Madagasikara";

        ///<inheritdoc/>
        public string Capital { get; } = "Antananarivo";

        ///<inheritdoc/>
        public int NumericCode { get; } = 450;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "MG";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "MDG";

        ///<inheritdoc/>
        public string[] CallingCode { get; } = ["+261"];

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Antananarivo", "MG-T", "Province"),
            new("Antsiranana", "MG-D", "Province"),
            new("Fianarantsoa", "MG-F", "Province"),
            new("Mahajanga", "MG-M", "Province"),
            new("Toamasina", "MG-A", "Province"),
            new("Toliara", "MG-U", "Province")
        ];
    }
}
