using System;
using AutoMapper;
using Domain.Entities;
using Repository.Repositories.Interfaces;
using Service.DTOs.Groups;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class GroupService : IGroupService
	{
        public readonly IGroupRepository _groupRepo;
        public readonly IMapper _mapper;


        public GroupService(IGroupRepository groupRepo, IMapper mapper)
        {
            _groupRepo = groupRepo;
            _mapper = mapper;   

        }

        public async Task CreateAsync(GroupCreateDto group)
        {
            await _groupRepo.CreateAsync(_mapper.Map<Group>(group));
        }

        public async Task<IEnumerable<GroupDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<GroupDto>>(await _groupRepo.GetAllAsync());
        }

        public async Task<IEnumerable<GroupByStudentsDto>> GetAllWithStudentsAsync()
        {
            return _mapper.Map<IEnumerable<GroupByStudentsDto>>(await _groupRepo.GetAllWithStudents());
        }

        public async Task<GroupDto> GetByIdAsync(int id)
        {
            return _mapper.Map<GroupDto>(await _groupRepo.GetByIdAsync(id));
        }
    }
}

