using System;
using Domain.Entities;
namespace Repository.Repositories.Interfaces
{
	public interface IGroupRepository : IBaseRepository<Group>
	{
		Task<IEnumerable<Group>> GetAllWithStudents();
	}
}

