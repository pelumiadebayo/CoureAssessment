
using CountryDetails.Model;
using CountryDetails.Service;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CountryDetails.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryDetailsController : ControllerBase
    {
        private readonly ICountryDetailService _countryDetailService;
        public CountryDetailsController(ICountryDetailService countryDetailService)
        {
            _countryDetailService = countryDetailService;
        }

        [HttpGet("get-country-details/{phoneNumber}")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Response))]
        public IActionResult GetCountryDetails(string phoneNumber)
        => Ok(_countryDetailService.GetCountryDetails(phoneNumber));
    }
}