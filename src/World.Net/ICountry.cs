// Copyright (c) Raphael Anyanwu. All rights reserved.
// Licensed under the MIT License.

namespace World.Net;

/// <summary>
/// Represents a country with relevant geographical and identification information.
/// </summary>
public interface ICountry
{
    /// <summary>
    /// A unique identifier for the country.
    /// </summary>
    CountryIdentifier Id { get; }

    /// <summary>
    /// The common name of the country.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// The official name of the country (if different from the common name).
    /// </summary>
    string OfficialName { get; }

    /// <summary>
    /// The native name of the country.
    /// </summary>
    string NativeName { get; }

    /// <summary>
    /// The name of the capital city of the country.
    /// </summary>
    string Capital { get; }

    /// <summary>
    /// The ISO 3166-1 numeric code for the country, which is a three-digit numeric code.
    /// </summary>
    int NumericCode { get; }

    /// <summary>
    /// The ISO 3166-1 Alpha-2 code for the country, which is a two-letter code.
    /// </summary>
    string ISO2Code { get; }

    /// <summary>
    /// The ISO 3166-1 Alpha-3 code for the country, which is a three-letter code.
    /// </summary>
    string ISO3Code { get; }

    /// <summary>
    /// The international calling code for the country.
    /// </summary>
    string CallingCode { get; }

    /// <summary>
    /// Gets the collection of states or administrative regions within the country.
    /// </summary>
    IEnumerable<State>  States { get; }
}
