using System;
using System.Collections.Generic;
using System.Text;

namespace Z2
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            int countRows = dataset.GetData().Count;
            double[][] convertedData = new double[countRows][];
            int countColumns = 0;
            foreach (var data in dataset.GetData())
            {
                countColumns = 0;
                foreach (var item in data)
                {
                    countColumns++;
                }
            }
            int i;
            for (i = 0; i < countRows; i++)
            {
                convertedData[i] = new double[countColumns];
            }
            i = 0;
            int z = 0;
            foreach (var data in dataset.GetData())
            {
                z = 0;
                foreach (var item in data)
                {
                    convertedData[i][z] = item;
                    z++;
                }
                i++;
            }
            return convertedData;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
