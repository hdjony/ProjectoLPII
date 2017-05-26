using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using TrabalhoPratico1.Views;
using TrabalhoPratico1.Repository;

namespace TrabalhoPratico1
{
    /// <summary>
    /// Interaction logic for index.xaml
    /// </summary>
    public partial class index : Page
    {
        public index()
        {
            UserRepository.getInstance();
            InitializeComponent();
        }
        

        private void ButtonIniciar_Click(object sender, RoutedEventArgs e)
        {
            if (true)
            {
             //utilizador.
            }
            else
            {
                //MessageBox.Show("Utilizador ou a palavra passe nao encontrado!");
            }
        }

        private void ButtonCancelar_Click(object sender, RoutedEventArgs e)
        {
            UtilizadorPage criarConta = new UtilizadorPage();
            NavigationService.Navigate(criarConta);
            
        }

        private void ButtonIniciar_Click_1(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            NavigationService.Navigate(loginPage);

        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
