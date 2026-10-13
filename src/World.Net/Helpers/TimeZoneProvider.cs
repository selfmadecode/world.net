namespace World.Net.Helpers;

/// <summary>
/// Provides time zone information for countries based on their ISO 3166-1 alpha-2 codes.
/// </summary>
/// <remarks>
/// This provider returns one or more time zones for a given country using
/// IANA time zone identifiers and their associated UTC offsets.
/// <para>
/// Some countries span multiple time zones; in such cases, all applicable
/// time zones are returned. The UTC offsets represent the standard offset
/// and do not account for daylight saving time (DST).
/// </para>
/// <para>
/// The data is intended as a reasonable default for country-level modeling
/// and may be overridden by individual country implementations when
/// more specific or localized behavior is required.
/// </para>
/// </remarks>

public static class TimeZoneProvider
{
    private static readonly IReadOnlyDictionary<string, IReadOnlyCollection<CountryTimeZone>> TimeZones
        = new Dictionary<string, IReadOnlyCollection<CountryTimeZone>>(StringComparer.OrdinalIgnoreCase)
        {

            ["AF"] = [ TZ("Asia/Kabul", "UTC+04:30")],
            ["AX"] = [ TZ("Europe/Mariehamn", "UTC+02:00")],
            ["AL"] = new[]
                    {
                        TZ("Europe/Tirane", "UTC+01:00")
                    },
            ["DZ"] = new[]
                    {
                        TZ("Africa/Algiers", "UTC+01:00")
                    },
            ["AS"] = new[]
                    {
                        TZ("Pacific/Pago_Pago", "UTC-11:00")
                    },
            ["AD"] = new[]            
                    {
                        TZ("Europe/Andorra", "UTC+01:00")
                    },
            ["AO"] = new[]
                    {
                        TZ("Africa/Luanda", "UTC+01:00")
                    },
            ["AI"] = new[]
                    {
                        TZ("America/Anguilla", "UTC-04:00")
                    },
            ["AQ"] = new[]
                    {
                        TZ("Antarctica/McMurdo", "UTC+12:00"),
                        TZ("Antarctica/Casey", "UTC+08:00"),
                        TZ("Antarctica/Davis", "UTC+07:00"),
                        TZ("Antarctica/DumontDUrville", "UTC+10:00"),
                        TZ("Antarctica/Mawson", "UTC+05:00"),
                        TZ("Antarctica/Palmer", "UTC-03:00"),
                        TZ("Antarctica/Rothera", "UTC-03:00"),
                        TZ("Antarctica/Syowa", "UTC+03:00"),
                        TZ("Antarctica/Troll", "UTC+00:00"),
                        TZ("Antarctica/Vostok", "UTC+06:00")
                    },
            ["AG"] = new[]
                    {
                        TZ("America/Antigua", "UTC-04:00")
                    },
            ["AR"] = new[]
                    {
                        TZ("America/Argentina/Buenos_Aires", "UTC-03:00"),
                        TZ("America/Argentina/Cordoba", "UTC-03:00"),
                        TZ("America/Argentina/Salta", "UTC-03:00"),
                        TZ("America/Argentina/Jujuy", "UTC-03:00"),
                        TZ("America/Argentina/Tucuman", "UTC-03:00"),
                        TZ("America/Argentina/Catamarca", "UTC-03:00"),
                        TZ("America/Argentina/La_Rioja", "UTC-03:00"),
                        TZ("America/Argentina/San_Juan", "UTC-03:00"),
                        TZ("America/Argentina/Mendoza", "UTC-03:00"),
                        TZ("America/Argentina/San_Luis", "UTC-03:00"),
                        TZ("America/Argentina/Rio_Gallegos", "UTC-03:00"),
                        TZ("America/Argentina/Ushuaia", "UTC-03:00")
                    },
            ["AM"] = new[]
                    {
                        TZ("Asia/Yerevan", "UTC+04:00")
                    },
            ["AW"] = new[]
                    {
                        TZ("America/Aruba", "UTC-04:00")
                    },
            ["AU"] = new[]
                    {
                        TZ("Australia/Sydney", "UTC+10:00"),
                        TZ("Australia/Melbourne", "UTC+10:00"),
                        TZ("Australia/Brisbane", "UTC+10:00"),
                        TZ("Australia/Adelaide", "UTC+09:30"),
                        TZ("Australia/Darwin", "UTC+09:30"),
                        TZ("Australia/Perth", "UTC+08:00"),
                        TZ("Australia/Hobart", "UTC+10:00"),
                        TZ("Australia/Broken_Hill", "UTC+09:30"),
                        TZ("Australia/Lord_Howe", "UTC+10:30")
                    },
            ["AT"] = new[]
                    {
                        TZ("Europe/Vienna", "UTC+01:00")
                    },
            ["AZ"] = new[]
                    {
                        TZ("Asia/Baku", "UTC+04:00")
                    },
            ["BS"] = new[]
                    {
                        TZ("America/Nassau", "UTC-05:00")
                    },
            ["BH"] = new[]
                    {
                        TZ("Asia/Bahrain", "UTC+03:00")
                    },
            ["BD"] = new[]
                    {
                        TZ("Asia/Dhaka", "UTC+06:00")
                    },
            ["BB"] = new[]
                    {
                        TZ("America/Barbados", "UTC-04:00")
                    },
            ["BY"] = new[]
                    {
                        TZ("Europe/Minsk", "UTC+03:00")
                    },
            ["BE"] = new[]
                    {
                        TZ("Europe/Brussels", "UTC+01:00")
                    },
            ["BZ"] = new[]
                    {
                        TZ("America/Belize", "UTC-06:00")
                    },
            ["BJ"] = new[]
                    {
                        TZ("Africa/Porto-Novo", "UTC+01:00")
                    },
            ["BM"] = new[]
                    {
                        TZ("Atlantic/Bermuda", "UTC-04:00")
                    },
            ["BT"] = new[]
                    {
                        TZ("Asia/Thimphu", "UTC+06:00")
                    },
            ["BO"] = new[]
                    {
                        TZ("America/La_Paz", "UTC-04:00")
                    },
            ["BQ"] = new[]
                    {
                        TZ("America/Kralendijk", "UTC-04:00")
                    },
            ["BA"] = new[]
                    {
                        TZ("Europe/Sarajevo", "UTC+01:00")
                    },
            ["BW"] = new[]
                    {
                        TZ("Africa/Gaborone", "UTC+02:00")
                    },
            ["BV"] = new[]
                    {
                        TZ("Antarctica/Troll", "UTC+00:00")
                    },
            ["BR"] = new[]
                    {
                        TZ("America/Sao_Paulo", "UTC-03:00"),
                        TZ("America/Araguaina", "UTC-03:00"),
                        TZ("America/Belem", "UTC-03:00"),
                        TZ("America/Fortaleza", "UTC-03:00"),
                        TZ("America/Recife", "UTC-03:00"),
                        TZ("America/Maceio", "UTC-03:00"),
                        TZ("America/Bahia", "UTC-03:00"),
                        TZ("America/Campo_Grande", "UTC-04:00"),
                        TZ("America/Cuiaba", "UTC-04:00"),
                        TZ("America/Porto_Velho", "UTC-04:00"),
                        TZ("America/Boa_Vista", "UTC-04:00"),
                        TZ("America/Manaus", "UTC-04:00"),
                        TZ("America/Eirunepe", "UTC-05:00"),
                        TZ("America/Rio_Branco", "UTC-05:00"),
                        TZ("America/Noronha", "UTC-02:00")
                    },
            ["IO"] = new[]
                    {
                        TZ("Indian/Chagos", "UTC+06:00")
                    },
            ["BN"] = new[]
                    {
                        TZ("Asia/Brunei", "UTC+08:00")
                    },
            ["BG"] = new[]
                    {
                        TZ("Europe/Sofia", "UTC+02:00")
                    },
            ["BF"] = new[]
                    {
                        TZ("Africa/Ouagadougou", "UTC+00:00")
                    },
            ["BI"] = new[]
                    {
                        TZ("Africa/Bujumbura", "UTC+02:00")
                    },
            ["KH"] = new[]
                    {
                        TZ("Asia/Phnom_Penh", "UTC+07:00")
                    },
            ["CM"] = new[]
                    {
                        TZ("Africa/Douala", "UTC+01:00")
                    },
            ["CA"] = new[]
                    {
                        TZ("America/Toronto", "UTC-05:00"),
                        TZ("America/Winnipeg", "UTC-06:00"),
                        TZ("America/Regina", "UTC-06:00"),
                        TZ("America/Edmonton", "UTC-07:00"),
                        TZ("America/Vancouver", "UTC-08:00"),
                        TZ("America/St_Johns", "UTC-03:30"),
                        TZ("America/Halifax", "UTC-04:00"),
                        TZ("America/Moncton", "UTC-04:00"),
                        TZ("America/Goose_Bay", "UTC-04:00"),
                        TZ("America/Blanc-Sablon", "UTC-04:00"),
                        TZ("America/Atikokan", "UTC-05:00"),
                        TZ("America/Resolute", "UTC-06:00"),
                        TZ("America/Rankin_Inlet", "UTC-06:00"),
                        TZ("America/Iqaluit", "UTC-05:00"),
                        TZ("America/Inuvik", "UTC-07:00"),
                        TZ("America/Dawson", "UTC-08:00"),
                        TZ("America/Whitehorse", "UTC-08:00")
                    },
            ["CV"] = new[]
                    {
                        TZ("Atlantic/Cape_Verde", "UTC-01:00")
                    },
            ["KY"] = new[]
                    {
                        TZ("America/Cayman", "UTC-05:00")
                    },
            ["CF"] = new[]
                    {
                        TZ("Africa/Bangui", "UTC+01:00")
                    },
            ["TD"] = new[]
                    {
                        TZ("Africa/Ndjamena", "UTC+01:00")
                    },
            ["CL"] = new[]
                    {
                        TZ("America/Santiago", "UTC-04:00"),
                        TZ("Pacific/Easter", "UTC-06:00")
                    },
            ["CN"] = new[]
                    {
                        TZ("Asia/Shanghai", "UTC+08:00"),
                        TZ("Asia/Urumqi", "UTC+06:00")
                    },
            ["CX"] = new[]
                    {
                        TZ("Indian/Christmas", "UTC+07:00")
                    },
            ["CC"] = new[]
                    {
                        TZ("Indian/Cocos", "UTC+06:30")
                    },
            ["CO"] = new[]
                    {
                        TZ("America/Bogota", "UTC-05:00")
                    },
            ["KM"] = new[]
                    {
                        TZ("Indian/Comoro", "UTC+03:00")
                    },
            ["CG"] = new[]
                    {
                        TZ("Africa/Brazzaville", "UTC+01:00")
                    },
            ["CD"] = new[]
                    {
                        TZ("Africa/Kinshasa", "UTC+01:00"),
                        TZ("Africa/Lubumbashi", "UTC+02:00")
                    },
            ["CK"] = new[]
                    {
                        TZ("Pacific/Rarotonga", "UTC-10:00")
                    },
            ["CR"] = new[]
                    {
                        TZ("America/Costa_Rica", "UTC-06:00")
                    },
            ["CI"] = new[]
                    {
                        TZ("Africa/Abidjan", "UTC+00:00")
                    },
            ["HR"] = new[]
                    {
                        TZ("Europe/Zagreb", "UTC+01:00")
                    },
            ["CU"] = new[]
                    {
                        TZ("America/Havana", "UTC-05:00")
                    },
            ["CW"] = new[]
                    {
                        TZ("America/Curacao", "UTC-04:00")
                    },
            ["CY"] = new[]
                    {
                        TZ("Asia/Nicosia", "UTC+02:00"),
                        TZ("Asia/Famagusta", "UTC+02:00")
                    },
            ["CZ"] = new[]
                    {
                        TZ("Europe/Prague", "UTC+01:00")
                    },
            ["DK"] = new[]
                    {
                        TZ("Europe/Copenhagen", "UTC+01:00")
                    },
            ["DJ"] = new[]
                    {
                        TZ("Africa/Djibouti", "UTC+03:00")
                    },
            ["DM"] = new[]
                    {
                        TZ("America/Dominica", "UTC-04:00")
                    },
            ["DO"] = new[]
                    {
                        TZ("America/Santo_Domingo", "UTC-04:00")
                    },
            ["EC"] = new[]
                    {
                        TZ("America/Guayaquil", "UTC-05:00"),
                        TZ("Pacific/Galapagos", "UTC-06:00")
                    },
            ["EG"] = new[]
                    {
                        TZ("Africa/Cairo", "UTC+02:00")
                    },
            ["SV"] = new[]
                    {
                        TZ("America/El_Salvador", "UTC-06:00")
                    },
            ["GQ"] = new[]
                    {
                        TZ("Africa/Malabo", "UTC+01:00")
                    },
            ["ER"] = new[]
                    {
                        TZ("Africa/Asmara", "UTC+03:00")
                    },
            ["EE"] = new[]
                    {
                        TZ("Europe/Tallinn", "UTC+02:00")
                    },
            ["SZ"] = new[]
                    {
                        TZ("Africa/Mbabane", "UTC+02:00")
                    },
            ["ET"] = new[]
                    {
                        TZ("Africa/Addis_Ababa", "UTC+03:00")
                    },
            ["FK"] = new[]
                    {
                        TZ("Atlantic/Stanley", "UTC-03:00")
                    },
            ["FO"] = new[]
                    {
                        TZ("Atlantic/Faroe", "UTC+00:00")
                    },
            ["FJ"] = new[]
                    {
                        TZ("Pacific/Fiji", "UTC+12:00")
                    },
            ["FI"] = new[]
                    {
                        TZ("Europe/Helsinki", "UTC+02:00")
                    },
            ["FR"] = new[]
                    {
                        TZ("Europe/Paris", "UTC+01:00")
                    },
            ["GF"] = new[]
                    {
                        TZ("America/Cayenne", "UTC-03:00")
                    },
            ["PF"] = new[]
                    {
                        TZ("Pacific/Tahiti", "UTC-10:00")
                    },
            ["TF"] = new[]
                    {
                        TZ("Indian/Kerguelen", "UTC+05:00")
                    },
            ["GA"] = new[]
                    {
                        TZ("Africa/Libreville", "UTC+01:00")
                    },
            ["GM"] = new[]
                    {
                        TZ("Africa/Banjul", "UTC+00:00")
                    },
            ["GE"] = new[]
                    {
                        TZ("Asia/Tbilisi", "UTC+04:00")
                    },
            ["DE"] = new[]
                    {
                        TZ("Europe/Berlin", "UTC+01:00")
                    },
            ["GH"] = new[]
                    {
                        TZ("Africa/Accra", "UTC+00:00")
                    },
            ["GR"] = new[]
                    {
                        TZ("Europe/Athens", "UTC+02:00")
                    },
            ["GL"] = new[]
                    {
                        TZ("America/Godthab", "UTC-03:00"), // Greenland standard
                        TZ("America/Danmarkshavn", "UTC+00:00"),
                        TZ("America/Scoresbysund", "UTC+01:00"),
                        TZ("America/Thule", "UTC-04:00")
                    },
            ["GD"] = new[]
                    {
                        TZ("America/Grenada", "UTC-04:00")
                    },
            ["GP"] = new[]
                    {
                        TZ("America/Guadeloupe", "UTC-04:00")
                    },
            ["GU"] = new[]
                    {
                        TZ("Pacific/Guam", "UTC+10:00")
                    },
            ["GT"] = new[]
                    {
                        TZ("America/Guatemala", "UTC-06:00")
                    },
            ["GG"] = new[]
                    {
                        TZ("Europe/Guernsey", "UTC+00:00")
                    },
            ["GN"] = new[]
                    {
                        TZ("Africa/Conakry", "UTC+00:00")
                    },
            ["GW"] = new[]
                    {
                        TZ("Africa/Bissau", "UTC+00:00")
                    },
            ["GY"] = new[]
                    {
                        TZ("America/Guyana", "UTC-04:00")
                    },
            ["HT"] = new[]
                    {
                        TZ("America/Port-au-Prince", "UTC-05:00")
                    },
            ["HM"] = new[]
                    {
                        TZ("Indian/Heard", "UTC+05:00")
                    },
            ["HN"] = new[]
                    {
                        TZ("America/Tegucigalpa", "UTC-06:00")
                    },
            ["HK"] = new[]
                    {
                        TZ("Asia/Hong_Kong", "UTC+08:00")
                    },
            ["HU"] = new[]
                    {
                        TZ("Europe/Budapest", "UTC+01:00")
                    },
            ["IS"] = new[]
                    {
                        TZ("Atlantic/Reykjavik", "UTC+00:00")
                    },
            ["IN"] = new[]
                    {
                        TZ("Asia/Kolkata", "UTC+05:30")
                    },
            ["ID"] = new[]
                    {
                        TZ("Asia/Jakarta", "UTC+07:00"),
                        TZ("Asia/Pontianak", "UTC+07:00"),
                        TZ("Asia/Makassar", "UTC+08:00"),
                        TZ("Asia/Jayapura", "UTC+09:00")
                    },
            ["IR"] = new[]
                    {
                        TZ("Asia/Tehran", "UTC+03:30")
                    },
            ["IQ"] = new[]
                    {
                        TZ("Asia/Baghdad", "UTC+03:00")
                    },
            ["IE"] = new[]
                    {
                        TZ("Europe/Dublin", "UTC+00:00")
                    },
            ["IM"] = new[]
                    {
                        TZ("Europe/Isle_of_Man", "UTC+00:00")
                    },
            ["IL"] = new[]
                    {
                        TZ("Asia/Jerusalem", "UTC+02:00")
                    },
            ["IT"] = new[]
                    {
                        TZ("Europe/Rome", "UTC+01:00")
                    },
            ["JM"] = new[]
                    {
                        TZ("America/Jamaica", "UTC-05:00")
                    },
            ["JP"] = new[]
                    {
                        TZ("Asia/Tokyo", "UTC+09:00")
                    },
            ["JE"] = new[]
                    {
                        TZ("Europe/Jersey", "UTC+00:00")
                    },
            ["JO"] = new[]
                    {
                        TZ("Asia/Amman", "UTC+02:00")
                    },
            ["KZ"] = new[]
                    {
                        TZ("Asia/Almaty", "UTC+06:00"),
                        TZ("Asia/Qostanay", "UTC+06:00"),
                        TZ("Asia/Aqtobe", "UTC+05:00"),
                        TZ("Asia/Aqtau", "UTC+05:00"),
                        TZ("Asia/Oral", "UTC+05:00"),
                        TZ("Asia/Atyrau", "UTC+05:00"),
                        TZ("Asia/Qyzylorda", "UTC+05:00")
                    },
            ["KE"] = new[]
                    {
                        TZ("Africa/Nairobi", "UTC+03:00")
                    },
            ["KI"] = new[]
                    {
                        TZ("Pacific/Tarawa", "UTC+12:00")
                    },
            ["XK"] = new[]
                    {
                        TZ("Europe/Belgrade", "UTC+01:00") // Kosovo uses Central European Time
                    },
            ["KP"] = new[]
                    {
                        TZ("Asia/Pyongyang", "UTC+09:00")
                    },
            ["KR"] = new[]
                    {
                        TZ("Asia/Seoul", "UTC+09:00")
                    },
            ["KW"] = new[]
                    {
                        TZ("Asia/Kuwait", "UTC+03:00")
                    },
            ["KG"] = new[]
                    {
                        TZ("Asia/Bishkek", "UTC+06:00")
                    },
            ["LA"] = new[]
                    {
                        TZ("Asia/Vientiane", "UTC+07:00")
                    },
            ["LV"] = new[]
                    {
                        TZ("Europe/Riga", "UTC+02:00")
                    },
            ["LB"] = new[]
                    {
                        TZ("Asia/Beirut", "UTC+02:00")
                    },
            ["LS"] = new[]
                    {
                        TZ("Africa/Maseru", "UTC+02:00")
                    },
            ["LR"] = new[]
                    {
                        TZ("Africa/Monrovia", "UTC+00:00")
                    },
            ["LY"] = new[]
                    {
                        TZ("Africa/Tripoli", "UTC+02:00")
                    },
            ["LI"] = new[]
                    {
                        TZ("Europe/Vaduz", "UTC+01:00")
                    },
            ["LT"] = new[]
                    {
                        TZ("Europe/Vilnius", "UTC+02:00")
                    },
            ["LU"] = new[]
                    {
                        TZ("Europe/Luxembourg", "UTC+01:00")
                    },
            ["MO"] = new[]
                    {
                        TZ("Asia/Macau", "UTC+08:00")
                    },
            ["MK"] = new[]
                    {
                        TZ("Europe/Skopje", "UTC+01:00")
                    },
            ["MG"] = new[]
                    {
                        TZ("Indian/Antananarivo", "UTC+03:00")
                    },
            ["MW"] = new[]
                    {
                        TZ("Africa/Blantyre", "UTC+02:00")
                    },
            ["MY"] = new[]
                    {
                        TZ("Asia/Kuala_Lumpur", "UTC+08:00"),
                        TZ("Asia/Kuching", "UTC+08:00")
                    },
            ["MV"] = new[]
                    {
                        TZ("Indian/Maldives", "UTC+05:00")
                    },
            ["ML"] = new[]
                    {
                        TZ("Africa/Bamako", "UTC+00:00")
                    },
            ["MT"] = new[]
                    {
                        TZ("Europe/Malta", "UTC+01:00")
                    },
            ["MH"] = new[]
                    {
                        TZ("Pacific/Majuro", "UTC+12:00"),
                        TZ("Pacific/Kwajalein", "UTC+12:00")
                    },
            ["MQ"] = new[]
                    {
                        TZ("America/Martinique", "UTC-04:00")
                    },
            ["MR"] = new[]
                    {
                        TZ("Africa/Nouakchott", "UTC+00:00")
                    },
            ["MU"] = new[]
                    {
                        TZ("Indian/Mauritius", "UTC+04:00")
                    },
            ["YT"] = new[]
                    {
                        TZ("Indian/Mayotte", "UTC+03:00")
                    },
            ["MX"] = new[]
                    {
                        TZ("America/Mexico_City", "UTC-06:00"),
                        TZ("America/Cancun", "UTC-05:00"),
                        TZ("America/Monterrey", "UTC-06:00"),
                        TZ("America/Matamoros", "UTC-06:00"),
                        TZ("America/Mazatlan", "UTC-07:00"),
                        TZ("America/Chihuahua", "UTC-07:00"),
                        TZ("America/Hermosillo", "UTC-07:00"),
                        TZ("America/Tijuana", "UTC-08:00"),
                        TZ("America/Bahia_Banderas", "UTC-06:00")
                    },
            ["FM"] = new[]
                    {
                        TZ("Pacific/Chuuk", "UTC+10:00"),
                        TZ("Pacific/Pohnpei", "UTC+11:00"),
                        TZ("Pacific/Kosrae", "UTC+11:00")
                    },
            ["MD"] = new[]
                    {
                        TZ("Europe/Chisinau", "UTC+02:00")
                    },
            ["MC"] = new[]
                    {
                        TZ("Europe/Monaco", "UTC+01:00")
                    },
            ["MN"] = new[]
                    {
                        TZ("Asia/Ulaanbaatar", "UTC+08:00"),
                        TZ("Asia/Hovd", "UTC+07:00"),
                        TZ("Asia/Choibalsan", "UTC+08:00")
                    },
            ["ME"] = new[]
                    {
                        TZ("Europe/Podgorica", "UTC+01:00")
                    },
            ["MS"] = new[]
                    {
                        TZ("America/Montserrat", "UTC-04:00")
                    },
            ["MA"] = new[]
                    {
                        TZ("Africa/Casablanca", "UTC+00:00")
                    },
            ["MZ"] = new[]
                    {
                        TZ("Africa/Maputo", "UTC+02:00")
                    },
            ["MM"] = new[]
                    {
                        TZ("Asia/Yangon", "UTC+06:30")
                    },
            ["NA"] = new[]
                    {
                        TZ("Africa/Windhoek", "UTC+02:00")
                    },
            ["NR"] = new[]
                    {
                        TZ("Pacific/Nauru", "UTC+12:00")
                    },
            ["NP"] = new[]
                    {
                        TZ("Asia/Kathmandu", "UTC+05:45")
                    },
            ["BQ"] = new[]
                    {
                        TZ("America/Kralendijk", "UTC-04:00")
                    },
            ["NL"] = new[]
                    {
                        TZ("Europe/Amsterdam", "UTC+01:00")
                    },
            ["NC"] = new[]
                    {
                        TZ("Pacific/Noumea", "UTC+11:00")
                    },
            ["NZ"] = new[]
                    {
                        TZ("Pacific/Auckland", "UTC+12:00"),
                        TZ("Pacific/Chatham", "UTC+12:45")
                    },
            ["NI"] = new[]
                    {
                        TZ("America/Managua", "UTC-06:00")
                    },
            ["NE"] = new[]
                    {
                        TZ("Africa/Niamey", "UTC+01:00")
                    },
            ["NG"] = new[]
                    {
                        TZ("Africa/Lagos", "UTC+01:00")
                    },
            ["NU"] = new[]
                    {
                        TZ("Pacific/Niue", "UTC-11:00")
                    },
            ["NF"] = new[]
                    {
                        TZ("Pacific/Norfolk", "UTC+11:00")
                    },
            ["MP"] = new[]
                    {
                        TZ("Pacific/Saipan", "UTC+10:00")
                    },
            ["NO"] = new[]
                    {
                        TZ("Europe/Oslo", "UTC+01:00")
                    },
            ["OM"] = new[]
                    {
                        TZ("Asia/Muscat", "UTC+04:00")
                    },
            ["PK"] = new[]
                    {
                        TZ("Asia/Karachi", "UTC+05:00")
                    },
            ["PW"] = new[]
                    {
                        TZ("Pacific/Palau", "UTC+09:00")
                    },
            ["PS"] = new[]
                    {
                        TZ("Asia/Gaza", "UTC+02:00"),
                        TZ("Asia/Hebron", "UTC+02:00")
                    },
            ["PA"] = new[]
                    {
                        TZ("America/Panama", "UTC-05:00")
                    },
            ["PG"] = new[]
                    {
                        TZ("Pacific/Port_Moresby", "UTC+10:00")
                    },
            ["PY"] = new[]
                    {
                        TZ("America/Asuncion", "UTC-04:00")
                    },
            ["PE"] = new[]
                    {
                        TZ("America/Lima", "UTC-05:00")
                    },
            ["PH"] = new[]
                    {
                        TZ("Asia/Manila", "UTC+08:00")
                    },
            ["PN"] = new[]
                    {
                        TZ("Pacific/Pitcairn", "UTC-08:00")
                    },
            ["PL"] = new[]
                    {
                        TZ("Europe/Warsaw", "UTC+01:00")
                    },
            ["PT"] = new[]
                    {
                        TZ("Europe/Lisbon", "UTC+00:00"),
                        TZ("Atlantic/Madeira", "UTC+00:00"),
                        TZ("Atlantic/Azores", "UTC-01:00")
                    },
            ["PR"] = new[]
                    {
                        TZ("America/Puerto_Rico", "UTC-04:00")
                    },
            ["QA"] = new[]
                    {
                        TZ("Asia/Qatar", "UTC+03:00")
                    },
            ["RE"] = new[]
                    {
                        TZ("Indian/Reunion", "UTC+04:00")
                    },
            ["RO"] = new[]
                    {
                        TZ("Europe/Bucharest", "UTC+02:00")
                    },
            ["RU"] = new[]
                    {
                        TZ("Europe/Kaliningrad", "UTC+02:00"),
                        TZ("Europe/Moscow", "UTC+03:00"),
                        TZ("Europe/Volgograd", "UTC+03:00"),
                        TZ("Europe/Samara", "UTC+04:00"),
                        TZ("Asia/Yekaterinburg", "UTC+05:00"),
                        TZ("Asia/Omsk", "UTC+06:00"),
                        TZ("Asia/Novosibirsk", "UTC+07:00"),
                        TZ("Asia/Krasnoyarsk", "UTC+08:00"),
                        TZ("Asia/Irkutsk", "UTC+09:00"),
                        TZ("Asia/Yakutsk", "UTC+09:00"),
                        TZ("Asia/Vladivostok", "UTC+10:00"),
                        TZ("Asia/Srednekolymsk", "UTC+11:00"),
                        TZ("Asia/Kamchatka", "UTC+12:00"),
                        TZ("Asia/Anadyr", "UTC+12:00")
                    },
            ["RW"] = new[]
                    {
                        TZ("Africa/Kigali", "UTC+02:00")
                    },
            ["BL"] = new[]
                    {
                        TZ("America/St_Barthelemy", "UTC-04:00")
                    },
            ["SH"] = new[]
                    {
                        TZ("Atlantic/St_Helena", "UTC+00:00")
                    },
            ["KN"] = new[]
                    {
                        TZ("America/St_Kitts", "UTC-04:00")
                    },
            ["LC"] = new[]
                    {
                        TZ("America/St_Lucia", "UTC-04:00")
                    },
            ["MF"] = new[]
                    {
                        TZ("America/Marigot", "UTC-04:00")
                    },
            ["PM"] = new[]
                    {
                        TZ("America/Miquelon", "UTC-03:00")
                    },
            ["VC"] = new[]
                    {
                        TZ("America/St_Vincent", "UTC-04:00")
                    },
            ["WS"] = new[]
                    {
                        TZ("Pacific/Apia", "UTC+13:00")
                    },
            ["SM"] = new[]
                    {
                        TZ("Europe/San_Marino", "UTC+01:00")
                    },
            ["ST"] = new[]
                    {
                        TZ("Africa/Sao_Tome", "UTC+00:00")
                    },
            ["SA"] = new[]
                    {
                        TZ("Asia/Riyadh", "UTC+03:00")
                    },
            ["SN"] = new[]
                    {
                        TZ("Africa/Dakar", "UTC+00:00")
                    },
            ["RS"] = new[]
                    {
                        TZ("Europe/Belgrade", "UTC+01:00")
                    },
            ["SC"] = new[]
                    {
                        TZ("Indian/Mahe", "UTC+04:00")
                    },
            ["SL"] = new[]
                    {
                        TZ("Africa/Freetown", "UTC+00:00")
                    },
            ["SG"] = new[]
                    {
                        TZ("Asia/Singapore", "UTC+08:00")
                    },
            ["SX"] = new[]
                    {
                        TZ("America/Lower_Princes", "UTC-04:00")
                    },
            ["SK"] = new[]
                    {
                        TZ("Europe/Bratislava", "UTC+01:00")
                    },
            ["SI"] = new[]
                    {
                        TZ("Europe/Ljubljana", "UTC+01:00")
                    },
            ["SB"] = new[]
                    {
                        TZ("Pacific/Guadalcanal", "UTC+11:00")
                    },
            ["SO"] = new[]
                    {
                        TZ("Africa/Mogadishu", "UTC+03:00")
                    },
            ["ZA"] = new[]
                    {
                        TZ("Africa/Johannesburg", "UTC+02:00")
                    },
            ["GS"] = new[]
                    {
                        TZ("Atlantic/South_Georgia", "UTC-02:00")
                    },
            ["SS"] = new[]
                    {
                        TZ("Africa/Juba", "UTC+03:00")
                    },
            ["ES"] = new[]
                    {
                        TZ("Europe/Madrid", "UTC+01:00"),
                        TZ("Atlantic/Canary", "UTC+00:00")
                    },
            ["LK"] = new[]
                    {
                        TZ("Asia/Colombo", "UTC+05:30")
                    },
            ["SD"] = new[]
                    {
                        TZ("Africa/Khartoum", "UTC+02:00")
                    },
            ["SR"] = new[]
                    {
                        TZ("America/Paramaribo", "UTC-03:00")
                    },
            ["SE"] = new[]
                    {
                        TZ("Europe/Stockholm", "UTC+01:00")
                    },
            ["CH"] = new[]
                    {
                        TZ("Europe/Zurich", "UTC+01:00")
                    },
            ["SY"] = new[]
                    {
                        TZ("Asia/Damascus", "UTC+02:00")
                    },
            ["TW"] = new[]
                    {
                        TZ("Asia/Taipei", "UTC+08:00")
                    },
            ["TJ"] = new[]
                    {
                        TZ("Asia/Dushanbe", "UTC+05:00")
                    },
            ["TZ"] = new[]
                    {
                        TZ("Africa/Dar_es_Salaam", "UTC+03:00")
                    },
            ["TH"] = new[]
                    {
                        TZ("Asia/Bangkok", "UTC+07:00")
                    },
            ["TL"] = new[]
                    {
                        TZ("Asia/Dili", "UTC+09:00")
                    },
            ["TG"] = new[]
                    {
                        TZ("Africa/Lome", "UTC+00:00")
                    },
            ["TK"] = new[]
                    {
                        TZ("Pacific/Fakaofo", "UTC+13:00")
                    },
            ["TO"] = new[]
                    {
                        TZ("Pacific/Tongatapu", "UTC+13:00")
                    },
            ["TT"] = new[]
                    {
                        TZ("America/Port_of_Spain", "UTC-04:00")
                    },
            ["TN"] = new[]
                    {
                        TZ("Africa/Tunis", "UTC+01:00")
                    },
            ["TR"] = new[]
                    {
                        TZ("Europe/Istanbul", "UTC+03:00")
                    },
            ["TM"] = new[]
                    {
                        TZ("Asia/Ashgabat", "UTC+05:00")
                    },
            ["TC"] = new[]
                    {
                        TZ("America/Grand_Turk", "UTC-05:00")
                    },
            ["TV"] = new[]
                    {
                        TZ("Pacific/Funafuti", "UTC+12:00")
                    },
            ["UG"] = new[]
                    {
                        TZ("Africa/Kampala", "UTC+03:00")
                    },
            ["UA"] = new[]
                    {
                        TZ("Europe/Kiev", "UTC+02:00"),
                        TZ("Europe/Uzhgorod", "UTC+02:00"),
                        TZ("Europe/Zaporozhye", "UTC+02:00")
                    },
            ["AE"] = new[]
                    {
                        TZ("Asia/Dubai", "UTC+04:00")
                    },
            ["GB"] = new[]
                    {
                        TZ("Europe/London", "UTC+00:00")
                    },
            ["US"] = new[]
                    {
                        TZ("America/New_York", "UTC-05:00"),
                        TZ("America/Chicago", "UTC-06:00"),
                        TZ("America/Denver", "UTC-07:00"),
                        TZ("America/Los_Angeles", "UTC-08:00"),
                        TZ("America/Anchorage", "UTC-09:00"),
                        TZ("Pacific/Honolulu", "UTC-10:00")
                    },
            ["UY"] = new[]
                    {
                        TZ("America/Montevideo", "UTC-03:00")
                    },
            ["UZ"] = new[]
                    {
                        TZ("Asia/Samarkand", "UTC+05:00"),
                        TZ("Asia/Tashkent", "UTC+05:00")
                    },
            ["VU"] = new[]
                    {
                        TZ("Pacific/Efate", "UTC+11:00")
                    },
            ["VE"] = new[]
                    {
                        TZ("America/Caracas", "UTC-04:00")
                    },
            ["VN"] = new[]
                    {
                        TZ("Asia/Ho_Chi_Minh", "UTC+07:00")
                    },
            ["WF"] = new[]
                    {
                        TZ("Pacific/Wallis", "UTC+12:00")
                    },
            ["EH"] = new[]
                    {
                        TZ("Africa/El_Aaiun", "UTC+00:00")
                    },
            ["YE"] = new[]
                    {
                        TZ("Asia/Aden", "UTC+03:00")
                    },
            ["ZM"] = new[]
                    {
                        TZ("Africa/Lusaka", "UTC+02:00")
                    },
            ["ZW"] = new[]
                    {
                        TZ("Africa/Harare", "UTC+02:00")
                    },
            ["GI"] = new[]
                    {
                        TZ("Europe/Gibraltar", "UTC+01:00")
                    },
            ["SJ"] = new[]
                    {
                        TZ("Arctic/Longyearbyen", "UTC+01:00")
                    },
            ["UM"] = new[]
                    {
                        TZ("Pacific/Wake", "UTC+12:00"),      // Wake Island
                        TZ("Pacific/Midway", "UTC-11:00"),    // Midway Atoll
                        TZ("Pacific/Johnston", "UTC-10:00")   // Johnston Atoll
                    },
            ["VA"] = new[]
                    {
                        TZ("Europe/Vatican", "UTC+01:00")
                    },
            ["VG"] = new[]
                    {
                        TZ("America/Tortola", "UTC-04:00")
                    },
            ["VI"] = new[]
                    {
                        TZ("America/St_Thomas", "UTC-04:00")
                    }
        };


    /// <summary>
    /// Gets the collection of time zones associated with the specified country.
    /// </summary>
    /// <param name="iso2">
    /// The ISO 3166-1 alpha-2 country code (e.g. <c>US</c>, <c>FR</c>, <c>JP</c>).
    /// </param>
    /// <returns>
    /// A read-only collection of time zone representations for the country.
    /// Each entry is formatted as <c>&lt;IANA ID&gt; (UTC±X)</c>.
    /// If the country code is not recognized, an empty collection is returned.
    /// </returns>
    /// <remarks>
    /// Countries that span multiple time zones will return more than one entry.
    /// The UTC offsets represent standard time and do not account for
    /// daylight saving time (DST).
    /// </remarks>

    public static IReadOnlyCollection<string> GetTimeZones(string iso2)
    {
        if (TimeZones.TryGetValue(iso2, out var zones))
        {
            return [..zones.Select(z => z.ToString())];
        }

        return [];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="iana"></param>
    /// <param name="utc"></param>
    /// <returns></returns>
    public static CountryTimeZone TZ(string iana, string utc)
        => new(iana, utc);
}

/// <summary>
/// Represents a time zone associated with a country, including its IANA identifier
/// and the corresponding UTC offset.
/// </summary>
/// <param name="IanaId">
/// The IANA time zone identifier (e.g. <c>Europe/Paris</c>, <c>America/New_York</c>).
/// </param>
/// <param name="UtcOffset">
/// The UTC offset for the time zone (e.g. <c>UTC+1</c>, <c>UTC-5</c>, <c>UTC+5:30</c>).
/// </param>
public sealed class CountryTimeZone(string IanaId, string UtcOffset)
{
    /// <summary>
    /// Returns a human-readable string combining the IANA time zone identifier
    /// and its UTC offset.
    /// </summary>
    /// <returns>
    /// A formatted string in the form <c>&lt;IANA ID&gt; (UTC±X)</c>.
    /// </returns>
    public override string ToString() => $"{IanaId} ({UtcOffset})";
}
