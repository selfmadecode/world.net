using World.Net.Types;

namespace World.Net.Helpers;

internal static class CurrencyProvider
{
    public static Currency GetCurrency(string iso2, string countryName)
    {
        return iso2.ToUpperInvariant() switch
        {
            // A
            "AD" => new("EUR", "Euro", "€"),
            "AE" => new("AED", "UAE Dirham", "د.إ"),
            "AF" => new("AFN", "Afghan Afghani", "؋"),
            "AG" => new("XCD", "East Caribbean Dollar", "$"),
            "AI" => new("XCD", "East Caribbean Dollar", "$"),
            "AL" => new("ALL", "Albanian Lek", "L"),
            "AM" => new("AMD", "Armenian Dram", "֏"),
            "AO" => new("AOA", "Angolan Kwanza", "Kz"),
            "AR" => new("ARS", "Argentine Peso", "$"),
            "AT" => new("EUR", "Euro", "€"),
            "AU" => new("AUD", "Australian Dollar", "$"),
            "AW" => new("AWG", "Aruban Florin", "ƒ"),
            "AZ" => new("AZN", "Azerbaijani Manat", "₼"),

            // B
            "BA" => new("BAM", "Bosnia and Herzegovina Convertible Mark", "KM"),
            "BB" => new("BBD", "Barbadian Dollar", "$"),
            "BD" => new("BDT", "Bangladeshi Taka", "৳"),
            "BE" => new("EUR", "Euro", "€"),
            "BF" => new("XOF", "West African CFA Franc", "CFA"),
            "BG" => new("BGN", "Bulgarian Lev", "лв"),
            "BH" => new("BHD", "Bahraini Dinar", ".د.ب"),
            "BI" => new("BIF", "Burundian Franc", "FBu"),
            "BJ" => new("XOF", "West African CFA Franc", "CFA"),
            "BM" => new("BMD", "Bermudian Dollar", "$"),
            "BN" => new("BND", "Brunei Dollar", "$"),
            "BO" => new("BOB", "Bolivian Boliviano", "Bs."),
            "BR" => new("BRL", "Brazilian Real", "R$"),
            "BS" => new("BSD", "Bahamian Dollar", "$"),
            "BT" => new("BTN", "Bhutanese Ngultrum", "Nu."),
            "BW" => new("BWP", "Botswana Pula", "P"),
            "BY" => new("BYN", "Belarusian Ruble", "Br"),
            "BZ" => new("BZD", "Belize Dollar", "$"),

            // C
            "CA" => new("CAD", "Canadian Dollar", "$"),
            "CD" => new("CDF", "Congolese Franc", "FC"),
            "CF" => new("XAF", "Central African CFA Franc", "CFA"),
            "CG" => new("XAF", "Central African CFA Franc", "CFA"),
            "CH" => new("CHF", "Swiss Franc", "CHF"),
            "CI" => new("XOF", "West African CFA Franc", "CFA"),
            "CL" => new("CLP", "Chilean Peso", "$"),
            "CM" => new("XAF", "Central African CFA Franc", "CFA"),
            "CN" => new("CNY", "Chinese Yuan", "¥"),
            "CO" => new("COP", "Colombian Peso", "$"),
            "CR" => new("CRC", "Costa Rican Colón", "₡"),
            "CU" => new("CUP", "Cuban Peso", "$"),
            "CV" => new("CVE", "Cape Verdean Escudo", "$"),
            "CY" => new("EUR", "Euro", "€"),
            "CZ" => new("CZK", "Czech Koruna", "Kč"),

            // D
            "DE" => new("EUR", "Euro", "€"),
            "DJ" => new("DJF", "Djiboutian Franc", "Fdj"),
            "DK" => new("DKK", "Danish Krone", "kr"),
            "DM" => new("XCD", "East Caribbean Dollar", "$"),
            "DO" => new("DOP", "Dominican Peso", "$"),
            "DZ" => new("DZD", "Algerian Dinar", "د.ج"),

            // E
            "EC" => new("USD", "United States Dollar", "$"),
            "EE" => new("EUR", "Euro", "€"),
            "EG" => new("EGP", "Egyptian Pound", "£"),
            "ER" => new("ERN", "Eritrean Nakfa", "Nfk"),
            "ES" => new("EUR", "Euro", "€"),
            "ET" => new("ETB", "Ethiopian Birr", "Br"),

            // F
            "FI" => new("EUR", "Euro", "€"),
            "FJ" => new("FJD", "Fiji Dollar", "$"),
            "FR" => new("EUR", "Euro", "€"),

            // G
            "GA" => new("XAF", "Central African CFA Franc", "CFA"),
            "GB" => new("GBP", "British Pound Sterling", "£"),
            "GD" => new("XCD", "East Caribbean Dollar", "$"),
            "GE" => new("GEL", "Georgian Lari", "₾"),
            "GH" => new("GHS", "Ghanaian Cedi", "₵"),
            "GM" => new("GMD", "Gambian Dalasi", "D"),
            "GN" => new("GNF", "Guinean Franc", "FG"),
            "GR" => new("EUR", "Euro", "€"),
            "GT" => new("GTQ", "Guatemalan Quetzal", "Q"),
            "GY" => new("GYD", "Guyanese Dollar", "$"),

            // H
            "HK" => new("HKD", "Hong Kong Dollar", "$"),
            "HN" => new("HNL", "Honduran Lempira", "L"),
            "HR" => new("EUR", "Euro", "€"),
            "HT" => new("HTG", "Haitian Gourde", "G"),
            "HU" => new("HUF", "Hungarian Forint", "Ft"),

            // I
            "ID" => new("IDR", "Indonesian Rupiah", "Rp"),
            "IE" => new("EUR", "Euro", "€"),
            "IL" => new("ILS", "Israeli New Shekel", "₪"),
            "IN" => new("INR", "Indian Rupee", "₹"),
            "IQ" => new("IQD", "Iraqi Dinar", "ع.د"),
            "IR" => new("IRR", "Iranian Rial", "﷼"),
            "IS" => new("ISK", "Icelandic Króna", "kr"),
            "IT" => new("EUR", "Euro", "€"),

            // J
            "JM" => new("JMD", "Jamaican Dollar", "$"),
            "JO" => new("JOD", "Jordanian Dinar", "د.ا"),
            "JP" => new("JPY", "Japanese Yen", "¥"),

            // K
            "KE" => new("KES", "Kenyan Shilling", "Sh"),
            "KG" => new("KGS", "Kyrgyzstani Som", "с"),
            "KH" => new("KHR", "Cambodian Riel", "៛"),
            "KR" => new("KRW", "South Korean Won", "₩"),
            "KW" => new("KWD", "Kuwaiti Dinar", "د.ك"),

            // L
            "LA" => new("LAK", "Lao Kip", "₭"),
            "LB" => new("LBP", "Lebanese Pound", "£"),
            "LK" => new("LKR", "Sri Lankan Rupee", "Rs"),
            "LR" => new("LRD", "Liberian Dollar", "$"),
            "LS" => new("LSL", "Lesotho Loti", "L"),
            "LT" => new("EUR", "Euro", "€"),
            "LU" => new("EUR", "Euro", "€"),
            "LV" => new("EUR", "Euro", "€"),

            // M
            "MA" => new("MAD", "Moroccan Dirham", "د.م."),
            "MX" => new("MXN", "Mexican Peso", "$"),
            "MY" => new("MYR", "Malaysian Ringgit", "RM"),

            // N
            "NG" => new("NGN", "Nigerian Naira", "₦"),
            "NO" => new("NOK", "Norwegian Krone", "kr"),
            "NZ" => new("NZD", "New Zealand Dollar", "$"),

            // O–Z (shared / common)
            "PK" => new("PKR", "Pakistani Rupee", "₨"),
            "PL" => new("PLN", "Polish Złoty", "zł"),
            "PT" => new("EUR", "Euro", "€"),
            "QA" => new("QAR", "Qatari Riyal", "ر.ق"),
            "RO" => new("RON", "Romanian Leu", "lei"),
            "RU" => new("RUB", "Russian Ruble", "₽"),
            "SA" => new("SAR", "Saudi Riyal", "﷼"),
            "SE" => new("SEK", "Swedish Krona", "kr"),
            "SG" => new("SGD", "Singapore Dollar", "$"),
            "TH" => new("THB", "Thai Baht", "฿"),
            "TR" => new("TRY", "Turkish Lira", "₺"),
            "UA" => new("UAH", "Ukrainian Hryvnia", "₴"),
            "US" => new("USD", "United States Dollar", "$"),
            "VN" => new("VND", "Vietnamese Đồng", "₫"),
            "ZA" => new("ZAR", "South African Rand", "R"),

            _ => new Currency(string.Empty, string.Empty, string.Empty)
        };
    }
}
