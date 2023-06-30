using Laboratorio14C.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Laboratorio14C.ViewModels
{
    public class CoursesListViewModel : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { SetValue(ref color, value); }
        }

        private ObservableCollection<Course> courses;
        public ObservableCollection<Course> Courses
        {
            get { return courses; }
            set { SetValue(ref courses, value); }
        }

        public ICommand SearchCommand { get; set; }

        public CoursesListViewModel()
        {
            SearchCommand = new Command(ExecuteSearchCommand);
            LoadCourses();
        }

        private void ExecuteSearchCommand()
        {
            // Implementar lógica de búsqueda si es necesario
        }

        private void LoadCourses()
        {
            // Simular la carga de los cursos desde una fuente de datos
            List<Course> loadedCourses = new List<Course>()
            {
                new Course { Id = 1, Name = "Curso asd1", Description = "Descripción del curso 1", Credit = 3.5m, StartDate = DateTime.Now },
                new Course { Id = 2, Name = "Curso 2", Description = "Descripción del curso 2", Credit = 4.0m, StartDate = DateTime.Now.AddDays(7) },
                new Course { Id = 3, Name = "Curso 3", Description = "Descripción del curso 3", Credit = 2.5m, StartDate = DateTime.Now.AddDays(14) }
            };

            Courses = new ObservableCollection<Course>(loadedCourses);
        }
    }
}
