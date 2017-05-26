using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPratico1.Models;

namespace TrabalhoPratico1.Repository
{
    public sealed class UtilizadorRepository
    {

        public List<Utilizador> UtilizadorList { get; set; }
        //public static TarefaRepository Instance { get; } = new TarefaRepository();



        private UtilizadorRepository()

        {

        }

        private static UtilizadorRepository instance = null;

        public static UtilizadorRepository Instance

        {

            get

            {

                if (instance == null)

                {

                    instance = new UtilizadorRepository();

                }

                return instance;


            }

        }
        public List<Utilizador> LerListaUtilizador()
        {

            return UtilizadorList = UserRepository.getInstance().dataModel.UserList;
        }
    }
}
