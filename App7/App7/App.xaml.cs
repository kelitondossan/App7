using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App7.Helps;
using System.IO;

namespace App7
{
    public partial class App : Application
    {

        static SQLiteDataBaseHelps database;
        
        public static SQLiteDataBaseHelps DataBase
        
        {
            get
            {
                if(database == null)
                {
                    database = new SQLiteDataBaseHelps(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "xamAppft.db3"));
             
               }
                return database;
            }
           

        }


        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
