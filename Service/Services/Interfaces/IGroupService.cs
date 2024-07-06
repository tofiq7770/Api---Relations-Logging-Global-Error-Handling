using System;
using Service.DTOs.Groups;

namespace Service.Services.Interfaces
{
	public interface IGroupService
	{
		Task<IEnumerable<GroupDto>> GetAllAsync();
		Task<GroupDto> GetByIdAsync(int id);
		Task CreateAsync(GroupCreateDto group);
        Task<IEnumerable<GroupByStudentsDto>> GetAllWithStudentsAsync();

    }
}

