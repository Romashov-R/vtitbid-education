using System;
using System.Collections.Generic;

namespace Vtitbid.Education.ISP19.Wpf.Training.Models
{
    public class Employee : IPerson
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int PositionId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? MiddleName { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; } = null!;
        public virtual Position Position { get; set; } = null!;
        public virtual ICollection<Group> Groups { get; set; }

        public Employee()
        {
            Groups = new HashSet<Group>();
        }
    }
}
