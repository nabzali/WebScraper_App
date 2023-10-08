namespace WebScraper_BackEnd.ViewModels
{
    public class SearchResponseViewModel
    {
        public int Id { get; set; }
        public string SearchTerms { get; set; }
        public string Url { get; set; }
        public List<int> Occurrences { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
