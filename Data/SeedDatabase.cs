using System;
using System.Linq;
using DotnetCoreCountry.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCoreCountry.Data
{
    public class SeedDatabase
    {
        public static void SeedDb(DbContext context)
        {
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context is CountryDbContext)
                {
                    CountryDbContext _context = context as CountryDbContext;

                    if (_context.Continentals.Count() == 0)
                    {
                        _context.Continentals.AddRange(Continentals);
                    }

                    if (_context.Regions.Count() == 0)
                    {
                        _context.Regions.AddRange(Regions);
                    }

                    if (_context.Countries.Count() == 0)
                    {
                        _context.Countries.AddRange(Countries);
                    }

                    context.SaveChanges();
                }
            }
        }

        private static Continental[] Continentals =
        {
            new Continental() {ID = 1, Name = "Africa", CreatedDate = DateTime.Now,},
            new Continental() {ID = 2, Name = "Americas", CreatedDate = DateTime.Now,},
            new Continental() {ID = 3, Name = "Antarctica", CreatedDate = DateTime.Now,},
            new Continental() {ID = 4, Name = "Asia", CreatedDate = DateTime.Now,},
            new Continental() {ID = 5, Name = "Europe", CreatedDate = DateTime.Now,},
            new Continental() {ID = 6, Name = "Oceania", CreatedDate = DateTime.Now,}
        };

        private static Region[] Regions =
        {
            new Region()
                {ID = 1, Name = "Central Africa", ContinentalId = 1, CreatedDate = DateTime.Now,},
            new Region()
                {ID = 2, Name = "Eastern Africa", ContinentalId = 1, CreatedDate = DateTime.Now,},
            new Region()
                {ID = 3, Name = "Indian Ocean", ContinentalId = 1, CreatedDate = DateTime.Now,},
            new Region()
            {
                ID = 4, Name = "Northern Africa", ContinentalId = 1, CreatedDate = DateTime.Now,
            },
            new Region()
            {
                ID = 5, Name = "Southern Africa", ContinentalId = 1, CreatedDate = DateTime.Now,
            },
            new Region()
                {ID = 6, Name = "Western Africa", ContinentalId = 1, CreatedDate = DateTime.Now,},


            new Region()
            {
                ID = 7, Name = "Central America", ContinentalId = 2, CreatedDate = DateTime.Now,
            },
            new Region()
                {ID = 8, Name = "North America", ContinentalId = 2, CreatedDate = DateTime.Now,},
            new Region()
                {ID = 9, Name = "South America", ContinentalId = 2, CreatedDate = DateTime.Now,},
            new Region()
                {ID = 10, Name = "West Indies", ContinentalId = 2, CreatedDate = DateTime.Now,},


            new Region()
            {
                ID = 11, Name = "Atlantic Ocean", ContinentalId = 3, CreatedDate = DateTime.Now,
            },

            new Region()
                {ID = 12, Name = "Central Asia", ContinentalId = 4, CreatedDate = DateTime.Now,},
            new Region()
                {ID = 13, Name = "East Asia", ContinentalId = 4, CreatedDate = DateTime.Now,},
            new Region()
                {ID = 14, Name = "Northern Asia", ContinentalId = 4, CreatedDate = DateTime.Now,},
            new Region()
                {ID = 15, Name = "South Asia", ContinentalId = 4, CreatedDate = DateTime.Now,},
            new Region()
            {
                ID = 16, Name = "South West Asia", ContinentalId = 4, CreatedDate = DateTime.Now,
            },

            new Region()
            {
                ID = 17, Name = "Central Europe", ContinentalId = 5, CreatedDate = DateTime.Now,
            },
            new Region()
            {
                ID = 18, Name = "Eastern Europe", ContinentalId = 5, CreatedDate = DateTime.Now,
            },
            new Region()
            {
                ID = 19, Name = "Northern Europe", ContinentalId = 5, CreatedDate = DateTime.Now,
            },
            new Region()
            {
                ID = 20, Name = "South East Europe", ContinentalId = 5, CreatedDate = DateTime.Now,
            },
            new Region()
            {
                ID = 21, Name = "South West Europe", ContinentalId = 5, CreatedDate = DateTime.Now,
            },
            new Region()
            {
                ID = 22, Name = "Southern Europe", ContinentalId = 5, CreatedDate = DateTime.Now,
            },
            new Region()
            {
                ID = 23, Name = "Western Europe", ContinentalId = 5, CreatedDate = DateTime.Now,
            },

            new Region()
                {ID = 24, Name = "Pacific", ContinentalId = 6, CreatedDate = DateTime.Now,},
        };

        private static Country[] Countries =
        {
            new Country()
            {
                Name = "Burundi", RegionId = 1, CreatedDate = DateTime.Now, Alpha2Code = "BI", Alpha3Code = "BDI",
                UNCode = 108
            },
            new Country()
            {
                Name = "Chad", RegionId = 1, CreatedDate = DateTime.Now, Alpha2Code = "TD", Alpha3Code = "TCD",
                UNCode = 148
            },
            new Country()
            {
                Name = "Congo, Republic of the", RegionId = 1, CreatedDate = DateTime.Now, Alpha2Code = "CG",
                Alpha3Code = "COG", UNCode = 178
            },
            new Country()
            {
                Name = "Congo, Democratic Republic of the", RegionId = 1, CreatedDate = DateTime.Now, Alpha2Code = "CD",
                Alpha3Code = "COD", UNCode = 180
            },
            new Country()
            {
                Name = "Central African Republic", RegionId = 1, CreatedDate = DateTime.Now, Alpha2Code = "CF",
                Alpha3Code = "CAF", UNCode = 140
            },
            new Country()
            {
                Name = "Rwanda", RegionId = 1, CreatedDate = DateTime.Now, Alpha2Code = "RW", Alpha3Code = "RWA",
                UNCode = 646
            },


            new Country()
            {
                Name = "Djibouti", RegionId = 2, CreatedDate = DateTime.Now, Alpha2Code = "DJ", Alpha3Code = "DJI",
                UNCode = 262
            },
            new Country()
            {
                Name = "Eritrea", RegionId = 2, CreatedDate = DateTime.Now, Alpha2Code = "ER", Alpha3Code = "ERI",
                UNCode = 232
            },
            new Country()
            {
                Name = "Ethiopia", RegionId = 2, CreatedDate = DateTime.Now, Alpha2Code = "ET", Alpha3Code = "ETH",
                UNCode = 231
            },
            new Country()
            {
                Name = "Kenya", RegionId = 2, CreatedDate = DateTime.Now, Alpha2Code = "KE", Alpha3Code = "KEN",
                UNCode = 404
            },
            new Country()
            {
                Name = "Somalia", RegionId = 2, CreatedDate = DateTime.Now, Alpha2Code = "SO", Alpha3Code = "SOM",
                UNCode = 706
            },
            new Country()
            {
                Name = "South Sudan", RegionId = 2, CreatedDate = DateTime.Now, Alpha2Code = "SS", Alpha3Code = "SSD",
                UNCode = 728
            },
            new Country()
            {
                Name = "Tanzania, United Republic of", RegionId = 2, CreatedDate = DateTime.Now, Alpha2Code = "TZ",
                Alpha3Code = "TZA", UNCode = 834
            },
            new Country()
            {
                Name = "Uganda", RegionId = 2, CreatedDate = DateTime.Now, Alpha2Code = "UG", Alpha3Code = "UGA",
                UNCode = 800
            },


            new Country()
            {
                Name = "Comoros", RegionId = 3, CreatedDate = DateTime.Now, Alpha2Code = "KM", Alpha3Code = "COM",
                UNCode = 174
            },
            new Country()
            {
                Name = "Madagascar", RegionId = 3, CreatedDate = DateTime.Now, Alpha2Code = "MG", Alpha3Code = "MDG",
                UNCode = 450
            },
            new Country()
            {
                Name = "Mayotte", RegionId = 3, CreatedDate = DateTime.Now, Alpha2Code = "YT", Alpha3Code = "MYT",
                UNCode = 175
            },
            new Country()
            {
                Name = "Mauritius", RegionId = 3, CreatedDate = DateTime.Now, Alpha2Code = "MU", Alpha3Code = "MUS",
                UNCode = 480
            },
            new Country()
            {
                Name = "Réunion", RegionId = 3, CreatedDate = DateTime.Now, Alpha2Code = "RE", Alpha3Code = "REU",
                UNCode = 638
            },
            new Country()
            {
                Name = "Seychelles", RegionId = 3, CreatedDate = DateTime.Now, Alpha2Code = "SC", Alpha3Code = "SYC",
                UNCode = 690
            },


            new Country()
            {
                Name = "Algeria", RegionId = 4, CreatedDate = DateTime.Now, Alpha2Code = "DZ", Alpha3Code = "DZA",
                UNCode = 012
            },
            new Country()
            {
                Name = "Egypt", RegionId = 4, CreatedDate = DateTime.Now, Alpha2Code = "EG", Alpha3Code = "EGY",
                UNCode = 818
            },
            new Country()
            {
                Name = "Libya", RegionId = 4, CreatedDate = DateTime.Now, Alpha2Code = "LY", Alpha3Code = "LBY",
                UNCode = 434
            },
            new Country()
            {
                Name = "Morocco", RegionId = 4, CreatedDate = DateTime.Now, Alpha2Code = "MA", Alpha3Code = "MAR",
                UNCode = 504
            },
            new Country()
            {
                Name = "Sudan", RegionId = 4, CreatedDate = DateTime.Now, Alpha2Code = "SD", Alpha3Code = "SDN",
                UNCode = 736
            },
            new Country()
            {
                Name = "Tunisia", RegionId = 4, CreatedDate = DateTime.Now, Alpha2Code = "TN", Alpha3Code = "TUN",
                UNCode = 788
            },
            new Country()
            {
                Name = "Western Sahara", RegionId = 4, CreatedDate = DateTime.Now, Alpha2Code = "EH",
                Alpha3Code = "ESH", UNCode = 732
            },


            new Country()
            {
                Name = "Angola", RegionId = 5, CreatedDate = DateTime.Now, Alpha2Code = "AO", Alpha3Code = "AGO",
                UNCode = 024
            },
            new Country()
            {
                Name = "Botswana", RegionId = 5, CreatedDate = DateTime.Now, Alpha2Code = "BW", Alpha3Code = "BWA",
                UNCode = 072
            },
            new Country()
            {
                Name = "Lesotho", RegionId = 5, CreatedDate = DateTime.Now, Alpha2Code = "LS", Alpha3Code = "LSO",
                UNCode = 426
            },
            new Country()
            {
                Name = "Malawi", RegionId = 5, CreatedDate = DateTime.Now, Alpha2Code = "MW", Alpha3Code = "MWI",
                UNCode = 454
            },
            new Country()
            {
                Name = "Mozambique", RegionId = 5, CreatedDate = DateTime.Now, Alpha2Code = "MZ", Alpha3Code = "MOZ",
                UNCode = 508
            },
            new Country()
            {
                Name = "South Africa", RegionId = 5, CreatedDate = DateTime.Now, Alpha2Code = "ZA", Alpha3Code = "ZAF",
                UNCode = 710
            },
            new Country()
            {
                Name = "Namibia", RegionId = 5, CreatedDate = DateTime.Now, Alpha2Code = "NA", Alpha3Code = "NAM",
                UNCode = 516
            },
            new Country()
            {
                Name = "Swaziland", RegionId = 5, CreatedDate = DateTime.Now, Alpha2Code = "SZ", Alpha3Code = "SWZ",
                UNCode = 748
            },
            new Country()
            {
                Name = "Zambia", RegionId = 5, CreatedDate = DateTime.Now, Alpha2Code = "ZM", Alpha3Code = "ZMB",
                UNCode = 894
            },
            new Country()
            {
                Name = "Zimbabwe", RegionId = 5, CreatedDate = DateTime.Now, Alpha2Code = "ZW", Alpha3Code = "ZWE",
                UNCode = 716
            },


            new Country()
            {
                Name = "Benin", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "BJ", Alpha3Code = "BEN",
                UNCode = 204
            },
            new Country()
            {
                Name = "Cameroon", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "CM", Alpha3Code = "CMR",
                UNCode = 120
            },
            new Country()
            {
                Name = "Cape Verde", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "CV", Alpha3Code = "CPV",
                UNCode = 132
            },
            new Country()
            {
                Name = "Equatorial Guinea", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "GQ",
                Alpha3Code = "GNQ", UNCode = 226
            },
            new Country()
            {
                Name = "Gambia, The", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "GM", Alpha3Code = "GMB",
                UNCode = 270
            },
            new Country()
            {
                Name = "Gabon", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "GA", Alpha3Code = "GAB",
                UNCode = 266
            },
            new Country()
            {
                Name = "Ghana", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "GH", Alpha3Code = "GHA",
                UNCode = 288
            },
            new Country()
            {
                Name = "Guinea", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "GN", Alpha3Code = "GIN",
                UNCode = 324
            },
            new Country()
            {
                Name = "Cote d'Ivoire", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "CI", Alpha3Code = "CIV",
                UNCode = 384
            },
            new Country()
            {
                Name = "Liberia", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "LR", Alpha3Code = "LBR",
                UNCode = 430
            },
            new Country()
            {
                Name = "Mali", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "ML", Alpha3Code = "MLI",
                UNCode = 466
            },
            new Country()
            {
                Name = "Mauritania", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "MR", Alpha3Code = "MRT",
                UNCode = 478
            },
            new Country()
            {
                Name = "Niger", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "NE", Alpha3Code = "NER",
                UNCode = 562
            },
            new Country()
            {
                Name = "Nigeria", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "NG", Alpha3Code = "NGA",
                UNCode = 566
            },
            new Country()
            {
                Name = "Guinea-Bissau", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "GW", Alpha3Code = "GNB",
                UNCode = 624
            },
            new Country()
            {
                Name = "Senegal", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "SN", Alpha3Code = "SEN",
                UNCode = 686
            },
            new Country()
            {
                Name = "Sierra Leone", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "SL", Alpha3Code = "SLE",
                UNCode = 694
            },
            new Country()
            {
                Name = "Togo", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "TG", Alpha3Code = "TGO",
                UNCode = 768
            },
            new Country()
            {
                Name = "Sao Tome and Principe", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "ST",
                Alpha3Code = "STP", UNCode = 678
            },
            new Country()
            {
                Name = "Burkina Faso", RegionId = 6, CreatedDate = DateTime.Now, Alpha2Code = "BF", Alpha3Code = "BFA",
                UNCode = 854
            },


            new Country()
            {
                Name = "Belize", RegionId = 7, CreatedDate = DateTime.Now, Alpha2Code = "BZ", Alpha3Code = "BLZ",
                UNCode = 084
            },
            new Country()
            {
                Name = "Costa Rica", RegionId = 7, CreatedDate = DateTime.Now, Alpha2Code = "CR", Alpha3Code = "CRI",
                UNCode = 188
            },
            new Country()
            {
                Name = "El Salvador", RegionId = 7, CreatedDate = DateTime.Now, Alpha2Code = "SV", Alpha3Code = "SLV",
                UNCode = 222
            },
            new Country()
            {
                Name = "Guatemala", RegionId = 7, CreatedDate = DateTime.Now, Alpha2Code = "GT", Alpha3Code = "GTM",
                UNCode = 320
            },
            new Country()
            {
                Name = "Honduras", RegionId = 7, CreatedDate = DateTime.Now, Alpha2Code = "HN", Alpha3Code = "HND",
                UNCode = 340
            },
            new Country()
            {
                Name = "Mexico", RegionId = 7, CreatedDate = DateTime.Now, Alpha2Code = "MX", Alpha3Code = "MEX",
                UNCode = 484
            },
            new Country()
            {
                Name = "Nicaragua", RegionId = 7, CreatedDate = DateTime.Now, Alpha2Code = "NI", Alpha3Code = "NIC",
                UNCode = 558
            },
            new Country()
            {
                Name = "Panama", RegionId = 7, CreatedDate = DateTime.Now, Alpha2Code = "PA", Alpha3Code = "PAN",
                UNCode = 591
            },


            new Country()
            {
                Name = "Canada", RegionId = 8, CreatedDate = DateTime.Now, Alpha2Code = "CA", Alpha3Code = "CAN",
                UNCode = 124
            },
            new Country()
            {
                Name = "Greenland", RegionId = 8, CreatedDate = DateTime.Now, Alpha2Code = "GL", Alpha3Code = "GRL",
                UNCode = 304
            },
            new Country()
            {
                Name = "Saint Pierre and Miquelon", RegionId = 8, CreatedDate = DateTime.Now, Alpha2Code = "PM",
                Alpha3Code = "SPM", UNCode = 666
            },
            new Country()
            {
                Name = "United States of America", RegionId = 8, CreatedDate = DateTime.Now, Alpha2Code = "US",
                Alpha3Code = "USA", UNCode = 840
            },


            new Country()
            {
                Name = "Argentina", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "AR", Alpha3Code = "ARG",
                UNCode = 032
            },
            new Country()
            {
                Name = "Bolivia", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "BO", Alpha3Code = "BOL",
                UNCode = 068
            },
            new Country()
            {
                Name = "Brazil", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "BR", Alpha3Code = "BRA",
                UNCode = 076
            },
            new Country()
            {
                Name = "Chile", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "CL", Alpha3Code = "CHL",
                UNCode = 152
            },
            new Country()
            {
                Name = "Colombia", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "CO", Alpha3Code = "COL",
                UNCode = 170
            },
            new Country()
            {
                Name = "Ecuador", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "EC", Alpha3Code = "ECU",
                UNCode = 218
            },
            new Country()
            {
                Name = "French Guiana", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "GF", Alpha3Code = "GUF",
                UNCode = 254
            },
            new Country()
            {
                Name = "Falkland Islands (Islas Malvinas)", RegionId = 9, CreatedDate = DateTime.Now,
                Alpha2Code = "FK", Alpha3Code = "FLK", UNCode = 238
            },
            new Country()
            {
                Name = "Guyana", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "GY", Alpha3Code = "GUY",
                UNCode = 328
            },
            new Country()
            {
                Name = "Suriname", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "SR", Alpha3Code = "SUR",
                UNCode = 740
            },
            new Country()
            {
                Name = "Paraguay", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "PY", Alpha3Code = "PRY",
                UNCode = 600
            },
            new Country()
            {
                Name = "Peru", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "PE", Alpha3Code = "PER",
                UNCode = 604
            },
            new Country()
            {
                Name = "Uruguay", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "UY", Alpha3Code = "URY",
                UNCode = 858
            },
            new Country()
            {
                Name = "Venezuela (Bolivarian Republic)", RegionId = 9, CreatedDate = DateTime.Now, Alpha2Code = "VE",
                Alpha3Code = "VEN", UNCode = 862
            },


            new Country()
            {
                Name = "Aruba", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "AW", Alpha3Code = "ABW",
                UNCode = 533
            },
            new Country()
            {
                Name = "Antigua and Barbuda", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "AG",
                Alpha3Code = "ATG", UNCode = 028
            },
            new Country()
            {
                Name = "Anguilla", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "AI", Alpha3Code = "AIA",
                UNCode = 660
            },
            new Country()
            {
                Name = "Barbados", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "BB", Alpha3Code = "BRB",
                UNCode = 052
            },
            new Country()
            {
                Name = "Bermuda", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "BM", Alpha3Code = "BMU",
                UNCode = 060
            },
            new Country()
            {
                Name = "Bahamas, The", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "BS", Alpha3Code = "BHS",
                UNCode = 044
            },
            new Country()
            {
                Name = "Cayman Islands", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "KY",
                Alpha3Code = "CYM", UNCode = 136
            },
            new Country()
            {
                Name = "Cuba", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "CU", Alpha3Code = "CUB",
                UNCode = 192
            },
            new Country()
            {
                Name = "Dominica", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "DM", Alpha3Code = "DMA",
                UNCode = 212
            },
            new Country()
            {
                Name = "Dominican Republic", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "DO",
                Alpha3Code = "DOM", UNCode = 214
            },
            new Country()
            {
                Name = "Grenada", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "GD", Alpha3Code = "GRD",
                UNCode = 308
            },
            new Country()
            {
                Name = "Guadeloupe", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "GP", Alpha3Code = "GLP",
                UNCode = 312
            },
            new Country()
            {
                Name = "Haiti", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "HT", Alpha3Code = "HTI",
                UNCode = 332
            },
            new Country()
            {
                Name = "Jamaica", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "JM", Alpha3Code = "JAM",
                UNCode = 388
            },
            new Country()
            {
                Name = "Martinique", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "MQ", Alpha3Code = "MTQ",
                UNCode = 474
            },
            new Country()
            {
                Name = "Montserrat", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "MS", Alpha3Code = "MSR",
                UNCode = 500
            },
            new Country()
            {
                Name = "Saint-Martin (French part)", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "MF",
                Alpha3Code = "MAF", UNCode = 663
            },
            new Country()
            {
                Name = "Saint Kitts and Nevis", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "KN",
                Alpha3Code = "KNA", UNCode = 659
            },
            new Country()
            {
                Name = "Saint Lucia", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "LC", Alpha3Code = "LCA",
                UNCode = 662
            },
            new Country()
            {
                Name = "Trinidad and Tobago", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "TT",
                Alpha3Code = "TTO", UNCode = 780
            },
            new Country()
            {
                Name = "Turks and Caicos Islands", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "TC",
                Alpha3Code = "TCA", UNCode = 796
            },
            new Country()
            {
                Name = "Saint Vincent and the Grenadines", RegionId = 10, CreatedDate = DateTime.Now,
                Alpha2Code = "VC", Alpha3Code = "VCT", UNCode = 670
            },
            new Country()
            {
                Name = "British Virgin Islands", RegionId = 10, CreatedDate = DateTime.Now, Alpha2Code = "VG",
                Alpha3Code = "VGB", UNCode = 092
            },


            new Country()
            {
                Name = "Saint Helena", RegionId = 11, CreatedDate = DateTime.Now, Alpha2Code = "SH", Alpha3Code = "SHN",
                UNCode = 654
            },
            new Country()
            {
                Name = "South Georgia and the South Sandwich Islands", RegionId = 11, CreatedDate = DateTime.Now,
                Alpha2Code = "GS", Alpha3Code = "SGS", UNCode = 239
            },


            new Country()
            {
                Name = "Kyrgyzstan", RegionId = 12, CreatedDate = DateTime.Now, Alpha2Code = "KG", Alpha3Code = "KGZ",
                UNCode = 417
            },
            new Country()
            {
                Name = "Kazakhstan", RegionId = 12, CreatedDate = DateTime.Now, Alpha2Code = "KZ", Alpha3Code = "KAZ",
                UNCode = 398
            },
            new Country()
            {
                Name = "Tajikistan", RegionId = 12, CreatedDate = DateTime.Now, Alpha2Code = "TJ", Alpha3Code = "TJK",
                UNCode = 762
            },
            new Country()
            {
                Name = "Turkmenistan", RegionId = 12, CreatedDate = DateTime.Now, Alpha2Code = "TM", Alpha3Code = "TKM",
                UNCode = 795
            },
            new Country()
            {
                Name = "Uzbekistan", RegionId = 12, CreatedDate = DateTime.Now, Alpha2Code = "UZ", Alpha3Code = "UZB",
                UNCode = 860
            },


            new Country()
            {
                Name = "China", RegionId = 13, CreatedDate = DateTime.Now, Alpha2Code = "CN", Alpha3Code = "CHN",
                UNCode = 156
            },
            new Country()
            {
                Name = "Hong Kong, SAR China", RegionId = 13, CreatedDate = DateTime.Now, Alpha2Code = "HK",
                Alpha3Code = "HKG", UNCode = 344
            },
            new Country()
            {
                Name = "Japan", RegionId = 13, CreatedDate = DateTime.Now, Alpha2Code = "JP", Alpha3Code = "JPN",
                UNCode = 392
            },
            new Country()
            {
                Name = "Korea, North", RegionId = 13, CreatedDate = DateTime.Now, Alpha2Code = "KP", Alpha3Code = "PRK",
                UNCode = 408
            },
            new Country()
            {
                Name = "Korea, South", RegionId = 13, CreatedDate = DateTime.Now, Alpha2Code = "KR", Alpha3Code = "KOR",
                UNCode = 410
            },
            new Country()
            {
                Name = "Macao, SAR China", RegionId = 13, CreatedDate = DateTime.Now, Alpha2Code = "MO",
                Alpha3Code = "MAC", UNCode = 446
            },
            new Country()
            {
                Name = "Taiwan, Republic of China", RegionId = 13, CreatedDate = DateTime.Now, Alpha2Code = "TW",
                Alpha3Code = "TWN", UNCode = 158
            },


            new Country()
            {
                Name = "Mongolia", RegionId = 14, CreatedDate = DateTime.Now, Alpha2Code = "MN", Alpha3Code = "MNG",
                UNCode = 496
            },
            new Country()
            {
                Name = "Russian Federation", RegionId = 14, CreatedDate = DateTime.Now, Alpha2Code = "RU",
                Alpha3Code = "RUS", UNCode = 643
            },


            new Country()
            {
                Name = "Afghanistan", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "AF", Alpha3Code = "AFG",
                UNCode = 004
            },
            new Country()
            {
                Name = "Bangladesh", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "BD", Alpha3Code = "BGD",
                UNCode = 050
            },
            new Country()
            {
                Name = "Bhutan", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "BT", Alpha3Code = "BTN",
                UNCode = 064
            },
            new Country()
            {
                Name = "Sri Lanka", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "LK", Alpha3Code = "LKA",
                UNCode = 144
            },
            new Country()
            {
                Name = "India", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "IN", Alpha3Code = "IND",
                UNCode = 356
            },
            new Country()
            {
                Name = "British Indian Ocean Territory", RegionId = 15, CreatedDate = DateTime.Now,
                Alpha2Code = "IO", Alpha3Code = "IOT", UNCode = 086
            },
            new Country()
            {
                Name = "Maldives", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "MV", Alpha3Code = "MDV",
                UNCode = 462
            },
            new Country()
            {
                Name = "Nepal", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "NP", Alpha3Code = "NPL",
                UNCode = 524
            },
            new Country()
            {
                Name = "Pakistan", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "PK", Alpha3Code = "PAK",
                UNCode = 586
            },


            new Country()
            {
                Name = "Myanmar", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "MM", Alpha3Code = "MMR",
                UNCode = 104
            },
            new Country()
            {
                Name = "Brunei Darussalam", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "BN",
                Alpha3Code = "BRN", UNCode = 096
            },
            new Country()
            {
                Name = "Cambodia", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "KH", Alpha3Code = "KHM",
                UNCode = 116
            },
            new Country()
            {
                Name = "Cocos (Keeling) Islands", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "CC",
                Alpha3Code = "CCK", UNCode = 166
            },
            new Country()
            {
                Name = "Indonesia", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "ID", Alpha3Code = "IDN",
                UNCode = 360
            },
            new Country()
            {
                Name = "Christmas Island", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "CX",
                Alpha3Code = "CXR", UNCode = 162
            },
            new Country()
            {
                Name = "Lao PDR", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "LA", Alpha3Code = "LAO",
                UNCode = 418
            },
            new Country()
            {
                Name = "Malaysia", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "MY", Alpha3Code = "MYS",
                UNCode = 458
            },
            new Country()
            {
                Name = "Philippines", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "PH", Alpha3Code = "PHL",
                UNCode = 608
            },
            new Country()
            {
                Name = "Singapore", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "SG", Alpha3Code = "SGP",
                UNCode = 702
            },
            new Country()
            {
                Name = "Thailand", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "TH", Alpha3Code = "THA",
                UNCode = 764
            },
            new Country()
            {
                Name = "Timor-Leste", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "TL", Alpha3Code = "TLS",
                UNCode = 626
            },
            new Country()
            {
                Name = "Vietnam", RegionId = 15, CreatedDate = DateTime.Now, Alpha2Code = "VN", Alpha3Code = "VNM",
                UNCode = 704
            },


            new Country()
            {
                Name = "United Arab Emirates", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "AE",
                Alpha3Code = "ARE", UNCode = 784
            },
            new Country()
            {
                Name = "Azerbaijan", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "AZ", Alpha3Code = "AZE",
                UNCode = 031
            },
            new Country()
            {
                Name = "Armenia", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "AM", Alpha3Code = "ARM",
                UNCode = 051
            },
            new Country()
            {
                Name = "Bahrain", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "BH", Alpha3Code = "BHR",
                UNCode = 048
            },
            new Country()
            {
                Name = "Cyprus", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "CY", Alpha3Code = "CYP",
                UNCode = 196
            },
            new Country()
            {
                Name = "Georgia", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "GE", Alpha3Code = "GEO",
                UNCode = 268
            },
            new Country()
            {
                Name = "Israel", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "IL", Alpha3Code = "ISR",
                UNCode = 376
            },
            new Country()
            {
                Name = "Iran, Islamic Republic of", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "IR",
                Alpha3Code = "IRN", UNCode = 364
            },
            new Country()
            {
                Name = "Iraq", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "IQ", Alpha3Code = "IRQ",
                UNCode = 368
            },
            new Country()
            {
                Name = "Jordan", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "JO", Alpha3Code = "JOR",
                UNCode = 400
            },
            new Country()
            {
                Name = "Kuwait", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "KW", Alpha3Code = "KWT",
                UNCode = 414
            },
            new Country()
            {
                Name = "Lebanon", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "LB", Alpha3Code = "LBN",
                UNCode = 422
            },
            new Country()
            {
                Name = "Oman", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "OM", Alpha3Code = "OMN",
                UNCode = 512
            },
            new Country()
            {
                Name = "Qatar", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "QA", Alpha3Code = "QAT",
                UNCode = 634
            },
            new Country()
            {
                Name = "Saudi Arabia", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "SA", Alpha3Code = "SAU",
                UNCode = 682
            },
            new Country()
            {
                Name = "Syrian Arab Republic (Syria)", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "SY",
                Alpha3Code = "SYR", UNCode = 760
            },
            new Country()
            {
                Name = "Turkey", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "TR", Alpha3Code = "TUR",
                UNCode = 792
            },
            new Country()
            {
                Name = "Yemen", RegionId = 16, CreatedDate = DateTime.Now, Alpha2Code = "YE", Alpha3Code = "YEM",
                UNCode = 887
            },


            new Country()
            {
                Name = "Austria", RegionId = 17, CreatedDate = DateTime.Now, Alpha2Code = "AT", Alpha3Code = "AUT",
                UNCode = 040
            },
            new Country()
            {
                Name = "Czech Republic", RegionId = 17, CreatedDate = DateTime.Now, Alpha2Code = "CZ",
                Alpha3Code = "CZE", UNCode = 203
            },
            new Country()
            {
                Name = "Hungary", RegionId = 17, CreatedDate = DateTime.Now, Alpha2Code = "HU", Alpha3Code = "HUN",
                UNCode = 348
            },
            new Country()
            {
                Name = "Slovakia", RegionId = 17, CreatedDate = DateTime.Now, Alpha2Code = "SK", Alpha3Code = "SVK",
                UNCode = 703
            },
            new Country()
            {
                Name = "Liechtenstein", RegionId = 17, CreatedDate = DateTime.Now, Alpha2Code = "LI",
                Alpha3Code = "LIE", UNCode = 438
            },
            new Country()
            {
                Name = "Switzerland", RegionId = 17, CreatedDate = DateTime.Now, Alpha2Code = "CH", Alpha3Code = "CHE",
                UNCode = 756
            },


            new Country()
            {
                Name = "Belarus", RegionId = 18, CreatedDate = DateTime.Now, Alpha2Code = "BY", Alpha3Code = "BLR",
                UNCode = 112
            },
            new Country()
            {
                Name = "Estonia", RegionId = 18, CreatedDate = DateTime.Now, Alpha2Code = "EE", Alpha3Code = "EST",
                UNCode = 233
            },
            new Country()
            {
                Name = "Latvia", RegionId = 18, CreatedDate = DateTime.Now, Alpha2Code = "LV", Alpha3Code = "LVA",
                UNCode = 428
            },
            new Country()
            {
                Name = "Lithuania", RegionId = 18, CreatedDate = DateTime.Now, Alpha2Code = "LT", Alpha3Code = "LTU",
                UNCode = 440
            },
            new Country()
            {
                Name = "Moldova, Republic of", RegionId = 18, CreatedDate = DateTime.Now, Alpha2Code = "MD",
                Alpha3Code = "MDA", UNCode = 498
            },
            new Country()
            {
                Name = "Poland", RegionId = 18, CreatedDate = DateTime.Now, Alpha2Code = "PL", Alpha3Code = "POL",
                UNCode = 616
            },
            new Country()
            {
                Name = "Ukraine", RegionId = 18, CreatedDate = DateTime.Now, Alpha2Code = "UA", Alpha3Code = "UKR",
                UNCode = 804
            },


            new Country()
            {
                Name = "Åland Islands", RegionId = 19, CreatedDate = DateTime.Now, Alpha2Code = "AX",
                Alpha3Code = "ALA", UNCode = 248
            },
            new Country()
            {
                Name = "Denmark", RegionId = 19, CreatedDate = DateTime.Now, Alpha2Code = "DK", Alpha3Code = "DNK",
                UNCode = 208
            },
            new Country()
            {
                Name = "Finland", RegionId = 19, CreatedDate = DateTime.Now, Alpha2Code = "FI", Alpha3Code = "FIN",
                UNCode = 246
            },
            new Country()
            {
                Name = "Faroe Islands", RegionId = 19, CreatedDate = DateTime.Now, Alpha2Code = "FO",
                Alpha3Code = "FRO", UNCode = 234
            },
            new Country()
            {
                Name = "Iceland", RegionId = 19, CreatedDate = DateTime.Now, Alpha2Code = "IS", Alpha3Code = "ISL",
                UNCode = 352
            },
            new Country()
            {
                Name = "Svalbard and Jan Mayen Islands", RegionId = 19, CreatedDate = DateTime.Now, Alpha2Code = "SJ",
                Alpha3Code = "SJM", UNCode = 744
            },
            new Country()
            {
                Name = "Norway", RegionId = 19, CreatedDate = DateTime.Now, Alpha2Code = "NO", Alpha3Code = "NOR",
                UNCode = 578
            },
            new Country()
            {
                Name = "Sweden", RegionId = 19, CreatedDate = DateTime.Now, Alpha2Code = "SE", Alpha3Code = "SWE",
                UNCode = 752
            },


            new Country()
            {
                Name = "Albania", RegionId = 20, CreatedDate = DateTime.Now, Alpha2Code = "AL", Alpha3Code = "ALB",
                UNCode = 008
            },
            new Country()
            {
                Name = "Bosnia and Herzegovina", RegionId = 20, CreatedDate = DateTime.Now, Alpha2Code = "BA",
                Alpha3Code = "BIH", UNCode = 070
            },
            new Country()
            {
                Name = "Bulgaria", RegionId = 20, CreatedDate = DateTime.Now, Alpha2Code = "BG", Alpha3Code = "BGR",
                UNCode = 100
            },
            new Country()
            {
                Name = "Greece", RegionId = 20, CreatedDate = DateTime.Now, Alpha2Code = "GR", Alpha3Code = "GRC",
                UNCode = 300
            },
            new Country()
            {
                Name = "Croatia", RegionId = 20, CreatedDate = DateTime.Now, Alpha2Code = "HR", Alpha3Code = "HRV",
                UNCode = 191
            },
            new Country()
            {
                Name = "Kosovo", RegionId = 20, CreatedDate = DateTime.Now, Alpha2Code = "XK", Alpha3Code = "XKX",
                UNCode = 383
            },
            new Country()
            {
                Name = "Montenegro", RegionId = 20, CreatedDate = DateTime.Now, Alpha2Code = "ME", Alpha3Code = "MNE",
                UNCode = 499
            },
            new Country()
            {
                Name = "Macedonia, Republic of", RegionId = 20, CreatedDate = DateTime.Now,
                Alpha2Code = "MK", Alpha3Code = "MKD", UNCode = 807
            },
            new Country()
            {
                Name = "Serbia", RegionId = 20, CreatedDate = DateTime.Now, Alpha2Code = "RS", Alpha3Code = "SRB",
                UNCode = 688
            },
            new Country()
            {
                Name = "Romania", RegionId = 20, CreatedDate = DateTime.Now, Alpha2Code = "RO", Alpha3Code = "ROU",
                UNCode = 642
            },
            new Country()
            {
                Name = "Slovenia", RegionId = 20, CreatedDate = DateTime.Now, Alpha2Code = "SI", Alpha3Code = "SVN",
                UNCode = 705
            },


            new Country()
            {
                Name = "Andorra", RegionId = 21, CreatedDate = DateTime.Now, Alpha2Code = "AD", Alpha3Code = "AND",
                UNCode = 020
            },
            new Country()
            {
                Name = "Gibraltar", RegionId = 21, CreatedDate = DateTime.Now, Alpha2Code = "GI", Alpha3Code = "GIB",
                UNCode = 292
            },
            new Country()
            {
                Name = "Portugal", RegionId = 21, CreatedDate = DateTime.Now, Alpha2Code = "PT", Alpha3Code = "PRT",
                UNCode = 620
            },
            new Country()
            {
                Name = "Spain", RegionId = 21, CreatedDate = DateTime.Now, Alpha2Code = "ES", Alpha3Code = "ESP",
                UNCode = 724
            },


            new Country()
            {
                Name = "Italy", RegionId = 22, CreatedDate = DateTime.Now, Alpha2Code = "IT", Alpha3Code = "ITA",
                UNCode = 380
            },
            new Country()
            {
                Name = "Malta", RegionId = 22, CreatedDate = DateTime.Now, Alpha2Code = "MT", Alpha3Code = "MLT",
                UNCode = 470
            },
            new Country()
            {
                Name = "San Marino", RegionId = 22, CreatedDate = DateTime.Now, Alpha2Code = "SM", Alpha3Code = "SMR",
                UNCode = 674
            },


            new Country()
            {
                Name = "Belgium", RegionId = 23, CreatedDate = DateTime.Now, Alpha2Code = "BE", Alpha3Code = "BEL",
                UNCode = 056
            },
            new Country()
            {
                Name = "Ireland", RegionId = 23, CreatedDate = DateTime.Now, Alpha2Code = "IE", Alpha3Code = "IRL",
                UNCode = 372
            },
            new Country()
            {
                Name = "France", RegionId = 23, CreatedDate = DateTime.Now, Alpha2Code = "FR", Alpha3Code = "FRA",
                UNCode = 250
            },
            new Country()
            {
                Name = "United Kingdom", RegionId = 23, CreatedDate = DateTime.Now, Alpha2Code = "GB",
                Alpha3Code = "GBR", UNCode = 826
            },
            new Country()
            {
                Name = "Germany", RegionId = 23, CreatedDate = DateTime.Now, Alpha2Code = "DE", Alpha3Code = "DEU",
                UNCode = 276
            },
            new Country()
            {
                Name = "Isle of Man", RegionId = 23, CreatedDate = DateTime.Now, Alpha2Code = "IM", Alpha3Code = "IMN",
                UNCode = 833
            },
            new Country()
            {
                Name = "Jersey", RegionId = 23, CreatedDate = DateTime.Now, Alpha2Code = "JE", Alpha3Code = "JEY",
                UNCode = 832
            },
            new Country()
            {
                Name = "Luxembourg", RegionId = 23, CreatedDate = DateTime.Now, Alpha2Code = "LU", Alpha3Code = "LUX",
                UNCode = 442
            },
            new Country()
            {
                Name = "Monaco", RegionId = 23, CreatedDate = DateTime.Now, Alpha2Code = "MC", Alpha3Code = "MCO",
                UNCode = 492
            },
            new Country()
            {
                Name = "Netherlands", RegionId = 23, CreatedDate = DateTime.Now, Alpha2Code = "NL", Alpha3Code = "NLD",
                UNCode = 528
            },


            new Country()
            {
                Name = "Australia", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "AU", Alpha3Code = "AUS",
                UNCode = 036
            },
            new Country()
            {
                Name = "Solomon Islands", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "SB",
                Alpha3Code = "SLB", UNCode = 090
            },
            new Country()
            {
                Name = "Cook Islands", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "CK", Alpha3Code = "COK",
                UNCode = 184
            },
            new Country()
            {
                Name = "Fiji", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "FJ", Alpha3Code = "FJI",
                UNCode = 242
            },
            new Country()
            {
                Name = "Micronesia, Federated States of", RegionId = 24, CreatedDate = DateTime.Now,
                Alpha2Code = "FM", Alpha3Code = "FSM", UNCode = 583
            },
            new Country()
            {
                Name = "French Polynesia", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "PF",
                Alpha3Code = "PYF", UNCode = 258
            },
            new Country()
            {
                Name = "Kiribati", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "KI", Alpha3Code = "KIR",
                UNCode = 296
            },
            new Country()
            {
                Name = "New Caledonia", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "NC",
                Alpha3Code = "NCL", UNCode = 540
            },
            new Country()
            {
                Name = "Niue", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "NU", Alpha3Code = "NIU",
                UNCode = 570
            },
            new Country()
            {
                Name = "Norfolk Island", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "NF",
                Alpha3Code = "NFK", UNCode = 574
            },
            new Country()
            {
                Name = "Vanuatu", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "VU", Alpha3Code = "VUT",
                UNCode = 548
            },
            new Country()
            {
                Name = "Nauru", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "NR", Alpha3Code = "NRU",
                UNCode = 520
            },
            new Country()
            {
                Name = "New Zealand", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "NZ", Alpha3Code = "NZL",
                UNCode = 554
            },
            new Country()
            {
                Name = "Pitcairn Islands", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "PN",
                Alpha3Code = "PCN", UNCode = 612
            },
            new Country()
            {
                Name = "Papua New Guinea", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "PG",
                Alpha3Code = "PNG", UNCode = 598
            },
            new Country()
            {
                Name = "Palau", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "PW", Alpha3Code = "PLW",
                UNCode = 585
            },
            new Country()
            {
                Name = "Marshall Islands", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "MH",
                Alpha3Code = "MHL", UNCode = 584
            },
            new Country()
            {
                Name = "Tokelau", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "TK", Alpha3Code = "TKL",
                UNCode = 772
            },
            new Country()
            {
                Name = "Tonga", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "TO", Alpha3Code = "TON",
                UNCode = 776
            },
            new Country()
            {
                Name = "Tuvalu", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "TV", Alpha3Code = "TUV",
                UNCode = 798
            },
            new Country()
            {
                Name = "Wallis and Futuna Islands", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "WF",
                Alpha3Code = "WLF", UNCode = 876
            },
            new Country()
            {
                Name = "Samoa", RegionId = 24, CreatedDate = DateTime.Now, Alpha2Code = "WS", Alpha3Code = "WSM",
                UNCode = 882
            },
        };
    }
}