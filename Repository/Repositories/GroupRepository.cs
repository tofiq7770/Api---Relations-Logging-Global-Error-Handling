using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
	{
		public GroupRepository(AppDbContext context) : base(context) { }



        public async Task<IEnumerable<Group>> GetAllWithStudents()
        {
            return await _entities.Include(e => e.Students).ToListAsync();
        }
    }
}

