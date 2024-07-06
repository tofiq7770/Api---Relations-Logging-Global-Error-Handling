using Domain.Common;

namespace Domain.Entities
{
    public class Student : BaseEntity
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}

