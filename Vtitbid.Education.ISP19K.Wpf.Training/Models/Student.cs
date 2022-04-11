namespace Vtitbid.Education.ISP19K.Wpf.Training.Models
{
    public class Student
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int GroupId { get; set; }
        public virtual Person Person { get; set; } = null!;
        public virtual Group Group { get; set; } = null!;
    }
}
