#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TermixListing.API.Data;
using TermixListing.API.Models.Country;
using AutoMapper;
using TermixListing.API.Contracts;

namespace TermixListing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        //private readonly termixListViewContext _context;
        private readonly IMapper _mapper;
        private readonly ICountriesRepository _countriesRepository;

        //public CountriesController(termixListViewContext context,IMapper mapper)
        public CountriesController(IMapper mapper, ICountriesRepository countriesRepository)

        {
            //_context = context;
            this._mapper = mapper;
            this._countriesRepository = countriesRepository;
        }

        // GET: api/Countries
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Country>>> GetCountries()
        public async Task<ActionResult<IEnumerable<GetCountryDto>>> GetCountries()

        {
            //select * from Countries
            var countries = await _countriesRepository.GetAllAsync();
            //
            var records = _mapper.Map<List<GetCountryDto>>(countries);
            //return Ok(countries);
            return Ok(records);
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetCountryDetailsDto>> GetCountry(int id)
        {
            //var country = await _context.Countries.FindAsync(id);
            var country = await _countriesRepository.GetDetails(id);


            if (country == null)
            {
                return NotFound();
            }

            var countryDto  = _mapper.Map<GetCountryDetailsDto>(country);

            //return Ok(country);
            return Ok(countryDto);
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        //public async Task<IActionResult> PutCountry(int id, Country country)
        public async Task<IActionResult> PutCountry(int id, UpdateCountryDto updateCountryDto)

        {
            //if (id != country.Id)
            if (id != updateCountryDto.Id)

            {
                return BadRequest();
            }

            //_context.Entry(country).State = EntityState.Modified;

            var country = await _countriesRepository.GetAsync(id);
            if (country == null)
            {
                return NotFound();
            }
            _mapper.Map(updateCountryDto, country);


            try
            {
                await _countriesRepository.UpdateAsync(country);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CountryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(CreateCountryDto CreateCountryDto)
        {
            //var country = new Country
            //{
            //    Name = CreateCountryDto.Name,
            //    ShortName = CreateCountryDto.ShortName
            //};

            var country = _mapper.Map<Country>(CreateCountryDto);
            await _countriesRepository.AddAsync(country);
            //await _countriesRepository.UpdateAsync(country);

            return CreatedAtAction("GetCountry", new { id = country.Id }, country);
        }

        
        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var country = await _countriesRepository.GetAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            await _countriesRepository.DeleteAsync(id);

            return NoContent();
        }

        private async Task <bool> CountryExists(int id)
        {
            //return _context.Countries.Any(e => e.Id == id);
            return await _countriesRepository.Exist(id);
        }
    }
}
