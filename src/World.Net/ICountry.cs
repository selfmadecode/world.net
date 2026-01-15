// Copyright (c) Raphael Anyanwu. All rights reserved.
// Licensed under the MIT License.

using World.Net.Types;

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
    string[] CallingCode { get; }

    /// <summary>
    /// Gets the collection of states or administrative regions within the country.
    /// </summary>
    IEnumerable<State>  States { get; }

    /// <summary>
    /// The primary currency used by the country.
    /// </summary>
    Currency Currency => CurrencyProvider.GetCurrency(ISO2Code, Name);

    /// <summary>
    /// One or more time zone identifiers applicable to the country (IANA / Windows ids).
    /// </summary>
    IReadOnlyCollection<string> TimeZones => TimeZoneProvider.GetTimeZones(ISO2Code);

    /// <summary>
    /// Flag information for the country including ISO code, emoji and optional asset URL.
    /// </summary>
    CountryFlag Flag => FlagProvider.GetFlag(ISO2Code);
}
