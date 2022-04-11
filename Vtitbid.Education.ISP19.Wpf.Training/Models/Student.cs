using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vtitbid.Education.ISP19.Wpf.Training.Models
{
    public class Student : IPerson
    {        
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int GroupId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? MiddleName { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; } = null!;
        public virtual Group Group { get; set; } = null!;
    }
}
