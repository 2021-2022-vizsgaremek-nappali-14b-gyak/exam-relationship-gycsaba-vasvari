using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using Kreta.Services;
using ViewModels.BaseClass;
using Kreta.Models;


namespace Kreta.ViewModel
{
    public class StudentOfClassViewModel : ViewModelBase
    {
        private ObservableCollection<Class> classes;
        private ObservableCollection<string> studentsOfClass;
        private StudentOfClassService studentOfClassService;

        private int selectedIndex;

        public StudentOfClassViewModel()
        {
            selectedIndex = 0;
            studentOfClassService = new StudentOfClassService();
            classes = new ObservableCollection<Class>();            
            studentsOfClass = new ObservableCollection<string>();
        }

        public ObservableCollection<Class> Classes
        {
            get 
            {
                classes.Clear();
                classes = new ObservableCollection<Class>(studentOfClassService.Classes);
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
