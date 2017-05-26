using System;
using System.Collections.Generic;
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
using TrabalhoPratico1.ViewModel;

namespace TrabalhoPratico1.Views
{
    /// <summary>
    /// Interaction logic for TarefaPage.xaml
    /// </summary>
    public partial class TarefaPage : Page
    {
        public TarefaPage()
        {
            InitializeComponent();
            DataContext = new TarefaViewModel();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ((TarefaViewModel)DataContext).AddTarefa(UsernameTextBox.Text, PasswordPasswordBox.Password);
        }

        private void ButtonApagarUtilizador_OnClick(object sender, RoutedEventArgs e)
        {
            string utilizador = ((Button)sender).CommandParameter as string;
            ((TarefaViewModel)DataContext).DeleteTarefa(utilizador);
        }
    }
}
