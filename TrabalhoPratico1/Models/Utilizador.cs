using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico1.Models
{
    class Utilizador
    {
        public string Nome { get; set; }
        public string PalavraPasse { get; set; }
        //public List<Projecto> ListaProjetosUtilizador;

        public Utilizador() { }

        public Utilizador(string Nome, string PalavraPasse) {
            this.Nome = Nome;
            this.PalavraPasse = PalavraPasse;
        }

    }
}
