using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TrabalhoPratico1.Models;
using TrabalhoPratico1.Repository;

namespace TrabalhoPratico1.ViewModel
{
   public class UtilizadorViewModel: ViewModelBase
    {
        public UtilizadorViewModel()
        {

            UtilizadorList = new ObservableCollection<Utilizador>(UtilizadorRepository.Instance.LerListaUtilizador());
        }

        private ObservableCollection<Utilizador> _UtilizadorList;
        public ObservableCollection<Utilizador> UtilizadorList
        {
            get { return _UtilizadorList; }
            private set { Set(ref _UtilizadorList, value); }
        }

        public void AddUser(string nome, string palavrapasse)
        {
            Utilizador utilizador = new Utilizador() { Nome = nome, PalavraPasse = palavrapasse };
            UtilizadorList.Add(utilizador);
            //TarefaRepository.Instance.TarefaList.Add(tarefa);
            //DataModelRepository.getInstance().dataModel.ListaTarefa.Add(tarefa);
            UserRepository.getInstance().dataModel.AddUtilizador(utilizador);
            if (UserRepository.getInstance().WriteDataModel())
            {
                MessageBox.Show("Dados Guardados com sucesso.");
            }

            else
            {
                MessageBox.Show("Ooopsss, algo inesperado aconteceu!");
            }
        }

        public void DeleteUser(string nome)
        {
            Utilizador utilizadorRemover = UtilizadorList.FirstOrDefault(u => u.Nome == nome);
            if (utilizadorRemover != null)
            {
                UtilizadorList.Remove(utilizadorRemover);
                UtilizadorRepository.Instance.UtilizadorList.Remove(utilizadorRemover);
                UserRepository.getInstance().dataModel.UserList.Remove(utilizadorRemover);
                UserRepository.getInstance().WriteDataModel();
            }
        }
    }
}
