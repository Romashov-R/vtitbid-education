using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vtitbid.Education.ISP19.Wpf.Training.Models
{
    public class Speciality
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public ICollection<Group> Groups { get; set; }
        [NotMapped]
        public string FullName => $"{Code} {Name}";
        public Speciality()
        {
            Groups = new HashSet<Group>();
        }
    }
}
