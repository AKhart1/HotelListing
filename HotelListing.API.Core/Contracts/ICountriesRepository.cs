using HotelListing.API.CoreData;
using HotelListing.API.CoreModels.Country;

namespace HotelListing.API.CoreContracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<CountryDto> GetDetails(int id);
    }
}
