using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using TrabalhoPratico1.Models;
using TrabalhoPratico1.Repository;

namespace TrabalhoPratico1.Views
{
    /// <summary>
    /// Interaction logic for CriarConta.xaml
    /// </summary>
    public partial class CriarConta : Page
    {
        public CriarConta(int var)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Criar_utilizador(object sender, RoutedEventArgs e)
        {
            Utilizador u = new Utilizador();//instaciar classe utilizador
            u.Nome = User.Text; //passar valores do formulario para classe utilizador
            u.PalavraPasse = Password.Text;//passar valores do formulario para classe utilizador
            /*validação do formulário*/
            if (u.Nome == string.Empty)
            {
                MessageBox.Show("Please enter a value to Nome!");
            }
            else if (u.PalavraPasse == string.Empty)
            {
                MessageBox.Show("Please check Palavra-passe!");
            }
            else
            {

                DataModelRepository.getInstance().dataModel.AddUtilizador(u);

                if (DataModelRepository.getInstance().WriteDataModel())
                {
                    MessageBox.Show("Dados Guardados com sucesso.");

                    CriarConta criarConta = new CriarConta(10);
                    NavigationService.GoBack();
                }

                else
                {
                    MessageBox.Show("Ooopsss, algo inesperado aconteceu!");
                }
            }
            /* string idade;//variaveis auxiliares
             idade = Idade.Text;//atribuição de valores de formulario a uma variavel auxiliar

             string nome;//variaveis auxiliares
             nome = User.Text;*/
            /*teste para ver se os dados estao a ser recebidos.*/

            /*MessageBox.Show("Idade="+idade+"Nome="+nome);*/

            //System.IO.File.AppendAllText(@"C:\Users\Public\TestFolder\WriteLines.txt", string.Format(nome+","+ idade,Environment.NewLine));*/

        }

        private void Button_Click_Anular(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
