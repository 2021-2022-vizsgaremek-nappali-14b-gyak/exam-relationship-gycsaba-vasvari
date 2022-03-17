using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Repositories;

namespace Kreta.Services
{
    class StudentOfClassService
    {
        ClassesRepo classesRepo;
        StudentsRepo studentsRepo;

        public StudentOfClassService()
        {
            classesRepo = new ClassesRepo();
            studentsRepo = new StudentsRepo();
        }

        public List<string> Classes
        {
            get 
            {
                return classesRepo.Classes.Select(schoolClass => schoolClass.GradeGradeType).ToList();
            }
        }

    }
}
