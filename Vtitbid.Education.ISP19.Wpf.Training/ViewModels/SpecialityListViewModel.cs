using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vtitbid.Education.ISP19.Wpf.Training.Data;
using Vtitbid.Education.ISP19.Wpf.Training.Models;

namespace Vtitbid.Education.ISP19.Wpf.Training.ViewModels
{
    public class SpecialityListViewModel : ViewModel
    {
        private List<Speciality> _specialitites;
        public List<Speciality> Specialitites 
        { 
            get => _specialitites; 
            set => Set(ref _specialitites, value, nameof(Specialitites)); 
        }

        public SpecialityListViewModel()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                Specialitites = context.Specialities.ToList();
            }
        }
    }
}
