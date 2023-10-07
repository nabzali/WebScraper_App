using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Text.Json;
using WebScraper_BackEnd.Entities;
using WebScraper_BackEnd.Models;

namespace WebScraper_BackEnd.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<SearchResponseModel, SearchEntity>()
                .ForMember(dest => dest.Occurrences, opt => opt.MapFrom(src => IntListToJson(src.Occurrences)));
            CreateMap<SearchEntity, SearchResponseModel>()
                .ForMember(dest => dest.Occurrences, opt => opt.MapFrom(src => JsonToIntList(src.Occurrences)));
        }

        private static string IntListToJson(List<int> value)
        {
            return JsonSerializer.Serialize(value);
        }

        private static List<int> JsonToIntList(string value)
        {
            return JsonSerializer.Deserialize<List<int>>(value);
        }
    }
}
