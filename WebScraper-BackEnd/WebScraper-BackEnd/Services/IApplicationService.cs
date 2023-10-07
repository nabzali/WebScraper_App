using WebScraper_BackEnd.Models;

namespace WebScraper_BackEnd.Services
{
    public interface IApplicationService
    {
        Task<IEnumerable<SearchResponseModel>> GetSearchHistory();
        Task<SearchResponseModel> CreateSearchRequest(SearchRequestModel request);


    }
}
