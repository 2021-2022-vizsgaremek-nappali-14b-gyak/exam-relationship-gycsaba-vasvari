using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace Kreta.ViewModel
{
    public class StudentOfClassViewModel
    {
        private ObservableCollection<string> classes;
        private ObservableCollection<string> studentsOfClass;

        public StudentOfClassViewModel()
        {
            classes = new ObservableCollection<string>();
            studentsOfClass = new ObservableCollection<string>();
        }

        public ObservableCollection<string> Classes
        {
            get { return classes;}
        }

        public ObservableCollection<string> StudentOfClass
        {
            get { return studentsOfClass; }
        }
    }
}
