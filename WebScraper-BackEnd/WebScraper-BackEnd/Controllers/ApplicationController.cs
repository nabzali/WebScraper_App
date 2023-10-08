using Microsoft.AspNetCore.Mvc;
using WebScraper_BackEnd.Models;
using WebScraper_BackEnd.Services;

namespace WebScraper_BackEnd.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationService _applicationService;
        public ApplicationController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        // POST
        [Route("search")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SearchRequestModel requestModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            SearchResponseModel searchResult;

            try
            {
                searchResult = await _applicationService.CreateSearchRequest(requestModel);

            }
            catch (Exception e)
            {
                return StatusCode(500, $"An error occurred when performing the requested search. Details: {e}");
            }
                        
            return Ok(searchResult);
        }

        // GET
        [Route("history")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var searchHistory = await _applicationService.GetSearchHistory();
            return Ok(searchHistory);
        }

    }
}
