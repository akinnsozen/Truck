using AutoMapper;
using TRUCK.Model.Entities;
using TRUCK.Models.ViewModels;

namespace TRUCK.AutoMapper
{
    public class MappingProfile : Profile

    {
        public MappingProfile()
        {
            CreateMap<Sales, RentAddViewModel>().ReverseMap();
        }

     

    }
}
