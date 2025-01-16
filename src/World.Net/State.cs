using System;

namespace World.Net
{
    internal class State
    {
        /// <summary>
        /// The name of the state or region.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The ISO 3166-2 code for the state or region.
        /// </summary>
        public string IsoCode { get; set; }

        /// <summary>
        /// Constructor for creating a State instance.
        /// </summary>
        /// <param name="name">The name of the state or region.</param>
        /// <param name="isoCode">The ISO 3166-2 code for the state.</param>
        public State(string name, string isoCode)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            IsoCode = isoCode ?? throw new ArgumentNullException(nameof(isoCode));
        }
    }
}
