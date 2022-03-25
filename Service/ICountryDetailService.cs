
using CountryDetails.Model;
using System.Collections.Generic;

namespace CountryDetails.Service
{
    public interface ICountryDetailService
    {
        Response GetCountryDetails(string phoneNumber);
    }
}
