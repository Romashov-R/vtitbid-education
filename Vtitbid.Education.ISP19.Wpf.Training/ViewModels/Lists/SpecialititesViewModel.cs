using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtitbid.Education.ISP19.Wpf.Training.Data;
using Vtitbid.Education.ISP19.Wpf.Training.Models;

namespace Vtitbid.Education.ISP19.Wpf.Training.ViewModels.Lists
{
    public class SpecialititesViewModel : ViewModel
    {
        public List<Speciality> Specialities { get; set; }

        public SpecialititesViewModel()
        {
            using(DatabaseContext context = new DatabaseContext())
            {
                Specialities = context.Specialities.ToList();
            }
        }
    }
}
