using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Laboratorio14C.ViewModels
{
    public class CoursesInsertViewModel : BaseViewModel
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { SetValue(ref name, value); }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { SetValue(ref description, value); }
        }

        private decimal credit;
        public decimal Credit
        {
            get { return credit; }
            set { SetValue(ref credit, value); }
        }

        private DateTime startDate;
        public DateTime StartDate
        {
            get { return startDate; }
            set { SetValue(ref startDate, value); }
        }

        public ICommand SaveCommand { get; set; }

        public CoursesInsertViewModel()
        {
            SaveCommand = new Command(ExecuteSaveCommand);
        }

        private void ExecuteSaveCommand()
        {
            // Aquí puedes realizar la lógica para guardar los datos en la base de datos
            // Puedes acceder a los valores de las propiedades Name, Description, Credit y StartDate
            // para guardarlos en la base de datos o realizar cualquier otro procesamiento necesario

            // Ejemplo: Mostrar un mensaje con los valores ingresados
            string message = $"Nombre: {Name}\nDescripción: {Description}\nCrédito: {Credit}\nFecha de inicio: {StartDate}";
            Application.Current.MainPage.DisplayAlert("Datos ingresados", message, "Aceptar");

            // También puedes llamar a una función o servicio para realizar la inserción en la base de datos
            // Por ejemplo: courseService.InsertCourse(Name, Description, Credit, StartDate);
        }
    }
}
