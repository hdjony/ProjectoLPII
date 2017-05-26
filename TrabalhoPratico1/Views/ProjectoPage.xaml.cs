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
using TrabalhoPratico1.Repository;
using TrabalhoPratico1.ViewModel;

namespace TrabalhoPratico1.Views
{
    /// <summary>
    /// Interaction logic for ProhectoView.xaml
    /// </summary>
    public partial class ProhectoView : Page
    {
        public ProhectoView()
        {

            InitializeComponent();
            DataContext = new ProjectoViewModel();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ((ProjectoViewModel)DataContext).AddProjecto(ProjectNameTextBox.Text, DescricaoTextBox.Text);
        }

        private void ButtonApagarUtilizador_OnClick(object sender, RoutedEventArgs e)
        {
            string utilizador = ((Button)sender).CommandParameter as string;
            ((ProjectoViewModel)DataContext).DeleteProjecto(utilizador);
        }

    }
}
