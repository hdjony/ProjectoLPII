using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrabalhoPratico1.Models;
using TrabalhoPratico1.Repository;

namespace TrabalhoPratico1.Views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click_Criar_utilizador(object sender, RoutedEventArgs e)
        {
            Boards newBoard = null;
            if (TextBoxUser.Text == string.Empty)
            {
                MessageBox.Show("Please enter a value to Nome!");
            }
            else if (TextBoxPassword.Text == string.Empty)
            {
                MessageBox.Show("Please check Palavra-passe!");
            }

            foreach (Utilizador utilizador in UserRepository.getInstance().dataModel.UserList)
            {
                if (utilizador.Nome == TextBoxUser.Text && utilizador.PalavraPasse == TextBoxPassword.Text)
                {
                    newBoard = new Boards();
                    
                }
                
            }
            if (newBoard!=null)
            {
                NavigationService.Navigate(newBoard);
            }
           
        }

        private void Button_Click_Anular(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }

    /*private void Button_Click_Anular(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }*/

}
