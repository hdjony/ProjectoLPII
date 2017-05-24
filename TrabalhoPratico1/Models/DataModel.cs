using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico1.Models
{
    class DataModel
    {
        public List<Projecto> ProjectList { get; set; } = new List<Projecto>();
        public List<Utilizador> UserList { get; set; } = new List<Utilizador>();
        public List<Tarefa> ListaTarefa { get; set; } = new List<Tarefa>();

        public DataModel()
        {
            
        }

        public void AddUtilizador(Utilizador utilizador)
        {
            UserList.Add(utilizador);
        }

        public void AddProjecto(Projecto projeto)
        {
            ProjectList.Add(projeto);
        }
    }
}
