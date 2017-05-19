﻿using System.Collections.Generic;
using System.IO;
using TrabalhoPratico1.Models;
using Newtonsoft.Json;
using System;

namespace TrabalhoPratico1.Repository
{
    class DataModelRepository
    {

        public DataModel dataModel { get; set; } = new DataModel();
        static DataModelRepository instance;

        string path = @"C:\Users\Public\TestFolder\WriteLines.json"; //caminho para ficheiro

        public static DataModelRepository getInstance()
        { //obter instancia da classe

            if (instance == null) //verifica se class já está inicializada
            {
                instance = new DataModelRepository();    //se nao estiver inicializa
            }
            return instance;  //retorna a sua instancia
        }

        private DataModelRepository()
        {
            if (!File.Exists(path))
            {
                // Create a file to write to.
                var file = File.CreateText(path);
                file.Close();
            }
            ReadDataModel();
        }

        public void ReadDataModel()
        {
            string data = string.Empty;

            try
            {
                data = System.IO.File.ReadAllText(path);
            }
            catch (IOException e)
            {
                Console.WriteLine("Não foi possível abrir o ficheiro backup.txt.");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            dataModel = JsonConvert.DeserializeObject<DataModel>(data);
            if (dataModel == null)
            {
                dataModel = new DataModel();
            }
        }

        public bool WriteDataModel()
        {
            try
            {
                string dataToSave = JsonConvert.SerializeObject(this.dataModel);
                System.IO.File.WriteAllText(path, dataToSave);
            }
            catch (IOException e)
            {
                return false;
            }

            return true;

        }
    }
}
