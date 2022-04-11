using System;

namespace Vtitbid.Education.ISP19.Wpf.Training.Models
{
    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
