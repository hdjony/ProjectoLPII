using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using TrabalhoPratico1.Models;
using TrabalhoPratico1.Repository;

namespace TrabalhoPratico1.ViewModel
{
    public class TarefaViewModel:ViewModelBase
    {
        public TarefaViewModel()
        {

            TarefaList = new ObservableCollection<Tarefa>(TarefaRepository.Instance.LerListaTarefas());
        }

        private ObservableCollection<Tarefa> _TarefaList;
        public ObservableCollection<Tarefa> TarefaList
        {
            get { return _TarefaList; }
            private set { Set(ref _TarefaList, value); }
        }

        public void AddTarefa(string descricao, string name)
        {
            Tarefa tarefa = new Tarefa() { Nome = name, Descricao = descricao };
            TarefaList.Add(tarefa);
            //TarefaRepository.Instance.TarefaList.Add(tarefa);
            //DataModelRepository.getInstance().dataModel.ListaTarefa.Add(tarefa);
            UserRepository.getInstance().dataModel.AddTarefa(tarefa);
            if (UserRepository.getInstance().WriteDataModel())
            {
                MessageBox.Show("Dados Guardados com sucesso.");
            }

            else
            {
                MessageBox.Show("Ooopsss, algo inesperado aconteceu!");
            }
            //FileManager.SaveTarefaList();
        }

        public void DeleteTarefa(string Name)
        {
            Tarefa tarefaRemover = TarefaList.FirstOrDefault(u => u.Nome == Name);
            if (tarefaRemover != null)
            {
                TarefaList.Remove(tarefaRemover);
                TarefaRepository.Instance.TarefaList.Remove(tarefaRemover);
                UserRepository.getInstance().dataModel.ListaTarefa.Remove(tarefaRemover);
                UserRepository.getInstance().WriteDataModel();
                //FileManager.SaveTarefaList();
            }
        }
    }
}
