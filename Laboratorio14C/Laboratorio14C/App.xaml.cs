using Laboratorio14C.DataContext;
using Laboratorio14C.Interfaces;
using Laboratorio14C.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio14C
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            MainPage = new CoursesListView();
        }
        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
