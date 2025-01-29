// Copyright (c) Raphael Anyanwu. All rights reserved.
// Licensed under the MIT License.

namespace World.Net;

/// <summary>
/// Represents a state, province, or region with relevant details such as its name, ISO code, and type.
/// </summary>
public class State
{
    /// <summary>
    /// The name of the state, province or region.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// The ISO 3166-2 code for the state or region.
    /// </summary>
    public string IsoCode { get; }

    /// <summary>
    /// The Type of state.
    /// </summary>
    public string Type { get; }

    /// <summary>
    /// Constructor for creating a State instance.
    /// </summary>
    /// <param name="name">The name of the state or region.</param>
    /// <param name="isoCode">The ISO 3166-2 code for the state.</param>
    /// <param name="type">The type of state.</param>
    public State([DisallowNull] string name, [DisallowNull] string isoCode, [DisallowNull] string type = "Province")
    {
        Name = name;
        IsoCode = isoCode;
        Type = type;
    }
}
