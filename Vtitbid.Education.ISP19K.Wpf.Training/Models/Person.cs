using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vtitbid.Education.ISP19K.Wpf.Training.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? MiddleName { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
