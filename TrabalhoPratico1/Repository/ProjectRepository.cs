using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPratico1.Models;

namespace TrabalhoPratico1.Repository
{
    public sealed class ProjectRepository
    {

        public List<Projecto> ProjectoList { get; set; }
        //public static TarefaRepository Instance { get; } = new TarefaRepository();



        private ProjectRepository()

        {

        }

        private static ProjectRepository instance = null;

        public static ProjectRepository Instance

        {

            get

            {

                if (instance == null)

                {

                    instance = new ProjectRepository();

                }

                return instance;


            }

        }
        public List<Projecto> LerListaProjectos()
        {

            return ProjectoList = UserRepository.getInstance().dataModel.ProjectList;
        }
    }
}
