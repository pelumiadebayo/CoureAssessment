using AutoMapper;
using CountryDetails.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountryDetails.DataMap
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Country, CountryResponse>();
            CreateMap<CountryDetail, CountryDetailResponse>();
        }
    }
}
