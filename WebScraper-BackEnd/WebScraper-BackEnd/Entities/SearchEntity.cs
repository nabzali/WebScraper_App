using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebScraper_BackEnd.Entities
{
    public class SearchEntity
    {
        [Key]
        public int Id { get; set; }
        public string SearchTerms { get; set; }
        public string Url { get; set; }
        public string Occurrences { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
