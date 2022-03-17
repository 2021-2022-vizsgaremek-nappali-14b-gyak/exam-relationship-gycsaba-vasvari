using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using Kreta.Services;
using ViewModels.BaseClass;


namespace Kreta.ViewModel
{
    public class StudentOfClassViewModel : ViewModelBase
    {
        private ObservableCollection<string> classes;
        private ObservableCollection<string> studentsOfClass;
        private StudentOfClassService studentOfClassService;

        private int selectedIndex;

        public StudentOfClassViewModel()
        {
            selectedIndex = 0;
            studentOfClassService = new StudentOfClassService();
            classes = new ObservableCollection<string>();            
            studentsOfClass = new ObservableCollection<string>();
        }

        public ObservableCollection<string> Classes
        {
            get 
            {
                classes.Clear();
                classes = new ObservableCollection<string>(studentOfClassService.Classes);
                return classes;
            }
        }

        public ObservableCollection<string> StudentsOfClass
        {
            get { return studentsOfClass; }
        }

        public int SelectedIndex
        {
            get
            {
                return selectedIndex;
            }
            set
            {
                selectedIndex = value;
                OnPropertyChanged("SelectedIndex");
            }
        }
    }
}
