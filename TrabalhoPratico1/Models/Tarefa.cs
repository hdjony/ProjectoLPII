using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPratico1.Models
{
    public class Tarefa
    {   
        /*declaracao variaveis*/
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Tempo { get; set; }
        public TipoTarefa tipoTarefa { get; set; }
        public List<Tarefa> subTarefa { get; set; }

        /*indicação em que board esta */
    }
}
