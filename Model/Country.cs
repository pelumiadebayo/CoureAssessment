using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CountryDetails.Model
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public ICollection<CountryDetail> CountryDetails { get; set; }

    }
}
