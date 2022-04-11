using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vtitbid.Education.ISP19.Wpf.Training.Models
{
    public class Position
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string Name { get; set; } = null!;
        public ICollection<Employee> Employees { get; set; }

        public Position()
        {
            Employees = new HashSet<Employee>();
        }
    }
}
