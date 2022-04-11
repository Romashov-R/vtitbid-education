using System.Collections.Generic;

namespace Vtitbid.Education.ISP19.Wpf.Training.Models
{
    public class Group
    {        
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string Name { get; set; } = null!;
        public int SpecialityId { get; set; }
        public int CuratorId { get; set; }
        public virtual Speciality Speciality { get; set; } = null!;
        public virtual Employee Curator { get; set; } = null!;
        public virtual ICollection<Student> Students { get; set; }

        public Group()
        {
            Students = new HashSet<Student>();
        }
    }
}
