using System;
using System.Collections.Generic;

namespace Z1
{
    [Serializable]
    class Dataset : Prototype
    {
        private List<List<string>> data;
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
                new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }
        //Metoda napravljena da pokazemo kako radi kloniranje
        public void AddData()
        {
            List<string> testing = new List<string>();
            string test = "Text";
            string test1 = "Text1";
            testing.Add(test);
            testing.Add(test1);
            this.data.Add(testing);
        }

        public void PrintData()
        {
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Count; j++)
                {
                    Console.Write(data[i][j]);
                }
                Console.WriteLine(" ");
            }
        }
        public Prototype ShallowClone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

}