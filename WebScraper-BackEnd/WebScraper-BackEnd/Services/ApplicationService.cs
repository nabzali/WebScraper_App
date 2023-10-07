using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.RegularExpressions;
using TakeHomeAssessment_BindySt.DbContexts;
using WebScraper_BackEnd.Entities;
using WebScraper_BackEnd.Models;
using static System.Net.WebRequestMethods;

namespace WebScraper_BackEnd.Services
{
    public class ApplicationService : IApplicationService
    {
        private const int resultLimit = 100;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public ApplicationService(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<IEnumerable<SearchResponseModel>> GetSearchHistory()
        {
            var searchHistory = await _context.Searches
                .ProjectTo<SearchResponseModel>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return searchHistory;
        }

        public async Task<SearchResponseModel> CreateSearchRequest(SearchRequestModel requestModel)
        {
            var occurrences = await this.Search(requestModel.Url, requestModel.SearchTerms);

            var resultModel = new SearchResponseModel()
            {
                SearchTerms = requestModel.SearchTerms,
                Occurrences = occurrences,
                Timestamp = DateTime.Now,
                Url = requestModel.Url
            };

            var resultEntity = _mapper.Map<SearchEntity>(resultModel);


            //Update Database
            //Try block
            _context.Add(resultEntity);

            await _context.SaveChangesAsync();

            return resultModel;
        }

        private async Task<List<int>> Search(string Url, string searchTerms)
        {
            searchTerms = searchTerms.Trim().Replace(" ", "+");

            WebClient webClient = new WebClient();

            // Set the WebClient object's Headers property to a new WebHeaderCollection object.
            webClient.Headers = new WebHeaderCollection();

            // Add the following header to the WebHeaderCollection object:
            webClient.Headers.Add("Accept", "text/html");

            var htmlContent = "";
            try
            {
                htmlContent = await Task.Run(() => webClient.DownloadString($"https://www.google.com/search?num={resultLimit}&q={searchTerms}"));
            }
            catch (Exception ex)
            {
                // Throw 500 response, error trying to download search data
            }
            

            // Regex pattern to find webpage links
            string pattern = @"href\s*=\s*(?:[""'](?<1>\/url\?q=https:[^""']*)[""']|(?<1>\/url\?q=https:\S+))";
         
            MatchCollection matches = Regex.Matches(htmlContent, pattern);

            var positions = new List<int>();

            int currentPosition = 1;
            foreach (Match match in matches)
            {
                string val = match.Groups[1].Value;
                if (val.Contains($"{Url}"))
                {
                    positions.Add(currentPosition);
                }

                currentPosition++;

            }

            return positions;
        }

    }
}
