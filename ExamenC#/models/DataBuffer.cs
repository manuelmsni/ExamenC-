using ExamenC_.clients;
using ExamenC_.utils;
using OnlyZoo.util;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC_.models
{
    public class DataBuffer
    {
        private static DataBuffer Instance { get; set; }
        public List<CustomObject> CustomObjects { get; set; }
        private DataBuffer() {
            CustomObjects = new List<CustomObject>();
        }
        public static DataBuffer GetInstance() {
            if(Instance == null) Instance = new DataBuffer();
            return Instance;
        }
        public async Task UpdateCustomObjects()
        {
            try
            {
                MainForm.SetStatus("Fetching data...");
                CustomObjectList temp = await HttpJsonClient<CustomObjectList>.RequestDataAsync(Constants.BASE_URL_API, Constants.CUSTOM_OBJECT_API);
                CustomObjects = temp.Results;
            } catch (Exception ex)
            {
                MainForm.SetStatus("Error fetching the data!");
                ErrorManager.Register(ex);
            }
            MainForm.SetStatus("Data loaded!");
        }
    }
}
