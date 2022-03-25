using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryDetails.Model
{
    public class Response
    {
        public string Number { get; set; }
        public CountryResponse Country { get; set; }
    }

    public class CountryResponse
    {
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public List<CountryDetailResponse> CountryDetails { get; set; }
    }

    public class CountryDetailResponse
    {
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}
