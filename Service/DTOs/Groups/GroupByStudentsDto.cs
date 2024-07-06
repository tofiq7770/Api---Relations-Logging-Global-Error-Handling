using System;
using Domain.Entities;

namespace Service.DTOs.Groups
{
	public class GroupByStudentsDto
	{
		public string Name { get; set; }
		public List<string> Students { get; set; }
	}
}

