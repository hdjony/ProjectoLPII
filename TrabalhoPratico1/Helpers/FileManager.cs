using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPratico1.Models;
using TrabalhoPratico1.Repository;

namespace TrabalhoPratico1.Helpers
{
    public class FileManager
    {
        public static void SaveTarefaList()
        {
            string dataToSave = JsonConvert.SerializeObject(TarefaRepository.Instance.TarefaList);
            try
            {
                System.IO.File.WriteAllText("TarefaList.txt", dataToSave);
            }
            catch (IOException e)
            {
                Console.WriteLine("Não foi possível criar/guardar o ficheiro. ");
                Console.WriteLine(e.Message);
            }
        }

        public static List<Tarefa> LoadTarefaList()
        {
            string data = string.Empty;
            if (System.IO.File.Exists("TarefaList.json"))
            {
                try
                {
                    data = System.IO.File.ReadAllText("TarefaList.json");
                }
                catch (IOException e)
                {
                    Console.WriteLine("Não foi possível abrir o ficheiro backup.txt.");
                    Console.WriteLine(e.Message);
                   // Console.ReadKey();
                }
                return JsonConvert.DeserializeObject<List<Tarefa>>(data);
            }
            return new List<Tarefa>();
        }
    }
}
