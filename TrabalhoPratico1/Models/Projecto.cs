using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico1.Models
{
    class Projecto
    {
        /*Declaração Variaveis*/

        public string Descricao { get; set; }//breve descrição sobre o projeto
        public string Tipo { get; set; }//que tipo de projecto
        public string Estado { get; set; }
        public Utilizador Utilizador { get; set; }//um projecto pode ter um utilizador ou mais.

    }
}
