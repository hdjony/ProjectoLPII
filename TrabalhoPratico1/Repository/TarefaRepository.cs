using System.Collections.Generic;
using TrabalhoPratico1.Models;

namespace TrabalhoPratico1.Repository
{
    public sealed class TarefaRepository
    {
        public List<Tarefa> TarefaList { get; set; }
        //public static TarefaRepository Instance { get; } = new TarefaRepository();

       

            private TarefaRepository()

            {

            }

            private static TarefaRepository instance = null;

            public static TarefaRepository Instance

            {

                get

                {

                    if (instance == null)

                    {

                        instance = new TarefaRepository();

                    }

                    return instance;

                
                 }

            }
        public List<Tarefa> LerListaTarefas ()
        {

            return TarefaList = UserRepository.getInstance().dataModel.ListaTarefa; 
        }
    }
}
