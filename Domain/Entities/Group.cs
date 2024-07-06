using System;
using Domain.Common;

namespace Domain.Entities
{
	public class Group : BaseEntity
	{
		public string Name { get; set; }
		public ICollection<Student> Students { get; set; }
	}
}

