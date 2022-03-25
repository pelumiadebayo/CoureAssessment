using CountryDetails.Model;
using System.Collections.Generic;
using System.Linq;

namespace CountryDetails.Data.DataSeed
{
    public class CountryDetailConfiguration
    {
        public static void SeedCountryDetailData(ApiContext db)
        {

            if (!db.CountryDetails.Any())
            {
                var details = new List<CountryDetail> {
                    new CountryDetail
                    {
                        Id = 1,
                        CountryId = 1,
                        Operator = "MTN Nigeria",
                        OperatorCode = "MTN NG"
                    },
                    new CountryDetail
                    {
                        Id = 2,
                        CountryId = 1,
                        Operator = "Airtel Nigeria",
                        OperatorCode = "ANG"
                    },
                    new CountryDetail
                    {
                        Id = 3,
                        CountryId = 1,
                        Operator = "9 Mobile Nigeria",
                        OperatorCode = "ETN"
                    },
                    new CountryDetail
                    {
                        Id = 4,
                        CountryId = 1,
                        Operator = "Globacom Nigeria",
                        OperatorCode = "GLO NG"
                    },
                     new CountryDetail
                     {
                         Id = 5,
                         CountryId = 2,
                         Operator = "Vodafone Ghana",
                         OperatorCode = "Vodafone GH"
                     },
                     new CountryDetail
                     {
                         Id = 6,
                         CountryId = 2,
                         Operator = "MTN Ghana",
                         OperatorCode = "MTN Ghana"
                     },
                     new CountryDetail
                     {
                         Id = 7,
                         CountryId = 2,
                         Operator = "Tigo Ghana",
                         OperatorCode = "Tigo Ghana"
                     },
                     new CountryDetail
                     {
                         Id = 8,
                         CountryId = 3,
                         Operator = "MTN Benin",
                         OperatorCode = "MTN Benin"
                     },
                     new CountryDetail
                     {
                         Id = 9,
                         CountryId = 3,
                         Operator = "Moov Benin",
                         OperatorCode = "Moov Benin"
                     },
                     new CountryDetail
                     {
                         Id = 10,
                         CountryId = 4,
                         Operator = "MTN Cote D'Ivoire",
                         OperatorCode = "MTN CIV"
                     }
                };
                db.CountryDetails.AddRange(details);
                db.SaveChanges();
            }
        }
    }
}
