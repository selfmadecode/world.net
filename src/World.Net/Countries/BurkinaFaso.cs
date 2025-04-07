namespace World.Net.Countries
{
    internal sealed class BurkinaFaso : ICountry
    {
        ///<inheritdoc/>
        public CountryIdentifier Id => CountryIdentifier.BurkinaFaso;

        ///<inheritdoc/>
        public string Name => "Burkina Faso";

        ///<inheritdoc/>
        public string OfficialName { get; } = "The Republic of Burkina Faso";

        ///<inheritdoc/>
        public string NativeName { get; } = "Burkina Faso";

        ///<inheritdoc/>
        public string Capital { get; } = "Ouagadougou";

        ///<inheritdoc/>
        public int NumericCode { get; } = 854;

        ///<inheritdoc/>
        public string ISO2Code { get; } = "BF";

        ///<inheritdoc/>
        public string ISO3Code { get; } = "BFA";

        ///<inheritdoc/>
        public string[] CallingCode { get; } = ["+226"];

        ///<inheritdoc/>
        public IEnumerable<State> States { get; } =
        [
            new("Balé", "BAL", "Province"),
            new("Bam", "BAM", "Province"),
            new("Banwa", "BAN", "Province"),
            new("Bazèga", "BAZ", "Province"),
            new("Boucle du Mouhoun", "01", "Region"),
            new("Bougouriba", "BGR", "Province"),
            new("Boulgou", "BLG", "Province"),
            new("Cascades", "02", "Region"),
            new("Centre", "03", "Region"),
            new("Centre-Est", "04", "Region"),
            new("Centre-Nord", "05", "Region"),
            new("Centre-Ouest", "06", "Region"),
            new("Centre-Sud", "07", "Region"),
            new("Comoé", "COM", "Province"),
            new("Est", "08", "Region"),
            new("Ganzourgou", "GAN", "Province"),
            new("Gnagna", "GNA", "Province"),
            new("Gourma", "GOU", "Province"),
            new("Hauts-Bassins", "09", "Region"),
            new("Houet", "HOU", "Province"),
            new("Ioba", "IOB", "Province"),
            new("Kadiogo", "KAD", "Province"),
            new("Kénédougou", "KEN", "Province"),
            new("Komondjari", "KMD", "Province"),
            new("Kompienga", "KMP", "Province"),
            new("Kossi", "KOS", "Province"),
            new("Koulpélogo", "KOP", "Province"),
            new("Kouritenga", "KOT", "Province"),
            new("Kourwéogo", "KOW", "Province"),
            new("Léraba", "LER", "Province"),
            new("Loroum", "LOR", "Province"),
            new("Mouhoun", "MOU", "Province"),
            new("Nahouri", "NAO", "Province"),
            new("Namentenga", "NAM", "Province"),
            new("Nayala", "NAY", "Province"),
            new("Nord", "10", "Region"),
            new("Noumbiel", "NOU", "Province"),
            new("Oubritenga", "OUB", "Province"),
            new("Oudalan", "OUD", "Province"),
            new("Passoré", "PAS", "Province"),
            new("Plateau-Central", "11", "Region"),
            new("Poni", "PON", "Province"),
            new("Sahel", "12", "Region"),
            new("Sanguié", "SNG", "Province"),
            new("Sanmatenga", "SMT", "Province"),
            new("Séno", "SEN", "Province"),
            new("Sissili", "SIS", "Province"),
            new("Soum", "SOM", "Province"),
            new("Sourou", "SOR", "Province"),
            new("Sud-Ouest", "13", "Region"),
            new("Tapoa", "TAP", "Province"),
            new("Tuy", "TUI", "Province"),
            new("Yagha", "YAG", "Province"),
            new("Yatenga", "YAT", "Province"),
            new("Ziro", "ZIR", "Province"),
            new("Zondoma", "ZON", "Province"),
            new("Zoundwéogo", "ZOU", "Province"),
        ];
    }
}
