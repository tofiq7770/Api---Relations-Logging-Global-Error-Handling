using AutoMapper;
using Domain.Entities;
using Service.DTOs.Groups;

namespace Service.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Group, GroupDto>();
            CreateMap<GroupCreateDto, Group>();
            CreateMap<Group, GroupByStudentsDto>();

        }
    }
}

