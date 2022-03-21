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
        private ObservableCollection<SchoolClass> schoolClasses;
        private ObservableCollection<Student> studentsOfClass;
        private ObservableCollection<Student> studentOfNoClass;

        private StudentOfClassService studentOfClassService;
        
        private int selectedIndex;

        public StudentOfClassViewModel()
        {
            selectedIndex = 0;
            StudentNoClassCommand = new RelayCommand(execute => ShowStudentNoClass());


            studentOfClassService = new StudentOfClassService();
            schoolClasses = new ObservableCollection<SchoolClass>();            
            studentsOfClass = new ObservableCollection<Student>();
            studentOfNoClass = new ObservableCollection<Student>();
        }

        public ObservableCollection<SchoolClass> SchoolClasses
        {
            get 
            {
                schoolClasses.Clear();
                schoolClasses = new ObservableCollection<SchoolClass>(studentOfClassService.Classes);
                return schoolClasses;
            }
        }

        public ObservableCollection<Student> StudentsOfClass
        {
            get 
            {
                List<Student> studentOfClassList = studentOfClassService.GetStudentOfClass(SchoolClass.Id);
                studentsOfClass.Clear();
                studentsOfClass = new ObservableCollection<Student>(studentOfClassList);
                return studentsOfClass; 
            }
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
                OnPropertyChanged("StudentsOfClass");
            }
        }

        public SchoolClass SchoolClass
        {
            get
            {
                if ((selectedIndex >= 0) && (selectedIndex < schoolClasses.Count))
                {
                    return schoolClasses.ElementAt(selectedIndex);
                }
                else if ((selectedIndex < 0) && schoolClasses != null)
                    return schoolClasses.ElementAt(0);
                else
                    return null;
            }
        }

        public RelayCommand StudentNoClassCommand { get; set; }

        public void ShowStudentNoClass()
        {
            studentOfNoClass.Clear();
            studentOfNoClass = new ObservableCollection<Student>(studentOfClassService.GetStudentNoClass());
            OnPropertyChanged("StudentOfNoClass");
        }

        public ObservableCollection<Student> StudentOfNoClass
        {
            get
            {
                return studentOfNoClass;
            }
        }
    }
}
