using System.Collections.Generic;

namespace Vtitbid.Education.ISP19K.Wpf.Training.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int PositionId { get; set; }
        public virtual Person Person { get; set; } = null!;
        public virtual Position Position { get; set; } = null!;
        public virtual ICollection<Group> Groups { get; set; }

        public Employee()
        {
            Groups = new HashSet<Group>();
        }
    }
}
