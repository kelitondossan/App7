using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App7.ViewModels
{
    internal class cadastroAtividadeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;



        //comando para mostra o alerta na tela que o usuario clicou 
        public ICommand NovaAtividade
        {
            get => new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("Alerta ", "vc Clicou", "Ok");
            });
        }

        //camndo alerta mostrando na tela que salvou o arquivo

        public ICommand Salvar
        {
            get => new Command(() =>
            {
                Application.Current.MainPage.DisplayAlert("Alerta ", "vc Salvou", "Ok");
            });
        }


    }

}
