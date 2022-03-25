using AutoMapper;
using CountryDetails.Data;
using CountryDetails.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CountryDetails.Service
{
    public class CountryDetailService: ICountryDetailService
    {
        private readonly ApiContext _db;
        private readonly IMapper _mapper;

        public CountryDetailService(ApiContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public Response GetCountryDetails(string phoneNumber)
        {
            try
            {
                var response = new Response();
                var countryCode = phoneNumber.Substring(0, 3);
                var country = _db.Countries
                            .Include(d => d.CountryDetails)
                            .Where(x => x.CountryCode == countryCode)
                            .SingleOrDefault();
                if (country!=null)
                {
                    var countrymap = _mapper.Map(country, response.Country);
                    var detailsMap = _mapper.Map(country.CountryDetails, new List<CountryDetailResponse>());

                    countrymap.CountryDetails = detailsMap;

                    response.Number = phoneNumber;
                    response.Country = countrymap;
                    return response;
                }
                else
                {
                    return null;
                }
                
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
    }
}
