using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using TrabalhoPratico1.Models;
using Newtonsoft.Json;
using System.IO;
using TrabalhoPratico1.Repository;
using TrabalhoPratico1.ViewModel;

namespace TrabalhoPratico1.Views
{
    /// <summary>
    /// Interaction logic for Boards.xaml
    /// </summary>
    /// 

    public partial class Boards : Page
    {

        public Boards()
        {
           
            InitializeComponent();
            UserRepository.getInstance().ReadDataModel();
            //LeftListBox.ItemsSource = TarefaRepository.Instance.TarefaList;

            //DataContext = new TarefaViewModel().TarefaList;
            //DataContext= new DataModelRepository.getInstance().dataModel.ListaTarefa;
            
            lvDataBinding.ItemsSource = UserRepository.getInstance().dataModel.ListaTarefa;
            DataContext = this;

        }
#region Buttons Controls
       
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
           // ((TarefaViewModel)DataContext).AddTarefa(DescricaoTextBox.Text, TarefanameTextBox.Text);
        }

        private void ButtonApagarUtilizador_OnClick(object sender, RoutedEventArgs e)
        {
            string utilizador = ((Button)sender).CommandParameter as string;
            ((TarefaViewModel)DataContext).DeleteTarefa(utilizador);
        }


    }
    #endregion
}
