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
     public class ProjectoViewModel:ViewModelBase
    {

        public ProjectoViewModel()
        {
            

            ProjectoList = new ObservableCollection<Projecto>(ProjectRepository.Instance.LerListaProjectos());
        }

        private ObservableCollection<Projecto> _ProjectoList;
        public ObservableCollection<Projecto> ProjectoList
        {
            get { return _ProjectoList; }
            private set { Set(ref _ProjectoList, value); }
        }

        public void AddProjecto(string Descricao, string Name)
        {
            Projecto projecto = new Projecto() { Nome = Name, Descricao = Descricao };
            ProjectoList.Add(projecto);
            ProjectRepository.Instance.ProjectoList.Add(projecto);
            //DataModelRepository.getInstance().dataModel.ListaTarefa.Add(tarefa);
            UserRepository.getInstance().dataModel.AddProjecto(projecto);
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

        public void DeleteProjecto(string Name)
        {
            Projecto projectoPagar = ProjectoList.FirstOrDefault(u => u.Nome == Name);
            if (projectoPagar != null)
            {
                ProjectoList.Remove(projectoPagar);
                ProjectRepository.Instance.ProjectoList.Remove(projectoPagar);
                UserRepository.getInstance().dataModel.ProjectList.Remove(projectoPagar);
                UserRepository.getInstance().WriteDataModel();
                //FileManager.SaveTarefaList();
               
            }
        }
    }
}
