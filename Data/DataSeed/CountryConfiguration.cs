using CountryDetails.Model;
using System.Collections.Generic;
using System.Linq;

namespace CountryDetails.Data.DataSeed
{
    public class CountryConfiguration{
        public static void seedCountryData(ApiContext db)
        {
            if (!db.Countries.Any())
            {
                var countries = new List<Country> {
                   new Country {
                        Id = 1,
                        Name = "Nigeria",
                        CountryCode = "234",
                        CountryIso = "NG"
                    },
                    new Country
                    {
                        Id = 2,
                        Name = "Ghana",
                        CountryCode = "233",
                        CountryIso = "GH"
                    },
                    new Country
                    {
                        Id = 3,
                        Name = "Benin Republic",
                        CountryCode = "229",
                        CountryIso = "BR"
                    },
                    new Country
                    {
                        Id = 4,
                        Name = "Cote D'Ivoire",
                        CountryCode = "225",
                        CountryIso = "CIV"
                    }
                };
                db.Countries.AddRange(countries);
                db.SaveChanges();
            }
        } 
    }
}
