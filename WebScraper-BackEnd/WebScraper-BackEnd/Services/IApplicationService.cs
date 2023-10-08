using WebScraper_BackEnd.ViewModels;

namespace WebScraper_BackEnd.Services
{
    public interface IApplicationService
    {
        Task<IEnumerable<SearchResponseViewModel>> GetSearchHistory();
        Task<SearchResponseViewModel> CreateSearchRequest(SearchRequestViewModel request);


    }
}
