using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App7.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App7.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cadastro_atividade : ContentPage
    {
        public cadastro_atividade()
        {
            InitializeComponent();

            BindingContext = new cadastroAtividadeViewModel(); 
        }
    }
}