using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using TrabalhoPratico1.Models;
using TrabalhoPratico1.Repository;
using TrabalhoPratico1.ViewModel;

namespace TrabalhoPratico1.Views
{
    /// <summary>
    /// Interaction logic for CriarConta.xaml
    /// </summary>
    public partial class UtilizadorPage : Page
    {
        public UtilizadorPage()
        {
            InitializeComponent();

            DataContext = new UtilizadorViewModel();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to Nome!");
            }
            else if (PasswordPasswordBox.Password == string.Empty)
            {
                MessageBox.Show("Please check Palavra-passe!");
            }
            else
            {
                ((UtilizadorViewModel)DataContext).AddUser(UsernameTextBox.Text, PasswordPasswordBox.Password);
            }
        }

        private void ButtonApagarUtilizador_OnClick(object sender, RoutedEventArgs e)
        {
            string utilizador = ((Button)sender).CommandParameter as string;
            ((UtilizadorViewModel)DataContext).DeleteUser(utilizador);
        }

        private void Button_Click_Anular(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
