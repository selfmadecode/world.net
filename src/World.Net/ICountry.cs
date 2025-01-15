namespace World.Net
{
    internal interface ICountry
    {
        ///<inheritdoc/>
        string Name { get; set; }
        string OfficialName { get; set; }
        int NumericCode { get; set; }
        string CountryCode { get; set; }
    }
}
