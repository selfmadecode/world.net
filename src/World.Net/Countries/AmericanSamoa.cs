// Copyright (c) Raphael Anyanwu. All rights reserved.
// Licensed under the MIT License.

namespace World.Net.Countries;

internal sealed class AmericanSamoa : ICountry, ICountryRegistry
{
    ///<inheritdoc/>
    public int Id => CountryIdentifier.AmericanSamoa;

    ///<inheritdoc/>
    public string Name => "American Samoa";

    ///<inheritdoc/>
    public string OfficialName { get; } = "American Samoa";

    ///<inheritdoc/>
    public string NativeName { get; } = "American Samoa";

    ///<inheritdoc/>
    public string Capital { get; } = "Pago Pago";

    ///<inheritdoc/>
    public int NumericCode { get; } = 016;

    ///<inheritdoc/>
    public string ISO2Code { get; } = "AS";

    ///<inheritdoc/>
    public string ISO3Code { get; } = "ASM";

    ///<inheritdoc/>
    public string CallingCode { get; } = "+1";

    ///<inheritdoc/>
    public IEnumerable<State> States { get; } =
    [
    ];

    public Dictionary<int, ICountry> GetCountry()
    {
        return new Dictionary<int, ICountry>
        {
            { CountryIdentifier.AmericanSamoa, new AmericanSamoa() }
        };
    }
}
